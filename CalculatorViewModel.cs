using System;
using System.Diagnostics;

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
        /// logger
        /// </summary>
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
        /// <param name="value">末尾の文字列</param>
        public void SetValue(string value)
        {
            // 小数点以下5桁までにする
            if (targetFunction == FunctionKinds.none)
            {
                this.value1 += value;
                this.value1 = (value == "." )? GetDecimalString(this.value1) + "." : GetDecimalString(this.value1);
            }
            else
            {
                this.value2 += value;
                this.value2 = (value == ".") ? GetDecimalString(this.value2) + "." : GetDecimalString(this.value2);
            }

            LogOut();
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

            LogOut();

            return this.value1;
        }

        /// <summary>
        /// 計算結果を返す
        /// </summary>
        /// <returns>計算できれば結果、計算できなければ""</returns>
        public string GetResult()
        {
            if (!Decimal.TryParse(this.value1, out decimal result1))
            {
                return string.Empty;
            }

            if (!Decimal.TryParse(this.value2, out decimal result2))
            {
                return this.value1;
            }

            if (result2 == 0 && targetFunction == FunctionKinds.divide)
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

            // 小数点以下5桁までにする
            this.value1 = GetDecimalString(this.value1);

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

            LogOut();
        }

        /// <summary>
        /// 表示用の文字列取得
        /// </summary>
        /// <returns>表示用の文字列</returns>
        public string GetShowString()
        {
            var showString = string.Empty;
            switch (targetFunction)
            {
                case FunctionKinds.minus:
                    showString = this.value1 + " - " + this.value2;
                    break;
                case FunctionKinds.plus:
                    showString = this.value1 + " + " + this.value2;
                    break;
                case FunctionKinds.multi:
                    showString = this.value1 + " X " + this.value2;
                    break;
                case FunctionKinds.divide:
                    showString = this.value1 + " ÷ " + this.value2;
                    break;
                default:
                    showString = this.value1;
                    break;
            }
            return showString;
        }

        /// <summary>
        /// decimalで整えた結果取得
        /// </summary>
        /// <param name="original"></param>
        /// <returns>decimalで整えた結果</returns>
        private string GetDecimalString(string original)
        {
            Decimal.TryParse(original, out decimal result);
            return Decimal.Round(result, 5).ToString();
        }

        /// <summary>
        /// ログ出力
        /// </summary>
        private void LogOut()
        {
#if DEBUG
            Debug.WriteLine(GetShowString());
#else
            logger.Info(GetShowString());
#endif
        }
    }
}
