using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Student Name:- Arashpreet Singh Student Id:-C0727466
//student Name:-Navjot Singh Gill Student Id:- C0726409
// CSD 3354 Section 2
//Assignment 2
//March 6-2019

namespace DelegatesAndEvents
{

    public class Program
    {
        public static void Main()

        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }

    }
    public delegate void MyDelegate();

    public class DelegateExercises
    {
       
         void Method3()
        {
            
            System.Console.WriteLine(MyDelegate.TOString());


        }
    }
}





