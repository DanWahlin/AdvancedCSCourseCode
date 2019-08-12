using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7.EventsAndDelegates
{
    public delegate void StageCompletedHandler(object sender,
      StageCompletedEventArgs e);

    public class AssemblyLine
    {
        public event StageCompletedHandler StageCompleted;

        public void StartAssemblyLine(int prodID)
        {
            for (int stage = 1; stage < 6; stage++)
            {
                System.Threading.Thread.Sleep(2000);
                OnStageCompleted(prodID, stage);
            }
        }

        protected virtual void OnStageCompleted(int prodID, int stage)
        {
            if (StageCompleted != null)
            {
                StageCompletedEventArgs args = new StageCompletedEventArgs();
                args.ProductID = prodID;
                args.Stage = stage;
                StageCompleted(this, args);
            }
        }
    }
}
