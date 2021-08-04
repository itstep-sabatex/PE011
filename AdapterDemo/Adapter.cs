﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class Adapter:Target
    {
        private AdapteeTime _adapteeTime = new AdapteeTime();
        public override DateTime CurrentDate()
        {
            return  DateTime.Parse(_adapteeTime.CurrentDateTime());
        }
    }
}
