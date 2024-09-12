using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLForm.Base
{

    public interface ITaskRun
    { 
        void Run();
    }

    public class QueuesTask
    {
        static QueuesTask _queuesTask;
        static object _lock = new object();
        static Queue<ITaskRun> queue;
        QueuesTask() { }

        public static QueuesTask CreateBuilding()
        {
            if (_queuesTask == null)
            {
                lock (_lock)
                {
                    if (_queuesTask == null)
                    {
                        _queuesTask = new QueuesTask();
                        queue = new Queue<ITaskRun>();
                    }

                }
            }
            return _queuesTask;
        }

        public QueuesTask AddQueue(ITaskRun a)
        {
            queue.Enqueue(a);
            return _queuesTask;
        }

    }
}
