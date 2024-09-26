using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private CalculatorViewModel viewModel;

        public Calculator()
        {
            InitializeComponent();

            // 表示文字設定
            this.Button1.SetShowString("1");
            this.Button2.SetShowString("2");
            this.Button3.SetShowString("3");
            this.Button4.SetShowString("4");
            this.Button5.SetShowString("5");
            this.Button6.SetShowString("6");
            this.Button7.SetShowString("7");
            this.Button8.SetShowString("8");
            this.Button9.SetShowString("9");
            this.ButtonPlus.SetShowString("+");
            this.ButtonMulti.SetShowString("X");
            this.ButtonDivide.SetShowString("÷");
            this.ButtonMinus.SetShowString("-");

            this.viewModel = new CalculatorViewModel();
        }

        /// <summary>
        /// 計算終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            this.ShowArea.Text = this.viewModel.GetResult();
        }

        /// <summary>
        /// 加算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            this.ShowArea.Text = this.viewModel.SetFunction(CalculatorViewModel.FunctionKinds.plus) + " + ";
        }

        /// <summary>
        /// 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button0_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button0.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button1.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button2.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button3.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 減算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMunus_Click(object sender, EventArgs e)
        {
            this.ShowArea.Text = this.viewModel.SetFunction(CalculatorViewModel.FunctionKinds.minus) + " - ";
        }

        /// <summary>
        /// 乗算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMulti_Click(object sender, EventArgs e)
        {
            this.ShowArea.Text = this.viewModel.SetFunction(CalculatorViewModel.FunctionKinds.multi) + " X ";
        }

        /// <summary>
        /// 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button6.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button5.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button4.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button7.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button8.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button9_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.Button9.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }

        /// <summary>
        /// 除算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDevide_Click(object sender, EventArgs e)
        {
            this.ShowArea.Text = this.viewModel.SetFunction(CalculatorViewModel.FunctionKinds.divide) + " ÷ ";
        }

        /// <summary>
        /// クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.viewModel.ClearData();
            this.ShowArea.Text = string.Empty;
        }

        /// <summary>
        /// 小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            this.viewModel.SetValue(this.ButtonDot.Text);
            this.ShowArea.Text = this.viewModel.GetShowString();
        }
    }
}
