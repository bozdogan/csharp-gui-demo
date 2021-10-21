
namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.num1Bt = new System.Windows.Forms.Button();
            this.num2Bt = new System.Windows.Forms.Button();
            this.num3Bt = new System.Windows.Forms.Button();
            this.num4Bt = new System.Windows.Forms.Button();
            this.num5Bt = new System.Windows.Forms.Button();
            this.num6Bt = new System.Windows.Forms.Button();
            this.num7Bt = new System.Windows.Forms.Button();
            this.num8Bt = new System.Windows.Forms.Button();
            this.num9Bt = new System.Windows.Forms.Button();
            this.num0Bt = new System.Windows.Forms.Button();
            this.decimalBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.divideBt = new System.Windows.Forms.Button();
            this.subtractBt = new System.Windows.Forms.Button();
            this.equalsBt = new System.Windows.Forms.Button();
            this.panelTx = new System.Windows.Forms.TextBox();
            this.multiplyBt = new System.Windows.Forms.Button();
            this.statusLb = new System.Windows.Forms.Label();
            this.clearBt = new System.Windows.Forms.Button();
            this.debugStringLb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // num1Bt
            // 
            this.num1Bt.Location = new System.Drawing.Point(22, 249);
            this.num1Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num1Bt.Name = "num1Bt";
            this.num1Bt.Size = new System.Drawing.Size(77, 43);
            this.num1Bt.TabIndex = 0;
            this.num1Bt.Text = "1";
            this.num1Bt.UseVisualStyleBackColor = true;
            this.num1Bt.Click += new System.EventHandler(this.num1Bt_Click);
            // 
            // num2Bt
            // 
            this.num2Bt.Location = new System.Drawing.Point(108, 249);
            this.num2Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num2Bt.Name = "num2Bt";
            this.num2Bt.Size = new System.Drawing.Size(77, 43);
            this.num2Bt.TabIndex = 1;
            this.num2Bt.Text = "2";
            this.num2Bt.UseVisualStyleBackColor = true;
            this.num2Bt.Click += new System.EventHandler(this.num2Bt_Click);
            // 
            // num3Bt
            // 
            this.num3Bt.Location = new System.Drawing.Point(195, 249);
            this.num3Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num3Bt.Name = "num3Bt";
            this.num3Bt.Size = new System.Drawing.Size(77, 43);
            this.num3Bt.TabIndex = 2;
            this.num3Bt.Text = "3";
            this.num3Bt.UseVisualStyleBackColor = true;
            this.num3Bt.Click += new System.EventHandler(this.num3Bt_Click);
            // 
            // num4Bt
            // 
            this.num4Bt.Location = new System.Drawing.Point(22, 194);
            this.num4Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num4Bt.Name = "num4Bt";
            this.num4Bt.Size = new System.Drawing.Size(77, 43);
            this.num4Bt.TabIndex = 3;
            this.num4Bt.Text = "4";
            this.num4Bt.UseVisualStyleBackColor = true;
            this.num4Bt.Click += new System.EventHandler(this.num4Bt_Click);
            // 
            // num5Bt
            // 
            this.num5Bt.Location = new System.Drawing.Point(108, 194);
            this.num5Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num5Bt.Name = "num5Bt";
            this.num5Bt.Size = new System.Drawing.Size(77, 43);
            this.num5Bt.TabIndex = 4;
            this.num5Bt.Text = "5";
            this.num5Bt.UseVisualStyleBackColor = true;
            this.num5Bt.Click += new System.EventHandler(this.num5Bt_Click);
            // 
            // num6Bt
            // 
            this.num6Bt.Location = new System.Drawing.Point(195, 194);
            this.num6Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num6Bt.Name = "num6Bt";
            this.num6Bt.Size = new System.Drawing.Size(77, 43);
            this.num6Bt.TabIndex = 5;
            this.num6Bt.Text = "6";
            this.num6Bt.UseVisualStyleBackColor = true;
            this.num6Bt.Click += new System.EventHandler(this.num6Bt_Click);
            // 
            // num7Bt
            // 
            this.num7Bt.Location = new System.Drawing.Point(22, 139);
            this.num7Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num7Bt.Name = "num7Bt";
            this.num7Bt.Size = new System.Drawing.Size(77, 43);
            this.num7Bt.TabIndex = 6;
            this.num7Bt.Text = "7";
            this.num7Bt.UseVisualStyleBackColor = true;
            this.num7Bt.Click += new System.EventHandler(this.num7Bt_Click);
            // 
            // num8Bt
            // 
            this.num8Bt.Location = new System.Drawing.Point(108, 139);
            this.num8Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num8Bt.Name = "num8Bt";
            this.num8Bt.Size = new System.Drawing.Size(77, 43);
            this.num8Bt.TabIndex = 7;
            this.num8Bt.Text = "8";
            this.num8Bt.UseVisualStyleBackColor = true;
            this.num8Bt.Click += new System.EventHandler(this.num8Bt_Click);
            // 
            // num9Bt
            // 
            this.num9Bt.Location = new System.Drawing.Point(195, 139);
            this.num9Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num9Bt.Name = "num9Bt";
            this.num9Bt.Size = new System.Drawing.Size(77, 43);
            this.num9Bt.TabIndex = 8;
            this.num9Bt.Text = "9";
            this.num9Bt.UseVisualStyleBackColor = true;
            this.num9Bt.Click += new System.EventHandler(this.num9Bt_Click);
            // 
            // num0Bt
            // 
            this.num0Bt.Location = new System.Drawing.Point(22, 302);
            this.num0Bt.Margin = new System.Windows.Forms.Padding(5);
            this.num0Bt.Name = "num0Bt";
            this.num0Bt.Size = new System.Drawing.Size(164, 43);
            this.num0Bt.TabIndex = 9;
            this.num0Bt.Text = "0";
            this.num0Bt.UseVisualStyleBackColor = true;
            this.num0Bt.Click += new System.EventHandler(this.num0Bt_Click);
            // 
            // decimalBt
            // 
            this.decimalBt.Location = new System.Drawing.Point(195, 302);
            this.decimalBt.Margin = new System.Windows.Forms.Padding(5);
            this.decimalBt.Name = "decimalBt";
            this.decimalBt.Size = new System.Drawing.Size(77, 43);
            this.decimalBt.TabIndex = 10;
            this.decimalBt.Text = ",";
            this.decimalBt.UseVisualStyleBackColor = true;
            this.decimalBt.Click += new System.EventHandler(this.decimalBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(282, 194);
            this.addBt.Margin = new System.Windows.Forms.Padding(5);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(77, 43);
            this.addBt.TabIndex = 14;
            this.addBt.Text = "+";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // divideBt
            // 
            this.divideBt.Location = new System.Drawing.Point(195, 86);
            this.divideBt.Margin = new System.Windows.Forms.Padding(5);
            this.divideBt.Name = "divideBt";
            this.divideBt.Size = new System.Drawing.Size(77, 43);
            this.divideBt.TabIndex = 13;
            this.divideBt.Text = "/";
            this.divideBt.UseVisualStyleBackColor = true;
            this.divideBt.Click += new System.EventHandler(this.divideBt_Click);
            // 
            // subtractBt
            // 
            this.subtractBt.Location = new System.Drawing.Point(282, 139);
            this.subtractBt.Margin = new System.Windows.Forms.Padding(5);
            this.subtractBt.Name = "subtractBt";
            this.subtractBt.Size = new System.Drawing.Size(77, 43);
            this.subtractBt.TabIndex = 11;
            this.subtractBt.Text = "-";
            this.subtractBt.UseVisualStyleBackColor = true;
            this.subtractBt.Click += new System.EventHandler(this.subtractBt_Click);
            // 
            // equalsBt
            // 
            this.equalsBt.Location = new System.Drawing.Point(282, 249);
            this.equalsBt.Margin = new System.Windows.Forms.Padding(5);
            this.equalsBt.Name = "equalsBt";
            this.equalsBt.Size = new System.Drawing.Size(77, 96);
            this.equalsBt.TabIndex = 14;
            this.equalsBt.Text = "=";
            this.equalsBt.UseVisualStyleBackColor = true;
            this.equalsBt.Click += new System.EventHandler(this.equalsBt_Click);
            // 
            // panelTx
            // 
            this.panelTx.BackColor = System.Drawing.SystemColors.Window;
            this.panelTx.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelTx.Location = new System.Drawing.Point(22, 27);
            this.panelTx.Name = "panelTx";
            this.panelTx.ReadOnly = true;
            this.panelTx.Size = new System.Drawing.Size(337, 42);
            this.panelTx.TabIndex = 15;
            this.panelTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.panelTx.TextChanged += new System.EventHandler(this.panelTx_TextChanged);
            // 
            // multiplyBt
            // 
            this.multiplyBt.Location = new System.Drawing.Point(282, 86);
            this.multiplyBt.Margin = new System.Windows.Forms.Padding(5);
            this.multiplyBt.Name = "multiplyBt";
            this.multiplyBt.Size = new System.Drawing.Size(77, 43);
            this.multiplyBt.TabIndex = 13;
            this.multiplyBt.Text = "*";
            this.multiplyBt.UseVisualStyleBackColor = true;
            this.multiplyBt.Click += new System.EventHandler(this.multiplyBt_Click);
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.ForeColor = System.Drawing.Color.Red;
            this.statusLb.Location = new System.Drawing.Point(22, 93);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(77, 28);
            this.statusLb.TabIndex = 16;
            this.statusLb.Text = "ERROR";
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(108, 86);
            this.clearBt.Margin = new System.Windows.Forms.Padding(5);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(77, 43);
            this.clearBt.TabIndex = 7;
            this.clearBt.Text = "C";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // debugStringLb
            // 
            this.debugStringLb.AutoSize = true;
            this.debugStringLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.debugStringLb.Location = new System.Drawing.Point(22, 6);
            this.debugStringLb.Name = "debugStringLb";
            this.debugStringLb.Size = new System.Drawing.Size(86, 15);
            this.debugStringLb.TabIndex = 17;
            this.debugStringLb.Text = "DEBUG STRING";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 370);
            this.Controls.Add(this.debugStringLb);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.panelTx);
            this.Controls.Add(this.equalsBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.multiplyBt);
            this.Controls.Add(this.divideBt);
            this.Controls.Add(this.subtractBt);
            this.Controls.Add(this.decimalBt);
            this.Controls.Add(this.num0Bt);
            this.Controls.Add(this.num9Bt);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.num8Bt);
            this.Controls.Add(this.num7Bt);
            this.Controls.Add(this.num6Bt);
            this.Controls.Add(this.num5Bt);
            this.Controls.Add(this.num4Bt);
            this.Controls.Add(this.num3Bt);
            this.Controls.Add(this.num2Bt);
            this.Controls.Add(this.num1Bt);
            this.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1Bt;
        private System.Windows.Forms.Button num2Bt;
        private System.Windows.Forms.Button num3Bt;
        private System.Windows.Forms.Button num4Bt;
        private System.Windows.Forms.Button num5Bt;
        private System.Windows.Forms.Button num6Bt;
        private System.Windows.Forms.Button num7Bt;
        private System.Windows.Forms.Button num8Bt;
        private System.Windows.Forms.Button num9Bt;
        private System.Windows.Forms.Button num0Bt;
        private System.Windows.Forms.Button decimalBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button divideBt;
        private System.Windows.Forms.Button subtractBt;
        private System.Windows.Forms.Button equalsBt;
        private System.Windows.Forms.TextBox panelTx;
        private System.Windows.Forms.Button multiplyBt;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Label debugStringLb;
        private System.Windows.Forms.Timer timer1;
    }
}

