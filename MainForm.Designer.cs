namespace test
{
    partial class MainForm
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
            this.label_Vysledek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Delka = new System.Windows.Forms.TextBox();
            this.generuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Vysledek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_Delka);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry hesla";
            // 
            // label_Vysledek
            // 
            this.label_Vysledek.AutoSize = true;
            this.label_Vysledek.Location = new System.Drawing.Point(6, 50);
            this.label_Vysledek.Name = "label_Vysledek";
            this.label_Vysledek.Size = new System.Drawing.Size(97, 13);
            this.label_Vysledek.TabIndex = 7;
            this.label_Vysledek.Text = "Generované heslo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Počet znaků";
            // 
            // text_Delka
            // 
            this.text_Delka.Location = new System.Drawing.Point(79, 19);
            this.text_Delka.MaxLength = 2;
            this.text_Delka.Name = "text_Delka";
            this.text_Delka.Size = new System.Drawing.Size(37, 20);
            this.text_Delka.TabIndex = 4;
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(129, 83);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(75, 23);
            this.generuj.TabIndex = 7;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 111);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generátor hesel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Vysledek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Delka;
        private System.Windows.Forms.Button generuj;

    }
}

