using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace exam_2
{
    abstract class ThreadProxy
    {

        protected Thread _thread;
        protected bool _running;

        public Thread Thread { get => _thread; }
        public bool IsAlive { get => _thread.IsAlive; }
        public bool Running { get => _running; }

        public ThreadProxy()
        {
            _thread = new Thread(new ThreadStart(ThreadLoop));
            _running = false;
        }

        protected abstract void Task();

        protected void ThreadLoop()
        {
            while (_running)
            {
                Task();
            }
        }

        public void Start()
        {
            _running = true;
            _thread.Start();
            while (!_thread.IsAlive) ;
        }

        public void Stop()
        {
            _running = false;
            _thread.Join();
        }

    }
}
