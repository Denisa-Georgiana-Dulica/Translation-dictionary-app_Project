namespace Proiect_PAW_Dictionar_Traduceri
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
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnInsereaza = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.DGVcuvinte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLitere = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbAlfabetic = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdjective = new System.Windows.Forms.Button();
            this.btnVerbe = new System.Windows.Forms.Button();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imprimareDictionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcuvinte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.Color.LightGray;
            this.btnAfiseaza.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAfiseaza.Location = new System.Drawing.Point(90, 183);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(187, 34);
            this.btnAfiseaza.TabIndex = 0;
            this.btnAfiseaza.Text = "Cautare ";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnInsereaza
            // 
            this.btnInsereaza.BackColor = System.Drawing.Color.LightGray;
            this.btnInsereaza.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsereaza.Location = new System.Drawing.Point(90, 223);
            this.btnInsereaza.Name = "btnInsereaza";
            this.btnInsereaza.Size = new System.Drawing.Size(187, 34);
            this.btnInsereaza.TabIndex = 1;
            this.btnInsereaza.Text = "Insereaza cuvant nou";
            this.btnInsereaza.UseVisualStyleBackColor = false;
            this.btnInsereaza.Click += new System.EventHandler(this.btnInsereaza_Click);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.BackColor = System.Drawing.Color.LightGray;
            this.btnActualizeaza.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizeaza.Location = new System.Drawing.Point(90, 263);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(187, 34);
            this.btnActualizeaza.TabIndex = 2;
            this.btnActualizeaza.Text = "Actualizeaza cuvant";
            this.btnActualizeaza.UseVisualStyleBackColor = false;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // DGVcuvinte
            // 
            this.DGVcuvinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcuvinte.Location = new System.Drawing.Point(383, 124);
            this.DGVcuvinte.Name = "DGVcuvinte";
            this.DGVcuvinte.ReadOnly = true;
            this.DGVcuvinte.RowHeadersWidth = 51;
            this.DGVcuvinte.RowTemplate.Height = 24;
            this.DGVcuvinte.Size = new System.Drawing.Size(216, 253);
            this.DGVcuvinte.TabIndex = 4;
            this.DGVcuvinte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcuvinte_CellContentClick);
            this.DGVcuvinte.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVcuvinte_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(343, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "DICTIONAR ROMAN - ENGLEZ";
            // 
            // cbLitere
            // 
            this.cbLitere.FormattingEnabled = true;
            this.cbLitere.Location = new System.Drawing.Point(101, 146);
            this.cbLitere.Name = "cbLitere";
            this.cbLitere.Size = new System.Drawing.Size(121, 24);
            this.cbLitere.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(98, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecteaza litera pentru cautare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(675, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dictionare disponibile in magazine";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(720, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vezi sugestii";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbAlfabetic
            // 
            this.rbAlfabetic.AutoSize = true;
            this.rbAlfabetic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAlfabetic.Location = new System.Drawing.Point(383, 88);
            this.rbAlfabetic.Name = "rbAlfabetic";
            this.rbAlfabetic.Size = new System.Drawing.Size(73, 21);
            this.rbAlfabetic.TabIndex = 10;
            this.rbAlfabetic.TabStop = true;
            this.rbAlfabetic.Text = "Afisare";
            this.rbAlfabetic.UseVisualStyleBackColor = true;
            this.rbAlfabetic.CheckedChanged += new System.EventHandler(this.rbAlfabetic_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(720, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Iesire din aplicatie";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdjective
            // 
            this.btnAdjective.BackColor = System.Drawing.Color.LightGray;
            this.btnAdjective.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdjective.Location = new System.Drawing.Point(199, 343);
            this.btnAdjective.Name = "btnAdjective";
            this.btnAdjective.Size = new System.Drawing.Size(158, 34);
            this.btnAdjective.TabIndex = 12;
            this.btnAdjective.Text = "Afiseaza adjective";
            this.btnAdjective.UseVisualStyleBackColor = false;
            this.btnAdjective.Click += new System.EventHandler(this.btnAdjective_Click);
            // 
            // btnVerbe
            // 
            this.btnVerbe.BackColor = System.Drawing.Color.LightGray;
            this.btnVerbe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVerbe.Location = new System.Drawing.Point(12, 343);
            this.btnVerbe.Name = "btnVerbe";
            this.btnVerbe.Size = new System.Drawing.Size(158, 34);
            this.btnVerbe.TabIndex = 13;
            this.btnVerbe.Text = "Afiseaza verbe";
            this.btnVerbe.UseVisualStyleBackColor = false;
            this.btnVerbe.Click += new System.EventHandler(this.btnVerbe_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.BackColor = System.Drawing.Color.LightGray;
            this.btnGrafic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrafic.Location = new System.Drawing.Point(720, 344);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(150, 33);
            this.btnGrafic.TabIndex = 17;
            this.btnGrafic.Text = "Grafic";
            this.btnGrafic.UseVisualStyleBackColor = false;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimareDictionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 30);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imprimareDictionarToolStripMenuItem
            // 
            this.imprimareDictionarToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.imprimareDictionarToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imprimareDictionarToolStripMenuItem.Name = "imprimareDictionarToolStripMenuItem";
            this.imprimareDictionarToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.imprimareDictionarToolStripMenuItem.Text = "Imprimare dictionar";
            this.imprimareDictionarToolStripMenuItem.Click += new System.EventHandler(this.imprimareDictionarToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(90, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sterge din dictionar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnVerbe);
            this.Controls.Add(this.btnAdjective);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbAlfabetic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLitere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVcuvinte);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnInsereaza);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcuvinte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnInsereaza;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.DataGridView DGVcuvinte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLitere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbAlfabetic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdjective;
        private System.Windows.Forms.Button btnVerbe;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimareDictionarToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

