using System;

namespace task_3_4
{
    public class ArrItem
    {

        protected bool UserInput;

        public ArrItem(bool userInput)
        {
            UserInput = userInput;
        }

        protected int GetIntRnd()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

        protected int GetIntUser()
        {
            Console.WriteLine("Введите число: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int GetInt()
        {
            return UserInput ? GetIntUser() : GetIntRnd();
        }

        protected string GetStringRnd()
        {
            Random random = new Random();
            return  Convert.ToString(random.Next(0, 100));
        }

        protected string GetStringUser()
        {
            Console.WriteLine("Введите число: ");
            var res =  Console.ReadLine();
            return res!=null?res:"";
        }
        public string GetString()
        {
            return UserInput ? GetStringUser() : GetStringRnd();
        }
   
        protected bool GetBoolRnd()
        {
            Random random = new Random();
            return  Convert.ToBoolean(random.Next(0, 2));
        }

        protected bool GetBoolUser()
        {
            Console.WriteLine("Введите число: ");
            var res =  Console.ReadLine();
             return Convert.ToBoolean(Console.ReadLine());
       }
        public bool GetBool()
        {
            return UserInput ? GetBoolUser() : GetBoolRnd();
        } 
    }
}