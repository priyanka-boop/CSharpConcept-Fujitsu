﻿using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Demo7
    {
        //accessmodifier static returntype methodname(arguments)

        static void Main22(String[] args)
        {
            int radius = 10;

            Area obj = new Area(); //allocate the memory

            double res = obj.AreaOfCircle(radius);
            Console.WriteLine(res);

            res = obj.AreaOfCircle(20);
            Console.WriteLine(res);

           // double output = obj.AreaOfTriangle(10.5, 62.2);
            //Console.WriteLine(output);

          //  double powerOutput = Math.Pow(5, 3);
           // Console.WriteLine(powerOutput);

            res = Math.Sqrt(64);
            Console.WriteLine(res);

          //  string authorName = obj.GetAuthorName();
          //  Console.WriteLine(authorName);

         //   Area.PrintClassDescription();
          //  Area.Quit();
        }

    }
}