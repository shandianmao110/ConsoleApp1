﻿using static System.Console;

namespace VariableScopeSample3
{
    class Program
    {
        static int j = 20;
        static void Main(string[] args)
        {
            int j = 30;
            WriteLine(j);
            WriteLine(Program.j);
            return;
        }
        
    }
}