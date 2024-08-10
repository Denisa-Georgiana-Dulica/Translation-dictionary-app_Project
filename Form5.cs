using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public partial class Form5 : Form
    {
        Dictionar dictionar = new Dictionar();
        int count = 0;
        bool dateIncarcate=false;
        const int margine = 10;

        Color color = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif,12,FontStyle.Bold);
        Color culoareText = Color.Black;
        public Form5(Dictionar d)
        {
            InitializeComponent();
            dictionar.ListaCuvinte.AddRange(d.ListaCuvinte);
        }

        private void salvareInFisierulTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<int> ints = new HashSet<int>();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName); 
                foreach (Cuvant cuv in dictionar.ListaCuvinte)
                {
                    int nr = dictionar.NumarSensuri(cuv);
                    ints.Add(nr);
                }
                foreach (int i in ints)
                {
                    sw.Write(i);
                    sw.Write(",");
                    sw.Write(dictionar.NumarCuvinte(i) / i);
                    sw.WriteLine();
                }
                sw.Close();
                dateIncarcate = true;
                MessageBox.Show($"S-a salvat fisierul {saveFileDialog1.FileName}");

            }

        }

        Dictionar dictionar1;
        private void veziDateleDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<int> nr1=new List<int>();
            List<int> nr2= new List<int>();
            lvGrafic.Items.Clear();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (!sr.EndOfStream)
                {
                    string linie = sr.ReadLine();
                    if (string.IsNullOrEmpty(linie))
                    {
                        continue;
                    }
                    string[] date = linie.Split(',');
                    int nrSensuri = Convert.ToInt32(date[0]);
                    int nrCuvinte = Convert.ToInt32(date[1]);
                    nr1.Add(nrSensuri);
                    nr2.Add(nrCuvinte);
                    ListViewItem listView = new ListViewItem(nrSensuri.ToString());
                    listView.SubItems.Add(nrCuvinte.ToString());
                    lvGrafic.Items.Add(listView);
                    count++;
                }
                dateIncarcate = true;
                sr.Close();
                int[] nrS=nr1.ToArray();
                int[] nrC=nr2.ToArray();
                dictionar1 = new Dictionar(nrS,nrC,count);
                MessageBox.Show($"S-a citit fisierul {saveFileDialog1.FileName}");
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            chart1.Visible = false;
            if (dateIncarcate == true)
            {
                Graphics g = e.Graphics;
                Rectangle dreptunghi = new Rectangle(panel1.ClientRectangle.X + margine, panel1.ClientRectangle.Y + 4 * margine, panel1.ClientRectangle.Width - 2 * margine, panel1.ClientRectangle.Height - 5 * margine);
                Pen creion = new Pen(Color.Black,3);
                g.DrawRectangle(creion, dreptunghi);

                double latimeColoane = dreptunghi.Width / (dictionar1.Count * 3.0);
                double distantaColoane = (dreptunghi.Width - dictionar1.Count * latimeColoane) / (dictionar1.Count + 1);
                double inaltimeMaxima = dictionar1.NrCuvinteDupaSens.Max();

                Brush brColoane = new SolidBrush(color);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] coloane = new Rectangle[dictionar1.Count];
                for (int i = 0; i < coloane.Length; i++)
                {
                    double inaltimeColoana = (dictionar1.NrCuvinteDupaSens[i] / inaltimeMaxima) * dreptunghi.Height;
                    coloane[i] = new Rectangle(
                        (int)(dreptunghi.Location.X + (i + 1) * distantaColoane + i * latimeColoane),
                        (int)(dreptunghi.Location.Y + dreptunghi.Height - inaltimeColoana),
                        (int)latimeColoane,
                        (int)inaltimeColoana);

                    g.FillRectangle(brColoane, coloane[i]);

                    //textul deasupra fiecărei coloane
                    string text = dictionar1.NrSensuri[i].ToString();
                    SizeF textSize = g.MeasureString(text, font);
                    PointF textPosition = new PointF(
                        coloane[i].X + (coloane[i].Width - textSize.Width) / 2,
                        coloane[i].Y - textSize.Height);
                    g.DrawString(text, font, brFont, textPosition);
                }
            }
        }

        private void afisareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dateIncarcate==true)
            {
                chart1.Visible = false;
                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate ! Incarca datele prin salvarea/vizualizarea datelor.","Atentie",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }

        private void print(object sender, PrintPageEventArgs e)
        {
            chart1.Visible = false;
            if (dateIncarcate == true)
            {
                Graphics g = e.Graphics;
                Rectangle dreptunghi = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 4 * margine, e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 5 * margine);
                Pen creion = new Pen(Color.Black, 3);
                g.DrawRectangle(creion, dreptunghi);

                double latimeColoane = dreptunghi.Width / (dictionar1.Count * 3.0);
                double distantaColoane = (dreptunghi.Width - dictionar1.Count * latimeColoane) / (dictionar1.Count + 1);
                double inaltimeMaxima = dictionar1.NrCuvinteDupaSens.Max();

                Brush brColoane = new SolidBrush(color);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] coloane = new Rectangle[dictionar1.Count];
                for (int i = 0; i < coloane.Length; i++)
                {
                    double inaltimeColoana = (dictionar1.NrCuvinteDupaSens[i] / inaltimeMaxima) * dreptunghi.Height;
                    coloane[i] = new Rectangle(
                        (int)(dreptunghi.Location.X + (i + 1) * distantaColoane + i * latimeColoane),
                        (int)(dreptunghi.Location.Y + dreptunghi.Height - inaltimeColoana),
                        (int)latimeColoane,
                        (int)inaltimeColoana);

                    g.FillRectangle(brColoane, coloane[i]);

                    string text = dictionar1.NrSensuri[i].ToString();
                    SizeF textSize = g.MeasureString(text, font);
                    PointF textPosition = new PointF(
                        coloane[i].X + (coloane[i].Width - textSize.Width) / 2,
                        coloane[i].Y - textSize.Height);
                    g.DrawString(text, font, brFont, textPosition);
                }
            }
        }

        private void imprimareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(print);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = pd
            };
            pdlg.ShowDialog();
        }

        private void afisarePieChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dateIncarcate==true)
            {

                chart1.Series["CuvinteDupaSens"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                for(int i=0; i<dictionar1.NrCuvinteDupaSens.Count();i++)
                {
                    chart1.Series["CuvinteDupaSens"].Points.AddXY(dictionar1.NrSensuri[i], dictionar1.NrCuvinteDupaSens[i]);
                }
                chart1.Titles.Add("Numar cuvinte care au un anumit numar de sensuri");
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate ! Incarca datele prin salvarea/vizualizarea datelor.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
