using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task.WelcomePage
{
    public static class Welcomepage
    {
        internal static void Welcome()
        {
            // Clear the console Screen
            Console.Clear();
            //Set the Title of the console
            Console.Title = "My Weekly Task";
            //Set the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;

            //Set the welcome message
            Console.WriteLine("\n\n                                               Welcome to My Weekly Task                       \n\n");
            Console.WriteLine("\n                                        Title: Language Integrated Query (LINQ)                    \n");
            Console.WriteLine("                                                           By:                                         ");
            Console.WriteLine("                                                  Kehinde Peter Olubiyi                                         ");
            
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"\n                                                  {dateTime}                              \n");
            Utility.Utility.PressEnterToContinue();
        }

}
}
