﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class FunctionMinus : IFunctionIF
    {
        /// <summary>
        /// 計算結果を返す
        /// </summary>
        /// <param name="value1">計算用の値1</param>
        /// <param name="value2">計算用の値2</param>
        /// <returns></returns>
        public double GetResult(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}
