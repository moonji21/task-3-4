using System;
namespace task_3_4
{class Program
{
    static void Main()
    {   var arrItem = new ArrItem(false);
        var mass = new Massive<int>[3];
        mass[0] = new OneDims<int>(2, arrItem.GetInt);
        mass[1] = new TwoDims<int>(3,3, arrItem.GetInt);
        mass[2] = new Steps<int>(3,  arrItem.GetInt);
        var massStr = new Massive<string>[3];
        massStr[0] = new OneDims<string>(3, arrItem.GetString);
        massStr[1] = new TwoDims<string>(4,3, arrItem.GetString);
        massStr[2] = new Steps<string>(4,  arrItem.GetString);
        var massBool = new Massive<bool>[3];
        massBool[0] = new OneDims<bool>(2, arrItem.GetBool);
        massBool[1] = new TwoDims<bool>(3,3, arrItem.GetBool);
        massBool[2] = new Steps<bool>(3,  arrItem.GetBool);
  
    
        Weeks_Day masss = new Weeks_Day();

        IPrint[] prints = new IPrint [] {mass[0],mass[1],mass[2],
        massStr[0],massStr[1],massStr[2],
        massBool[0],massBool[1],massBool[2],
        masss};
        foreach(var printer in prints){
            printer.PrintMass();
            Console.WriteLine(" ");
        }
    }
}

}