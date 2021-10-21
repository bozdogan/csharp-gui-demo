
namespace CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputTx = new System.Windows.Forms.TextBox();
            this.convertBt = new System.Windows.Forms.Button();
            this.resultTx = new System.Windows.Forms.TextBox();
            this.infoLb = new System.Windows.Forms.Label();
            this.currencyInfoLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currency1SymLb = new System.Windows.Forms.Label();
            this.currency2SymLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTx
            // 
            this.inputTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTx.Location = new System.Drawing.Point(69, 111);
            this.inputTx.Margin = new System.Windows.Forms.Padding(4);
            this.inputTx.Name = "inputTx";
            this.inputTx.Size = new System.Drawing.Size(175, 29);
            this.inputTx.TabIndex = 0;
            this.inputTx.TextChanged += new System.EventHandler(this.inputTx_TextChanged);
            this.inputTx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTx_KeyDown);
            this.inputTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTx_KeyPress);
            // 
            // convertBt
            // 
            this.convertBt.Location = new System.Drawing.Point(94, 148);
            this.convertBt.Margin = new System.Windows.Forms.Padding(4);
            this.convertBt.Name = "convertBt";
            this.convertBt.Size = new System.Drawing.Size(120, 30);
            this.convertBt.TabIndex = 1;
            this.convertBt.TabStop = false;
            this.convertBt.Text = "Convert";
            this.convertBt.UseVisualStyleBackColor = true;
            this.convertBt.Click += new System.EventHandler(this.convertBt_Click);
            // 
            // resultTx
            // 
            this.resultTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTx.Location = new System.Drawing.Point(69, 191);
            this.resultTx.Margin = new System.Windows.Forms.Padding(4);
            this.resultTx.Name = "resultTx";
            this.resultTx.ReadOnly = true;
            this.resultTx.Size = new System.Drawing.Size(175, 29);
            this.resultTx.TabIndex = 2;
            this.resultTx.TabStop = false;
            this.resultTx.TextChanged += new System.EventHandler(this.resultTx_TextChanged);
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLb.ForeColor = System.Drawing.Color.DarkBlue;
            this.infoLb.Location = new System.Drawing.Point(13, 238);
            this.infoLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(414, 312);
            this.infoLb.TabIndex = 3;
            this.infoLb.Text = resources.GetString("infoLb.Text");
            this.infoLb.Click += new System.EventHandler(this.infoLb_Click);
            // 
            // currencyInfoLb
            // 
            this.currencyInfoLb.AutoSize = true;
            this.currencyInfoLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currencyInfoLb.ForeColor = System.Drawing.Color.Crimson;
            this.currencyInfoLb.Location = new System.Drawing.Point(306, 131);
            this.currencyInfoLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyInfoLb.Name = "currencyInfoLb";
            this.currencyInfoLb.Size = new System.Drawing.Size(97, 63);
            this.currencyInfoLb.TabIndex = 4;
            this.currencyInfoLb.Text = "US Dollars\r\nto\r\nTurkish Lira";
            this.currencyInfoLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currencyInfoLb.Click += new System.EventHandler(this.currencyInfoLb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keyboard Only Currency Converter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // currency1SymLb
            // 
            this.currency1SymLb.AutoSize = true;
            this.currency1SymLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currency1SymLb.Location = new System.Drawing.Point(251, 114);
            this.currency1SymLb.Name = "currency1SymLb";
            this.currency1SymLb.Size = new System.Drawing.Size(19, 21);
            this.currency1SymLb.TabIndex = 6;
            this.currency1SymLb.Text = "₺";
            this.currency1SymLb.Click += new System.EventHandler(this.currency1SymLb_Click);
            // 
            // currency2SymLb
            // 
            this.currency2SymLb.AutoSize = true;
            this.currency2SymLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currency2SymLb.Location = new System.Drawing.Point(251, 194);
            this.currency2SymLb.Name = "currency2SymLb";
            this.currency2SymLb.Size = new System.Drawing.Size(19, 21);
            this.currency2SymLb.TabIndex = 7;
            this.currency2SymLb.Text = "$";
            this.currency2SymLb.Click += new System.EventHandler(this.currency2SymLb_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convertBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 581);
            this.Controls.Add(this.currency2SymLb);
            this.Controls.Add(this.currency1SymLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currencyInfoLb);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.resultTx);
            this.Controls.Add(this.convertBt);
            this.Controls.Add(this.inputTx);
            this.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTx;
        private System.Windows.Forms.Button convertBt;
        private System.Windows.Forms.TextBox resultTx;
        private System.Windows.Forms.Label infoLb;
        private System.Windows.Forms.Label currencyInfoLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currency1SymLb;
        private System.Windows.Forms.Label currency2SymLb;
    }
}

