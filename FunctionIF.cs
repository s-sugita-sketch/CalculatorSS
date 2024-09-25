namespace Calculator
{
    /// <summary>
    /// 計算用IF
    /// </summary>
    public interface IFunctionIF
    {
        /// <summary>
        /// 計算結果を返す
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        double GetResult(double value1, double value2);
    }
}
