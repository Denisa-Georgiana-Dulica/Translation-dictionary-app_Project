namespace Proiect_PAW_Dictionar_Traduceri
{
    partial class Form5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaDateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziDateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisarePieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lvGrafic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.graficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaDateleToolStripMenuItem,
            this.veziDateleToolStripMenuItem,
            this.afisareGraficToolStripMenuItem,
            this.afisarePieChartToolStripMenuItem,
            this.imprimareGraficToolStripMenuItem});
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.graficToolStripMenuItem.Text = "Grafic";
            // 
            // salveazaDateleToolStripMenuItem
            // 
            this.salveazaDateleToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salveazaDateleToolStripMenuItem.Name = "salveazaDateleToolStripMenuItem";
            this.salveazaDateleToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.salveazaDateleToolStripMenuItem.Text = "Salveaza datele in fisier txt";
            this.salveazaDateleToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierulTextToolStripMenuItem_Click);
            // 
            // veziDateleToolStripMenuItem
            // 
            this.veziDateleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.veziDateleToolStripMenuItem.Name = "veziDateleToolStripMenuItem";
            this.veziDateleToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.veziDateleToolStripMenuItem.Text = "Vezi datele din fisierul txt";
            this.veziDateleToolStripMenuItem.Click += new System.EventHandler(this.veziDateleDinFisierToolStripMenuItem_Click);
            // 
            // afisareGraficToolStripMenuItem
            // 
            this.afisareGraficToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.afisareGraficToolStripMenuItem.Text = "Afisare Grafic";
            this.afisareGraficToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficToolStripMenuItem_Click);
            // 
            // afisarePieChartToolStripMenuItem
            // 
            this.afisarePieChartToolStripMenuItem.Name = "afisarePieChartToolStripMenuItem";
            this.afisarePieChartToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.afisarePieChartToolStripMenuItem.Text = "Afisare Pie Chart";
            this.afisarePieChartToolStripMenuItem.Click += new System.EventHandler(this.afisarePieChartToolStripMenuItem_Click);
            // 
            // imprimareGraficToolStripMenuItem
            // 
            this.imprimareGraficToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.imprimareGraficToolStripMenuItem.Name = "imprimareGraficToolStripMenuItem";
            this.imprimareGraficToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.imprimareGraficToolStripMenuItem.Text = "Imprimare grafic";
            this.imprimareGraficToolStripMenuItem.Click += new System.EventHandler(this.imprimareGraficToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lvGrafic
            // 
            this.lvGrafic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvGrafic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvGrafic.GridLines = true;
            this.lvGrafic.HideSelection = false;
            this.lvGrafic.Location = new System.Drawing.Point(49, 94);
            this.lvGrafic.Name = "lvGrafic";
            this.lvGrafic.Size = new System.Drawing.Size(303, 171);
            this.lvGrafic.TabIndex = 1;
            this.lvGrafic.UseCompatibleStateImageBehavior = false;
            this.lvGrafic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numar sensuri";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numar cuvinte din dictionar";
            this.columnHeader2.Width = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(138, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date din grafic";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(473, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 317);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CuvinteDupaSens";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(541, 311);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(716, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Afisare Grafic";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvGrafic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziDateleToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lvGrafic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem imprimareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisarePieChartToolStripMenuItem;
    }
}