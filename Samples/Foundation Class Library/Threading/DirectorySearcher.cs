namespace Chapter2
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    ///      This class is a Windows Forms control that implements a simple directory searcher.
    ///      You provide, through code, a search string and it will search directories on
    ///      a background thread, populating its list box with matches.
    /// </summary>
    public class DirectorySearcher : Control
    {
        // Define a special delegate that handles marshaling
        // lists of file names from the background directory search
        // thread to the thread that contains the list box.
        private delegate void FileListDelegate(string[] files, int startIndex, int count);

        private ListBox listBox;
        private string searchCriteria;
        private bool searching;
        private bool deferSearch;
        private Thread searchThread;
        private FileListDelegate fileListDelegate;
        private EventHandler onSearchComplete;

        public DirectorySearcher()
        {
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            Controls.Add(listBox);

            fileListDelegate = new FileListDelegate(AddFiles);
            onSearchComplete = new EventHandler(OnSearchComplete);
        }

        public string SearchCriteria
        {
            get
            {
                return searchCriteria;
            }
            set
            {
                // If currently searching, abort
                // the search and restart it after
                // setting the new criteria.
                //
                bool wasSearching = Searching;

                if (wasSearching)
                {
                    StopSearch();
                }

                listBox.Items.Clear();
                searchCriteria = value;

                if (wasSearching)
                {
                    BeginSearch();
                }
            }
        }

        public bool Searching
        {
            get
            {
                return searching;
            }
        }

        public event EventHandler SearchComplete;

        /// <summary>
        /// This method is called from the background thread. It is called through
        /// a BeginInvoke call so that it is always marshaled to the thread that
        /// owns the list box control.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        private void AddFiles(string[] files, int startIndex, int count)
        {
            while (count-- > 0)
            {
                listBox.Items.Add(files[startIndex + count]);
            }
        }

        public void BeginSearch()
        {
            // Create the search thread, which 
            // will begin the search.
            // If already searching, do nothing.
            //
            if (Searching)
            {
                return;
            }

            // Start the search if the handle has
            // been created. Otherwise, defer it until the
            // handle has been created.
            if (IsHandleCreated)
            {
                searchThread = new Thread(new ThreadStart(ThreadProcedure));
                searching = true;
                searchThread.Start();
            }
            else
            {
                deferSearch = true;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            // If the handle is being destroyed and you are not
            // recreating it, then abort the search.
            if (!RecreatingHandle)
            {
                StopSearch();
            }
            base.OnHandleDestroyed(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (deferSearch)
            {
                deferSearch = false;
                BeginSearch();
            }
        }

        /// <summary>
        /// This method is called by the background thread when it has finished
        /// the search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSearchComplete(object sender, EventArgs e)
        {
            if (SearchComplete != null)
            {
                SearchComplete(sender, e);
            }
        }

        public void StopSearch()
        {
            if (!searching)
            {
                return;
            }

            if (searchThread.IsAlive)
            {
                searchThread.Abort();
                searchThread.Join();
            }

            searchThread = null;
            searching = false;
        }

        /// <summary>
        /// Recurses the given path, adding all files on that path to 
        /// the list box. After it finishes with the files, it
        /// calls itself once for each directory on the path.
        /// </summary>
        /// <param name="searchPath"></param>
        private void RecurseDirectory(string searchPath)
        {
            // Split searchPath into a directory and a wildcard specification.
            //
            string directory = Path.GetDirectoryName(searchPath);
            string search = Path.GetFileName(searchPath);

            // If a directory or search criteria are not specified, then return.
            //
            if (directory == null || search == null)
            {
                return;
            }

            string[] files;

            // File systems like NTFS that have
            // access permissions might result in exceptions
            // when looking into directories without permission.
            // Catch those exceptions and return.
            try
            {
                files = Directory.GetFiles(directory, search);
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
            catch (DirectoryNotFoundException)
            {
                return;
            }

            // Perform a BeginInvoke call to the list box
            // in order to marshal to the correct thread. It is not
            // very efficient to perform this marshal once for every
            // file, so batch up multiple file calls into one
            // marshal invocation.
            int startingIndex = 0;

            while (startingIndex < files.Length)
            {
                // Batch up 20 files at once, unless at the
                // end.
                //
                int count = 20;
                if (count + startingIndex >= files.Length)
                {
                    count = files.Length - startingIndex;
                }

                // Begin the cross-thread call. Because you are passing
                // immutable objects into this invoke method, you do not have to
                // wait for it to finish. If these were complex objects, you would
                // have to either create new instances of them or 
                // wait for the thread to process this invoke before modifying
                // the objects.
                IAsyncResult r = BeginInvoke(fileListDelegate, new object[] { files, startingIndex, count });
                startingIndex += count;
            }

            // Now that you have finished the files in this directory, recurse for
            // each subdirectory.
            string[] directories = Directory.GetDirectories(directory);
            foreach (string d in directories)
            {
                RecurseDirectory(Path.Combine(d, search));
            }
        }

        /// <summary>
        /// This is the actual thread procedure. This method runs in a background
        /// thread to scan directories. When finished, it simply exits.
        /// </summary>
        private void ThreadProcedure()
        {
            // Get the search string. Individual 
            // field assigns are atomic in .NET, so you do not
            // need to use any thread synchronization to grab
            // the string value here.
            try
            {
                string localSearch = SearchCriteria;

                // Now, search the file system.
                //
                RecurseDirectory(localSearch);
            }
            finally
            {
                // You are done with the search, so update.
                //
                searching = false;

                // Raise an event that notifies the user that
                // the search has terminated.  
                // You do not have to do this through a marshaled call, but
                // marshaling is recommended for the following reason:
                // Users of this control do not know that it is
                // multithreaded, so they expect its events to 
                // come back on the same thread as the control.
                BeginInvoke(onSearchComplete, new object[] { this, EventArgs.Empty });
            }
        }
    }
}

