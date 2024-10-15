namespace Kalkulator_walutowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_wprowadz_kwote_do_przealutowania = new System.Windows.Forms.TextBox();
            this.listDostepneWaluty = new System.Windows.Forms.ListBox();
            this.labelPrzewalutowano = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(83, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj w kalkulatorze walut!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(85, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obecny kurs walut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "1 EUR = 4,31 PLN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(86, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "1 GBP = 5,12 PLN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(86, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "1 CHF = 4,57 PLN";
            // 
            // textBox1_wprowadz_kwote_do_przealutowania
            // 
            this.textBox1_wprowadz_kwote_do_przealutowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1_wprowadz_kwote_do_przealutowania.Location = new System.Drawing.Point(92, 396);
            this.textBox1_wprowadz_kwote_do_przealutowania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_wprowadz_kwote_do_przealutowania.Name = "textBox1_wprowadz_kwote_do_przealutowania";
            this.textBox1_wprowadz_kwote_do_przealutowania.Size = new System.Drawing.Size(341, 39);
            this.textBox1_wprowadz_kwote_do_przealutowania.TabIndex = 5;
            this.textBox1_wprowadz_kwote_do_przealutowania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_wprowadz_kwote_do_przealutowania_KeyPress);
            // 
            // listDostepneWaluty
            // 
            this.listDostepneWaluty.FormattingEnabled = true;
            this.listDostepneWaluty.ItemHeight = 20;
            this.listDostepneWaluty.Items.AddRange(new object[] {
            "EUR",
            "GBP",
            "CHF"});
            this.listDostepneWaluty.Location = new System.Drawing.Point(453, 444);
            this.listDostepneWaluty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDostepneWaluty.Name = "listDostepneWaluty";
            this.listDostepneWaluty.Size = new System.Drawing.Size(109, 64);
            this.listDostepneWaluty.TabIndex = 8;
            this.listDostepneWaluty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listDostepneWaluty_KeyPress);
            // 
            // labelPrzewalutowano
            // 
            this.labelPrzewalutowano.AutoSize = true;
            this.labelPrzewalutowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrzewalutowano.Location = new System.Drawing.Point(470, 402);
            this.labelPrzewalutowano.Name = "labelPrzewalutowano";
            this.labelPrzewalutowano.Size = new System.Drawing.Size(0, 32);
            this.labelPrzewalutowano.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Przewalutuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(105, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wprowadź kwotę w PLN do przewalutowania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrzewalutowano);
            this.Controls.Add(this.listDostepneWaluty);
            this.Controls.Add(this.textBox1_wprowadz_kwote_do_przealutowania);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kalkulator walutowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_wprowadz_kwote_do_przealutowania;
        private System.Windows.Forms.ListBox listDostepneWaluty;
        private System.Windows.Forms.Label labelPrzewalutowano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

