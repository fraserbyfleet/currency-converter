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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USD1 = new System.Windows.Forms.RadioButton();
            this.CAD1 = new System.Windows.Forms.RadioButton();
            this.AUD1 = new System.Windows.Forms.RadioButton();
            this.GBP1 = new System.Windows.Forms.RadioButton();
            this.EUR1 = new System.Windows.Forms.RadioButton();
            this.NZD1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.USD2 = new System.Windows.Forms.RadioButton();
            this.CAD2 = new System.Windows.Forms.RadioButton();
            this.AUD2 = new System.Windows.Forms.RadioButton();
            this.GBP2 = new System.Windows.Forms.RadioButton();
            this.EUR2 = new System.Windows.Forms.RadioButton();
            this.NZD2 = new System.Windows.Forms.RadioButton();
            this.amount = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.CURRENCYFROM = new System.Windows.Forms.TextBox();
            this.DISPLAYCONVERSION = new System.Windows.Forms.TextBox();
            this.TO = new System.Windows.Forms.Label();
            this.CONVERT = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.USERINPUT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.USD1);
            this.groupBox1.Controls.Add(this.CAD1);
            this.groupBox1.Controls.Add(this.AUD1);
            this.groupBox1.Controls.Add(this.GBP1);
            this.groupBox1.Controls.Add(this.EUR1);
            this.groupBox1.Controls.Add(this.NZD1);
            this.groupBox1.Location = new System.Drawing.Point(97, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONVERT FROM:";
            // 
            // USD1
            // 
            this.USD1.AutoSize = true;
            this.USD1.Location = new System.Drawing.Point(57, 62);
            this.USD1.Name = "USD1";
            this.USD1.Size = new System.Drawing.Size(48, 17);
            this.USD1.TabIndex = 5;
            this.USD1.TabStop = true;
            this.USD1.Text = "USD";
            this.USD1.UseVisualStyleBackColor = true;
            this.USD1.CheckedChanged += new System.EventHandler(this.USD1_CheckedChanged);
            // 
            // CAD1
            // 
            this.CAD1.AutoSize = true;
            this.CAD1.Location = new System.Drawing.Point(57, 39);
            this.CAD1.Name = "CAD1";
            this.CAD1.Size = new System.Drawing.Size(47, 17);
            this.CAD1.TabIndex = 4;
            this.CAD1.TabStop = true;
            this.CAD1.Text = "CAD";
            this.CAD1.UseVisualStyleBackColor = true;
            this.CAD1.CheckedChanged += new System.EventHandler(this.CAD1_CheckedChanged);
            // 
            // AUD1
            // 
            this.AUD1.AutoSize = true;
            this.AUD1.Location = new System.Drawing.Point(57, 16);
            this.AUD1.Name = "AUD1";
            this.AUD1.Size = new System.Drawing.Size(48, 17);
            this.AUD1.TabIndex = 3;
            this.AUD1.TabStop = true;
            this.AUD1.Text = "AUD";
            this.AUD1.UseVisualStyleBackColor = true;
            this.AUD1.CheckedChanged += new System.EventHandler(this.AUD1_CheckedChanged);
            // 
            // GBP1
            // 
            this.GBP1.AutoSize = true;
            this.GBP1.Location = new System.Drawing.Point(3, 62);
            this.GBP1.Name = "GBP1";
            this.GBP1.Size = new System.Drawing.Size(47, 17);
            this.GBP1.TabIndex = 2;
            this.GBP1.TabStop = true;
            this.GBP1.Text = "GBP";
            this.GBP1.UseVisualStyleBackColor = true;
            this.GBP1.CheckedChanged += new System.EventHandler(this.GBP1_CheckedChanged);
            // 
            // EUR1
            // 
            this.EUR1.AutoSize = true;
            this.EUR1.Location = new System.Drawing.Point(3, 39);
            this.EUR1.Name = "EUR1";
            this.EUR1.Size = new System.Drawing.Size(48, 17);
            this.EUR1.TabIndex = 1;
            this.EUR1.TabStop = true;
            this.EUR1.Text = "EUR";
            this.EUR1.UseVisualStyleBackColor = true;
            this.EUR1.CheckedChanged += new System.EventHandler(this.EUR1_CheckedChanged);
            // 
            // NZD1
            // 
            this.NZD1.AutoSize = true;
            this.NZD1.Location = new System.Drawing.Point(3, 16);
            this.NZD1.Name = "NZD1";
            this.NZD1.Size = new System.Drawing.Size(48, 17);
            this.NZD1.TabIndex = 0;
            this.NZD1.TabStop = true;
            this.NZD1.Text = "NZD";
            this.NZD1.UseVisualStyleBackColor = true;
            this.NZD1.CheckedChanged += new System.EventHandler(this.NZD1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.USD2);
            this.groupBox2.Controls.Add(this.CAD2);
            this.groupBox2.Controls.Add(this.AUD2);
            this.groupBox2.Controls.Add(this.GBP2);
            this.groupBox2.Controls.Add(this.EUR2);
            this.groupBox2.Controls.Add(this.NZD2);
            this.groupBox2.Location = new System.Drawing.Point(330, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONVERT TO:";
            // 
            // USD2
            // 
            this.USD2.AutoSize = true;
            this.USD2.Location = new System.Drawing.Point(55, 62);
            this.USD2.Name = "USD2";
            this.USD2.Size = new System.Drawing.Size(48, 17);
            this.USD2.TabIndex = 6;
            this.USD2.TabStop = true;
            this.USD2.Text = "USD";
            this.USD2.UseVisualStyleBackColor = true;
            this.USD2.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // CAD2
            // 
            this.CAD2.AutoSize = true;
            this.CAD2.Location = new System.Drawing.Point(56, 39);
            this.CAD2.Name = "CAD2";
            this.CAD2.Size = new System.Drawing.Size(47, 17);
            this.CAD2.TabIndex = 6;
            this.CAD2.TabStop = true;
            this.CAD2.Text = "CAD";
            this.CAD2.UseVisualStyleBackColor = true;
            this.CAD2.CheckedChanged += new System.EventHandler(this.CAD2_CheckedChanged);
            // 
            // AUD2
            // 
            this.AUD2.AutoSize = true;
            this.AUD2.Location = new System.Drawing.Point(56, 19);
            this.AUD2.Name = "AUD2";
            this.AUD2.Size = new System.Drawing.Size(48, 17);
            this.AUD2.TabIndex = 6;
            this.AUD2.TabStop = true;
            this.AUD2.Text = "AUD";
            this.AUD2.UseVisualStyleBackColor = true;
            this.AUD2.CheckedChanged += new System.EventHandler(this.AUD2_CheckedChanged);
            // 
            // GBP2
            // 
            this.GBP2.AutoSize = true;
            this.GBP2.Location = new System.Drawing.Point(2, 62);
            this.GBP2.Name = "GBP2";
            this.GBP2.Size = new System.Drawing.Size(47, 17);
            this.GBP2.TabIndex = 6;
            this.GBP2.TabStop = true;
            this.GBP2.Text = "GBP";
            this.GBP2.UseVisualStyleBackColor = true;
            this.GBP2.CheckedChanged += new System.EventHandler(this.GBP2_CheckedChanged);
            // 
            // EUR2
            // 
            this.EUR2.AutoSize = true;
            this.EUR2.Location = new System.Drawing.Point(2, 39);
            this.EUR2.Name = "EUR2";
            this.EUR2.Size = new System.Drawing.Size(48, 17);
            this.EUR2.TabIndex = 6;
            this.EUR2.TabStop = true;
            this.EUR2.Text = "EUR";
            this.EUR2.UseVisualStyleBackColor = true;
            this.EUR2.CheckedChanged += new System.EventHandler(this.EUR2_CheckedChanged);
            // 
            // NZD2
            // 
            this.NZD2.AutoSize = true;
            this.NZD2.Location = new System.Drawing.Point(2, 19);
            this.NZD2.Name = "NZD2";
            this.NZD2.Size = new System.Drawing.Size(48, 17);
            this.NZD2.TabIndex = 6;
            this.NZD2.TabStop = true;
            this.NZD2.Text = "NZD";
            this.NZD2.UseVisualStyleBackColor = true;
            this.NZD2.CheckedChanged += new System.EventHandler(this.NZD2_CheckedChanged);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(155, 326);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(45, 13);
            this.amount.TabIndex = 7;
            this.amount.Text = "amount:";
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
            this.CONVERT.TabIndex = 6;
            this.CONVERT.Text = "CONVERT";
            this.CONVERT.UseVisualStyleBackColor = true;
            this.CONVERT.Click += new System.EventHandler(this.CONVERT_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(216, 448);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(100, 23);
            this.RESET.TabIndex = 13;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // USERINPUT
            // 
            this.USERINPUT.BeepOnError = true;
            this.USERINPUT.Location = new System.Drawing.Point(216, 326);
            this.USERINPUT.Mask = "$999999999.00";
            this.USERINPUT.Name = "USERINPUT";
            this.USERINPUT.Size = new System.Drawing.Size(100, 20);
            this.USERINPUT.TabIndex = 15;
            this.USERINPUT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.USERINPUT_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 591);
            this.Controls.Add(this.USERINPUT);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.CONVERT);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.DISPLAYCONVERSION);
            this.Controls.Add(this.CURRENCYFROM);
            this.Controls.Add(this.from);
            this.Controls.Add(this.title);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox CURRENCYFROM;
        private System.Windows.Forms.TextBox DISPLAYCONVERSION;
        private System.Windows.Forms.Label TO;
        private System.Windows.Forms.Button CONVERT;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.MaskedTextBox USERINPUT;
        private System.Windows.Forms.RadioButton USD1;
        private System.Windows.Forms.RadioButton CAD1;
        private System.Windows.Forms.RadioButton AUD1;
        private System.Windows.Forms.RadioButton GBP1;
        private System.Windows.Forms.RadioButton EUR1;
        private System.Windows.Forms.RadioButton NZD1;
        private System.Windows.Forms.RadioButton USD2;
        private System.Windows.Forms.RadioButton CAD2;
        private System.Windows.Forms.RadioButton AUD2;
        private System.Windows.Forms.RadioButton GBP2;
        private System.Windows.Forms.RadioButton EUR2;
        private System.Windows.Forms.RadioButton NZD2;
    }
}

