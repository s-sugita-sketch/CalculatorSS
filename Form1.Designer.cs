﻿namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowArea = new System.Windows.Forms.Button();
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ButtonPlus = new CustomButton();
            this.Button0 = new CustomButton();
            this.ButtonMinus = new CustomButton();
            this.Button3 = new CustomButton();
            this.Button2 = new CustomButton();
            this.Button1 = new CustomButton();
            this.ButtonMulti = new CustomButton();
            this.Button6 = new CustomButton();
            this.Button5 = new CustomButton();
            this.Button4 = new CustomButton();
            this.ButtonDivide = new CustomButton();
            this.Button9 = new CustomButton();
            this.Button8 = new CustomButton();
            this.Button7 = new CustomButton();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowArea
            // 
            this.ShowArea.BackColor = System.Drawing.Color.Transparent;
            this.ShowArea.Enabled = false;
            this.ShowArea.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowArea.Location = new System.Drawing.Point(-1, -1);
            this.ShowArea.Name = "ShowArea";
            this.ShowArea.Size = new System.Drawing.Size(438, 101);
            this.ShowArea.TabIndex = 0;
            this.ShowArea.TabStop = false;
            this.ShowArea.UseVisualStyleBackColor = false;
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonEnd.Location = new System.Drawing.Point(-1, 366);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(438, 71);
            this.ButtonEnd.TabIndex = 15;
            this.ButtonEnd.TabStop = false;
            this.ButtonEnd.Text = "=";
            this.ButtonEnd.UseVisualStyleBackColor = true;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClear.Location = new System.Drawing.Point(-1, 298);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(113, 71);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "AC";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonPlus.Location = new System.Drawing.Point(324, 298);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(113, 71);
            this.ButtonPlus.TabIndex = 16;
            this.ButtonPlus.TabStop = false;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button0.Location = new System.Drawing.Point(107, 298);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(113, 71);
            this.Button0.TabIndex = 14;
            this.Button0.TabStop = false;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMinus.Location = new System.Drawing.Point(324, 230);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(113, 71);
            this.ButtonMinus.TabIndex = 12;
            this.ButtonMinus.TabStop = false;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMunus_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button3.Location = new System.Drawing.Point(217, 230);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(113, 71);
            this.Button3.TabIndex = 11;
            this.Button3.TabStop = false;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button2.Location = new System.Drawing.Point(107, 230);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(113, 71);
            this.Button2.TabIndex = 10;
            this.Button2.TabStop = false;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button1.Location = new System.Drawing.Point(-1, 230);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(113, 71);
            this.Button1.TabIndex = 9;
            this.Button1.TabStop = false;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonMulti
            // 
            this.ButtonMulti.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMulti.Location = new System.Drawing.Point(324, 163);
            this.ButtonMulti.Name = "ButtonMulti";
            this.ButtonMulti.Size = new System.Drawing.Size(113, 71);
            this.ButtonMulti.TabIndex = 8;
            this.ButtonMulti.TabStop = false;
            this.ButtonMulti.Text = "X";
            this.ButtonMulti.UseVisualStyleBackColor = true;
            this.ButtonMulti.Click += new System.EventHandler(this.ButtonMulti_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button6.Location = new System.Drawing.Point(217, 163);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(113, 71);
            this.Button6.TabIndex = 7;
            this.Button6.TabStop = false;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5.Location = new System.Drawing.Point(107, 163);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(113, 71);
            this.Button5.TabIndex = 6;
            this.Button5.TabStop = false;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button4.Location = new System.Drawing.Point(-1, 163);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(113, 71);
            this.Button4.TabIndex = 5;
            this.Button4.TabStop = false;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonDivide.Location = new System.Drawing.Point(324, 96);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(113, 71);
            this.ButtonDivide.TabIndex = 4;
            this.ButtonDivide.TabStop = false;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDevide_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button9.Location = new System.Drawing.Point(217, 96);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(113, 71);
            this.Button9.TabIndex = 3;
            this.Button9.TabStop = false;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button8.Location = new System.Drawing.Point(107, 96);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(113, 71);
            this.Button8.TabIndex = 2;
            this.Button8.TabStop = false;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button7.Location = new System.Drawing.Point(-1, 96);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(113, 71);
            this.Button7.TabIndex = 1;
            this.Button7.TabStop = false;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonDot.Location = new System.Drawing.Point(217, 298);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(113, 71);
            this.ButtonDot.TabIndex = 18;
            this.ButtonDot.TabStop = false;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(436, 437);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonEnd);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ButtonMulti);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.ShowArea);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowArea;
        private CustomButton Button7;
        private CustomButton Button8;
        private CustomButton Button9;
        private CustomButton ButtonDivide;
        private CustomButton Button4;
        private CustomButton Button5;
        private CustomButton Button6;
        private CustomButton ButtonMulti;
        private CustomButton Button1;
        private CustomButton Button2;
        private CustomButton Button3;
        private CustomButton ButtonMinus;
        private CustomButton Button0;
        private System.Windows.Forms.Button ButtonEnd;
        private CustomButton ButtonPlus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button ButtonDot;
    }
}

