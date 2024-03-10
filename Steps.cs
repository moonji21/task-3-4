using System;

namespace task_3_4
{
    public sealed class Steps<T> : Massive<T>
    {
        private T[][] mass;
        public Steps(int m,  Func<T> getItem):base(getItem)
        {
            mass = new T[m][];
         
            ReCreate();
        }
        protected override void GetMass()
        {
            int n = mass.GetLength(0);
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int len = random.Next(0, 10);
                mass[i] = new T[len];
                for (int j = 0; j < len; j++)
                {
                    mass[i][j] = GetItem();
                }
            }
        }

        
        public override void PrintMass()
        {
            Console.WriteLine(" ");
            int c = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                foreach (T el in mass[i])
                {
                    if (c != mass[i].Length - 1)
                    {
                        Console.Write($"{el}" + " ");
                        c++;
                    }
                    else
                    {
                        Console.Write($"{el}" + "\n");
                        c = 0;
                    }
                }
            }
            Console.WriteLine(" ");
        }
        
    
    }
}