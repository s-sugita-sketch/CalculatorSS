using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class CustomButton : Button
    {
        [Browsable(true)]
        /// <summary>
        /// 表示文字
        /// </summary>
        public string ShowCharactor;

        /// <summary>
        /// 表示文字列設定
        /// </summary>
        /// <param name="showString"></param>
        public void SetShowString(string showString)
        {
            this.Text = showString;
        }

    }
}
