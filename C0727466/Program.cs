using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Student Name:- Arashpreet Singh Student Id:-C0727466
//student Name:-Navjot Singh Gill Student Id:- C0726409
//2019W CSD 3354 2
//Assignment 2
//March 6-2019

namespace DelegateAndEvents
 {
            public class DelegateExercises
            {
                public delegate void MyDelegate();
                void Method1()
                {
                    Console.WriteLine("Method1");
                    Console.ReadLine();

                }
                public void Method2()
                {
                    MyDelegate myDelegate = new MyDelegate(Method1);
                    myDelegate(50);
                }
            }
        }

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main (string[] args)
        {
            // TO DO: Call Method2 from the DelegateExercises Class
        }
    }
}



