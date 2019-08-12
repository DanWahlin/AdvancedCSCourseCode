using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7.EventsAndDelegates
{
    public class StageCompletedEventArgs : System.EventArgs
    {
        private int _ProductID;
        private int _Stage;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        public int Stage
        {
            get { return _Stage; }
            set { _Stage = value; }
        }

    }
}
