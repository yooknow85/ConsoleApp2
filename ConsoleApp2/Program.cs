using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{

    delegate void FeedBack(int value);

    class Program
    {
        public static void Main(string[] args)
        {
            // StaticDelegateDemo();


            //var query = from x in Enumerable.Range(0, 100).Select(x => x * x);
            //TEST
            //TEST3

        }

        private static void StaticDelegateDemo()
        {
            Console.WriteLine("----StaticDelegateDemo----");
            Counter(1, 3, null);
            Counter(1, 3, FeedbackToConsole);

           // Action<int> n;

            //n = Program.FeedbackToConsole;
        }

        private static void InstanceDelegateDemo()
        {

        }

        private static void ChainDelegateDemo1(Program p)
        {

        }

        private static void ChainDelegateDemo2(Program p)
        {

        }

        private static void Counter(Int32 from, Int32 to, Action<int> fb)
        {
            for (int i = from; i <= to ; i++)
            {
                if (fb != null)
                    fb(i) ;
            }
        }

        private static void FeedbackToConsole(int value)
        {
            Console.WriteLine("FeedbackToConsole:" + value);
        }

        private static void FeedbackToMsgBox(int value)
        {
            Console.WriteLine("FeedbackToMsgBox:" + value);
        }




    }

    
}
