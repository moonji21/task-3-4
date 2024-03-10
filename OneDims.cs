using System;

namespace task_3_4
{
    public sealed class OneDims<T> : Massive<T>
    {
        private T[] mass;


        public OneDims(int n, Func<T> getItem):base(getItem)
        {
            mass = new T[n];
           
            ReCreate();

        }

        protected override void GetMass()
        {
           for (int i = 0; i < mass.Length; i++)
            {
               mass[i] = GetItem();
            }
        }

        public override void PrintMass()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }


    }
}