namespace WindowsFormsAppMasGyumolcs
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
            this.listBoxGyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBoxKivalasztottGyumolcs = new System.Windows.Forms.GroupBox();
            this.labelAzonosito = new System.Windows.Forms.Label();
            this.labelGyumolcsnev = new System.Windows.Forms.Label();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.labelEgysegar = new System.Windows.Forms.Label();
            this.textBoxAzonosito = new System.Windows.Forms.TextBox();
            this.textBoxGyumolcsnev = new System.Windows.Forms.TextBox();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEgysegar = new System.Windows.Forms.NumericUpDown();
            this.groupBoxKivalasztottGyumolcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGyumolcsok
            // 
            this.listBoxGyumolcsok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxGyumolcsok.FormattingEnabled = true;
            this.listBoxGyumolcsok.Location = new System.Drawing.Point(585, 0);
            this.listBoxGyumolcsok.Name = "listBoxGyumolcsok";
            this.listBoxGyumolcsok.Size = new System.Drawing.Size(215, 450);
            this.listBoxGyumolcsok.TabIndex = 0;
            // 
            // groupBoxKivalasztottGyumolcs
            // 
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.numericUpDownEgysegar);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.numericUpDownMennyiseg);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.textBoxGyumolcsnev);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.textBoxAzonosito);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelEgysegar);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelMennyiseg);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelGyumolcsnev);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelAzonosito);
            this.groupBoxKivalasztottGyumolcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKivalasztottGyumolcs.Location = new System.Drawing.Point(1, 0);
            this.groupBoxKivalasztottGyumolcs.Name = "groupBoxKivalasztottGyumolcs";
            this.groupBoxKivalasztottGyumolcs.Size = new System.Drawing.Size(578, 450);
            this.groupBoxKivalasztottGyumolcs.TabIndex = 1;
            this.groupBoxKivalasztottGyumolcs.TabStop = false;
            this.groupBoxKivalasztottGyumolcs.Text = "Kiválasztott gyümölcs";
            // 
            // labelAzonosito
            // 
            this.labelAzonosito.AutoSize = true;
            this.labelAzonosito.Location = new System.Drawing.Point(35, 25);
            this.labelAzonosito.Name = "labelAzonosito";
            this.labelAzonosito.Size = new System.Drawing.Size(84, 20);
            this.labelAzonosito.TabIndex = 0;
            this.labelAzonosito.Text = "Azonosító:";
            // 
            // labelGyumolcsnev
            // 
            this.labelGyumolcsnev.AutoSize = true;
            this.labelGyumolcsnev.Location = new System.Drawing.Point(11, 66);
            this.labelGyumolcsnev.Name = "labelGyumolcsnev";
            this.labelGyumolcsnev.Size = new System.Drawing.Size(108, 20);
            this.labelGyumolcsnev.TabIndex = 1;
            this.labelGyumolcsnev.Text = "Gyümölcsnév:";
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(30, 118);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(89, 20);
            this.labelMennyiseg.TabIndex = 2;
            this.labelMennyiseg.Text = "Mennyiség:";
            // 
            // labelEgysegar
            // 
            this.labelEgysegar.AutoSize = true;
            this.labelEgysegar.Location = new System.Drawing.Point(39, 158);
            this.labelEgysegar.Name = "labelEgysegar";
            this.labelEgysegar.Size = new System.Drawing.Size(80, 20);
            this.labelEgysegar.TabIndex = 3;
            this.labelEgysegar.Text = "Egységár:";
            // 
            // textBoxAzonosito
            // 
            this.textBoxAzonosito.Location = new System.Drawing.Point(125, 25);
            this.textBoxAzonosito.Name = "textBoxAzonosito";
            this.textBoxAzonosito.ReadOnly = true;
            this.textBoxAzonosito.Size = new System.Drawing.Size(120, 26);
            this.textBoxAzonosito.TabIndex = 4;
            // 
            // textBoxGyumolcsnev
            // 
            this.textBoxGyumolcsnev.Location = new System.Drawing.Point(125, 66);
            this.textBoxGyumolcsnev.Name = "textBoxGyumolcsnev";
            this.textBoxGyumolcsnev.Size = new System.Drawing.Size(120, 26);
            this.textBoxGyumolcsnev.TabIndex = 5;
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.DecimalPlaces = 2;
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(125, 116);
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMennyiseg.TabIndex = 8;
            this.numericUpDownMennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownEgysegar
            // 
            this.numericUpDownEgysegar.DecimalPlaces = 2;
            this.numericUpDownEgysegar.Location = new System.Drawing.Point(125, 156);
            this.numericUpDownEgysegar.Name = "numericUpDownEgysegar";
            this.numericUpDownEgysegar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEgysegar.TabIndex = 9;
            this.numericUpDownEgysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKivalasztottGyumolcs);
            this.Controls.Add(this.listBoxGyumolcsok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKivalasztottGyumolcs.ResumeLayout(false);
            this.groupBoxKivalasztottGyumolcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGyumolcsok;
        private System.Windows.Forms.GroupBox groupBoxKivalasztottGyumolcs;
        private System.Windows.Forms.NumericUpDown numericUpDownEgysegar;
        private System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        private System.Windows.Forms.TextBox textBoxGyumolcsnev;
        private System.Windows.Forms.TextBox textBoxAzonosito;
        private System.Windows.Forms.Label labelEgysegar;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.Label labelGyumolcsnev;
        private System.Windows.Forms.Label labelAzonosito;
    }
}

