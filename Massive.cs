using System;

namespace task_3_4
{
    public abstract class Massive <T>: IPrint
    {
        protected Func<T> GetItem;

        protected Massive(Func<T> getItem)
        {
            GetItem = getItem;
        }

        protected abstract void GetMass();
        public abstract void PrintMass();
        
        public void ReCreate()
        {
             GetMass();
        }
    }
}