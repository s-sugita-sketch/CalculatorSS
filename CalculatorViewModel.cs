using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorViewModel
    {
        /// <summary>
        /// 除算クラス
        /// </summary>
        private FunctionDivide functionDivide = new FunctionDivide();

        /// <summary>
        /// 乗算クラス
        /// </summary>
        private FunctionMulti functionMulti = new FunctionMulti();

        /// <summary>
        /// 加算クラス
        /// </summary>
        private FunctionPlus functionPlus = new FunctionPlus();

        /// <summary>
        /// 減算クラス
        /// </summary>
        private FunctionMinus functionMinus = new FunctionMinus();

        /// <summary>
        /// 計算用値1
        /// </summary>
        private string value1 = string.Empty;

        /// <summary>
        /// 計算用値2
        /// </summary>
        private string value2 = string.Empty;

        /// <summary>
        /// 計算種類
        /// </summary>
        private FunctionKinds targetFunction = FunctionKinds.none;

        /// <summary>
        /// 計算種類
        /// </summary>
        public enum FunctionKinds
        {
            /// <summary>
            /// 除算
            /// </summary>
            divide,

            /// <summary>
            /// 乗算
            /// </summary>
            multi,

            /// <summary>
            /// 加算
            /// </summary>
            plus,

            /// <summary>
            /// 減算
            /// </summary>
            minus,

            /// <summary>
            /// 無
            /// </summary>
            none,
        }

        /// <summary>
        /// 値設定
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(string value)
        {
            if (targetFunction == FunctionKinds.none)
            {
                this.value1 += value;
            }
            else
            {
                this.value2 += value;
            }
        }

        /// <summary>
        /// 計算方法指定
        /// </summary>
        /// <param name="function"></param>
        public string SetFunction(FunctionKinds function)
        {
            if(function != FunctionKinds.none)
            {
                // 一度計算
                GetResult();
            }

            this.targetFunction = function;

            return this.value1;
        }

        /// <summary>
        /// 計算結果を返す
        /// </summary>
        /// <returns>計算できれば結果、計算できなければ""</returns>
        public string GetResult()
        {
            if (!Double.TryParse(this.value1, out double result1))
            {
                return string.Empty;
            }

            if (!Double.TryParse(this.value2, out double result2))
            {
                return this.value1;
            }

            if (result2 == 0.0 && targetFunction == FunctionKinds.divide)
            {
                // 0除算
                return this.value1 + " ÷ " + this.value2; 
            }

            switch (targetFunction)
            {
                case FunctionKinds.minus:
                    this.value1 = functionMinus.GetResult(result1, result2).ToString();
                    break;
                case FunctionKinds.plus:
                    this.value1 = functionPlus.GetResult(result1, result2).ToString();
                    break;
                case FunctionKinds.multi:
                    this.value1 = functionMulti.GetResult(result1, result2).ToString();
                    break;
                case FunctionKinds.divide:
                    this.value1 = functionDivide.GetResult(result1, result2).ToString();
                    break;
                default:
                    // 何もしない
                    break;
            }

            if (this.targetFunction != FunctionKinds.none)
            {
                this.targetFunction = FunctionKinds.none;
                this.value2 = string.Empty;
            }

            return this.value1;
        }

        /// <summary>
        /// クリア
        /// </summary>
        public void ClearData()
        {
            this.value1 = string.Empty;
            this.value2 = string.Empty;
            this.targetFunction = FunctionKinds.none;
        }
    }
}
