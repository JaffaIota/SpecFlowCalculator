﻿using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Sub()
        {
            return  FirstNumber - SecondNumber;
        }
        public int Mult()
        {
            return FirstNumber * SecondNumber;
        }
        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }
        public int Mod()
        {
            return FirstNumber % SecondNumber;
        }
    }
}