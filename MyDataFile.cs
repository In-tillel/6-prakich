﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class MyDataFile
    {
        public string Name { get; set; } = "";
        public int Price { get; set; } = 0;
        public MyDataFile(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
