namespace XO_By_Ahmed_Mohsen_and_Sherif_Asharf
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(105, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Wins";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(319, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU Wins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn1.Location = new System.Drawing.Point(108, 75);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 73);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn2.Location = new System.Drawing.Point(199, 75);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 73);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn3.Location = new System.Drawing.Point(290, 75);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 73);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn4.Location = new System.Drawing.Point(108, 154);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 73);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn5.Location = new System.Drawing.Point(199, 154);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 73);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn6.Location = new System.Drawing.Point(290, 154);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 73);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn7.Location = new System.Drawing.Point(108, 233);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 67);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn8.Location = new System.Drawing.Point(199, 233);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 67);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn9.Location = new System.Drawing.Point(290, 233);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 67);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(108, 323);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(85, 23);
            this.btnclr.TabIndex = 12;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(290, 323);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(85, 23);
            this.btnres.TabIndex = 13;
            this.btnres.Text = "Restart Game";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(205, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Turn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TIC TAC TOE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Timer CPUTimer;
        private System.Windows.Forms.Label label3;
    }
}

