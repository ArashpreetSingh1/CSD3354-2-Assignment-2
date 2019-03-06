﻿using System;
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

    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);

        int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 10;
        }
        public void Method4(MyDelegate myDelegate)
        {
            int result = myDelegate(10);
            Console.WriteLine(result);
       
         
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
           Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);


        }
    }
}





