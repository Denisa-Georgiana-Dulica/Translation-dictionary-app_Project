namespace Proiect_PAW_Dictionar_Traduceri
{
    partial class Form3
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
            this.lbDictionare = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myWishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToWishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziWishListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPretDescrescator = new System.Windows.Forms.RadioButton();
            this.rbPretCrescator = new System.Windows.Forms.RadioButton();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.cbLibrariiOnline = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDisponibile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lvCitireDinFisier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPretTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDictionare
            // 
            this.lbDictionare.BackColor = System.Drawing.Color.Gainsboro;
            this.lbDictionare.FormattingEnabled = true;
            this.lbDictionare.ItemHeight = 16;
            this.lbDictionare.Location = new System.Drawing.Point(60, 129);
            this.lbDictionare.Name = "lbDictionare";
            this.lbDictionare.Size = new System.Drawing.Size(530, 116);
            this.lbDictionare.TabIndex = 0;
            this.lbDictionare.SelectedIndexChanged += new System.EventHandler(this.lbDictionare_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myWishListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myWishListToolStripMenuItem
            // 
            this.myWishListToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.myWishListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToWishListToolStripMenuItem,
            this.veziWishListToolStripMenuItem});
            this.myWishListToolStripMenuItem.Name = "myWishListToolStripMenuItem";
            this.myWishListToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.myWishListToolStripMenuItem.Text = "MyWishList";
            // 
            // saveToWishListToolStripMenuItem
            // 
            this.saveToWishListToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.saveToWishListToolStripMenuItem.Name = "saveToWishListToolStripMenuItem";
            this.saveToWishListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToWishListToolStripMenuItem.Text = "Salveaza wishList";
            this.saveToWishListToolStripMenuItem.Click += new System.EventHandler(this.saveToWishListToolStripMenuItem_Click);
            // 
            // veziWishListToolStripMenuItem
            // 
            this.veziWishListToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.veziWishListToolStripMenuItem.Name = "veziWishListToolStripMenuItem";
            this.veziWishListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.veziWishListToolStripMenuItem.Text = "Vezi wishList";
            this.veziWishListToolStripMenuItem.Click += new System.EventHandler(this.veziWishListToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPretDescrescator);
            this.groupBox1.Controls.Add(this.rbPretCrescator);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(60, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // rbPretDescrescator
            // 
            this.rbPretDescrescator.AutoSize = true;
            this.rbPretDescrescator.Location = new System.Drawing.Point(215, 21);
            this.rbPretDescrescator.Name = "rbPretDescrescator";
            this.rbPretDescrescator.Size = new System.Drawing.Size(148, 21);
            this.rbPretDescrescator.TabIndex = 1;
            this.rbPretDescrescator.TabStop = true;
            this.rbPretDescrescator.Text = "Pret Descrescator";
            this.rbPretDescrescator.UseVisualStyleBackColor = true;
            this.rbPretDescrescator.CheckedChanged += new System.EventHandler(this.rbPretDescrescator_CheckedChanged);
            // 
            // rbPretCrescator
            // 
            this.rbPretCrescator.AutoSize = true;
            this.rbPretCrescator.Location = new System.Drawing.Point(6, 23);
            this.rbPretCrescator.Name = "rbPretCrescator";
            this.rbPretCrescator.Size = new System.Drawing.Size(126, 21);
            this.rbPretCrescator.TabIndex = 0;
            this.rbPretCrescator.TabStop = true;
            this.rbPretCrescator.Text = "Pret Crescator";
            this.rbPretCrescator.UseVisualStyleBackColor = true;
            this.rbPretCrescator.CheckedChanged += new System.EventHandler(this.rbPretCrescator_CheckedChanged);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(649, 213);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(232, 22);
            this.tbPret.TabIndex = 4;
            // 
            // cbLibrariiOnline
            // 
            this.cbLibrariiOnline.FormattingEnabled = true;
            this.cbLibrariiOnline.Location = new System.Drawing.Point(649, 129);
            this.cbLibrariiOnline.Name = "cbLibrariiOnline";
            this.cbLibrariiOnline.Size = new System.Drawing.Size(232, 24);
            this.cbLibrariiOnline.TabIndex = 5;
            this.cbLibrariiOnline.SelectedIndexChanged += new System.EventHandler(this.cbLibrariiOnline_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(313, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sugestii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(646, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dictionarul se poate achizitiona de aici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(649, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pret disponibil online";
            // 
            // tbDisponibile
            // 
            this.tbDisponibile.Location = new System.Drawing.Point(649, 278);
            this.tbDisponibile.Multiline = true;
            this.tbDisponibile.Name = "tbDisponibile";
            this.tbDisponibile.Size = new System.Drawing.Size(232, 81);
            this.tbDisponibile.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(652, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alte dictionare disponibile pe site";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lvCitireDinFisier
            // 
            this.lvCitireDinFisier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCitireDinFisier.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvCitireDinFisier.GridLines = true;
            this.lvCitireDinFisier.HideSelection = false;
            this.lvCitireDinFisier.Location = new System.Drawing.Point(60, 292);
            this.lvCitireDinFisier.Name = "lvCitireDinFisier";
            this.lvCitireDinFisier.Size = new System.Drawing.Size(530, 126);
            this.lvCitireDinFisier.TabIndex = 11;
            this.lvCitireDinFisier.UseCompatibleStateImageBehavior = false;
            this.lvCitireDinFisier.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titlu";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autor";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Editura";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Librarie online";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(284, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Afiseaza WishList";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(380, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pret total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPretTotal
            // 
            this.tbPretTotal.Location = new System.Drawing.Point(445, 424);
            this.tbPretTotal.Name = "tbPretTotal";
            this.tbPretTotal.ReadOnly = true;
            this.tbPretTotal.Size = new System.Drawing.Size(145, 22);
            this.tbPretTotal.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 483);
            this.Controls.Add(this.tbPretTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvCitireDinFisier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDisponibile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLibrariiOnline);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDictionare);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDictionare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myWishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToWishListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziWishListToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPretDescrescator;
        private System.Windows.Forms.RadioButton rbPretCrescator;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.ComboBox cbLibrariiOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDisponibile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lvCitireDinFisier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPretTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}