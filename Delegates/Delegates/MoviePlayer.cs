using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    public class MoviePlayer
    {
        public Movies CurrentMovie { get; set; }

        // Delegate types are functions with specific signature (return vlaue and pramaters)
        // In this case its for void-return and zero-paramaters
        public delegate void MovieFinishHandler();

        //
        public event MovieFinishHandler MovieFinished;

        //True if success and false if failure
        public bool Play()
        {
            Thread.Sleep(3000);

            //this will call all functions subcribed to the event 
            MovieFinished();
            return true;
        }

    }
}
