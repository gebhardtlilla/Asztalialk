namespace _2025_01_31_FormAlapok
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
            this.szam1NUD = new System.Windows.Forms.NumericUpDown();
            this.szam2NUD = new System.Windows.Forms.NumericUpDown();
            this.EredmenyLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // szam1NUD
            // 
            this.szam1NUD.Location = new System.Drawing.Point(197, 68);
            this.szam1NUD.Name = "szam1NUD";
            this.szam1NUD.Size = new System.Drawing.Size(115, 20);
            this.szam1NUD.TabIndex = 0;
            this.szam1NUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // szam2NUD
            // 
            this.szam2NUD.Location = new System.Drawing.Point(402, 68);
            this.szam2NUD.Name = "szam2NUD";
            this.szam2NUD.Size = new System.Drawing.Size(120, 20);
            this.szam2NUD.TabIndex = 1;
            this.szam2NUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // EredmenyLabel
            // 
            this.EredmenyLabel.AutoSize = true;
            this.EredmenyLabel.Location = new System.Drawing.Point(445, 143);
            this.EredmenyLabel.Name = "EredmenyLabel";
            this.EredmenyLabel.Size = new System.Drawing.Size(54, 13);
            this.EredmenyLabel.TabIndex = 3;
            this.EredmenyLabel.Text = "Eredmény";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "maradék",
            "hatvány"});
            this.comboBox1.Location = new System.Drawing.Point(378, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Művelet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EredmenyLabel);
            this.Controls.Add(this.szam2NUD);
            this.Controls.Add(this.szam1NUD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szam1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szam2NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown szam1NUD;
        private System.Windows.Forms.NumericUpDown szam2NUD;
        private System.Windows.Forms.Label EredmenyLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

