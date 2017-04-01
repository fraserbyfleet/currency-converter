namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.amount = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.CURRENCYFROM = new System.Windows.Forms.TextBox();
            this.DISPLAYCONVERSION = new System.Windows.Forms.TextBox();
            this.TO = new System.Windows.Forms.Label();
            this.CONVERT = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.USERINPUT = new System.Windows.Forms.MaskedTextBox();
            this.cbCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurrencyTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(155, 326);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(60, 13);
            this.amount.TabIndex = 7;
            this.amount.Text = "amount ($):";
            this.amount.Click += new System.EventHandler(this.amount_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(173, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(207, 13);
            this.title.TabIndex = 8;
            this.title.Text = "CURRECY CONVERSION CALCULATOR";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(155, 358);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(30, 13);
            this.from.TabIndex = 9;
            this.from.Text = "from:";
            // 
            // CURRENCYFROM
            // 
            this.CURRENCYFROM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CURRENCYFROM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CURRENCYFROM.Location = new System.Drawing.Point(216, 358);
            this.CURRENCYFROM.Name = "CURRENCYFROM";
            this.CURRENCYFROM.Size = new System.Drawing.Size(100, 13);
            this.CURRENCYFROM.TabIndex = 10;
            this.CURRENCYFROM.TextChanged += new System.EventHandler(this.CURRENCYFROM_TextChanged);
            // 
            // DISPLAYCONVERSION
            // 
            this.DISPLAYCONVERSION.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DISPLAYCONVERSION.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DISPLAYCONVERSION.Location = new System.Drawing.Point(216, 386);
            this.DISPLAYCONVERSION.Name = "DISPLAYCONVERSION";
            this.DISPLAYCONVERSION.ReadOnly = true;
            this.DISPLAYCONVERSION.Size = new System.Drawing.Size(100, 13);
            this.DISPLAYCONVERSION.TabIndex = 11;
            this.DISPLAYCONVERSION.TextChanged += new System.EventHandler(this.DISPLAYCONVERSION_TextChanged);
            // 
            // TO
            // 
            this.TO.AutoSize = true;
            this.TO.Location = new System.Drawing.Point(155, 386);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(19, 13);
            this.TO.TabIndex = 12;
            this.TO.Text = "to:";
            // 
            // CONVERT
            // 
            this.CONVERT.Location = new System.Drawing.Point(216, 419);
            this.CONVERT.Name = "CONVERT";
            this.CONVERT.Size = new System.Drawing.Size(100, 23);
            this.CONVERT.TabIndex = 4;
            this.CONVERT.Text = "CONVERT";
            this.CONVERT.UseVisualStyleBackColor = true;
            this.CONVERT.Click += new System.EventHandler(this.CONVERT_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(216, 448);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(100, 23);
            this.RESET.TabIndex = 5;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // USERINPUT
            // 
            this.USERINPUT.BeepOnError = true;
            this.USERINPUT.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.USERINPUT.Location = new System.Drawing.Point(216, 326);
            this.USERINPUT.Name = "USERINPUT";
            this.USERINPUT.Size = new System.Drawing.Size(100, 20);
            this.USERINPUT.TabIndex = 3;
            this.USERINPUT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.USERINPUT_MaskInputRejected);
            // 
            // cbCurrencyFrom
            // 
            this.cbCurrencyFrom.FormattingEnabled = true;
            this.cbCurrencyFrom.Items.AddRange(new object[] {
            "NZD",
            "AUD",
            "CAD",
            "EUR",
            "GBP",
            "USD"});
            this.cbCurrencyFrom.Location = new System.Drawing.Point(103, 129);
            this.cbCurrencyFrom.Name = "cbCurrencyFrom";
            this.cbCurrencyFrom.Size = new System.Drawing.Size(121, 21);
            this.cbCurrencyFrom.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "From Currency";
            // 
            // cbCurrencyTo
            // 
            this.cbCurrencyTo.FormattingEnabled = true;
            this.cbCurrencyTo.Items.AddRange(new object[] {
            "NZD",
            "AUD",
            "CAD",
            "EUR",
            "GBP",
            "USD"});
            this.cbCurrencyTo.Location = new System.Drawing.Point(275, 129);
            this.cbCurrencyTo.Name = "cbCurrencyTo";
            this.cbCurrencyTo.Size = new System.Drawing.Size(121, 21);
            this.cbCurrencyTo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "To Currency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCurrencyTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurrencyFrom);
            this.Controls.Add(this.USERINPUT);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.CONVERT);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.DISPLAYCONVERSION);
            this.Controls.Add(this.CURRENCYFROM);
            this.Controls.Add(this.from);
            this.Controls.Add(this.title);
            this.Controls.Add(this.amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox CURRENCYFROM;
        private System.Windows.Forms.TextBox DISPLAYCONVERSION;
        private System.Windows.Forms.Label TO;
        private System.Windows.Forms.Button CONVERT;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.MaskedTextBox USERINPUT;
        private System.Windows.Forms.ComboBox cbCurrencyFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurrencyTo;
        private System.Windows.Forms.Label label2;
    }
}

