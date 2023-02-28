namespace times
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
            if (disposing && (components != null))
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
            this.hk_label = new System.Windows.Forms.Label();
            this.ca_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uk_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tor_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hk_label
            // 
            this.hk_label.AutoSize = true;
            this.hk_label.Enabled = false;
            this.hk_label.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hk_label.Location = new System.Drawing.Point(-2, 18);
            this.hk_label.Name = "hk_label";
            this.hk_label.Size = new System.Drawing.Size(249, 29);
            this.hk_label.TabIndex = 0;
            this.hk_label.Text = "00/00/0000 00:00:00";
            // 
            // ca_label
            // 
            this.ca_label.AutoSize = true;
            this.ca_label.Enabled = false;
            this.ca_label.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ca_label.Location = new System.Drawing.Point(-2, 62);
            this.ca_label.Name = "ca_label";
            this.ca_label.Size = new System.Drawing.Size(249, 29);
            this.ca_label.TabIndex = 1;
            this.ca_label.Text = "00/00/0000 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "香港";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vancouver";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(209, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(18, 10);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 10);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "London";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // uk_label
            // 
            this.uk_label.AutoSize = true;
            this.uk_label.Enabled = false;
            this.uk_label.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uk_label.Location = new System.Drawing.Point(-3, 154);
            this.uk_label.Name = "uk_label";
            this.uk_label.Size = new System.Drawing.Size(249, 29);
            this.uk_label.TabIndex = 6;
            this.uk_label.Text = "00/00/0000 00:00:00";
            this.uk_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-1, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vancouver";
            // 
            // tor_label
            // 
            this.tor_label.AutoSize = true;
            this.tor_label.Enabled = false;
            this.tor_label.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tor_label.Location = new System.Drawing.Point(-2, 106);
            this.tor_label.Name = "tor_label";
            this.tor_label.Size = new System.Drawing.Size(249, 29);
            this.tor_label.TabIndex = 8;
            this.tor_label.Text = "00/00/0000 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tor_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uk_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ca_label);
            this.Controls.Add(this.hk_label);
            this.Name = "Form1";
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hk_label;
        private Label ca_label;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button btn_close;
        private Button button1;
        private Label label3;
        private Label uk_label;
        private Label label4;
        private Label tor_label;
    }
}