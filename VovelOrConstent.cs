﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPorgramming22
{
    public class VovelOrConstent
    {
        public static void CheckAlphabetVovelOrConstent()
        {
            char ch;
            Console.WriteLine("Enter an Alphabet:");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch =='e' || ch =='i' || ch == 'o' || ch =='u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The entered alphabet" + ch + "is a Vovel");
            }
            else
            {
                Console.WriteLine("The entered alphabet" + ch + "is a constent");
            }
            Console.ReadLine();
        }   
    }
}
