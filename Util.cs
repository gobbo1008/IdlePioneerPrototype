﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IdlePioneerPrototype
{
    class Util
    {
        public static float Evaluate(string expression)
        {
            // Will take a string and evaluate it as a mathematical equation
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return float.Parse((string)row["expression"]);
        }
    }
}
