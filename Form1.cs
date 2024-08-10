using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public partial class Form1 : Form
    {
        Dictionar dictionar = new Dictionar();
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectPAWBazaDate;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        public void AdaugaInLista()
        {
            List<int> ints = new List<int>();
            foreach (Cuvant cuv in dictionar.ListaCuvinte)
            {
                ints.Add(cuv.Id);
            }
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Cuvinte", conexiune);
            adaptor.Fill(dt);
            conexiune.Close();
            dictionar.ListaCuvinte.Clear();
            foreach (DataRow rand in dt.Rows)
            {
                int id = Convert.ToInt32(rand["ID"]);
                string cuvantRomana = rand["CuvantRomana"].ToString();
                string cuvantEngleza = rand["CuvantEngleza"].ToString();
                string sensuri = rand["Sensuri"].ToString();
                string tip = rand["Tip"].ToString();
                string capitol = rand["Capitol"].ToString();
                string sinonime = rand["sinonime"].ToString();
                Cuvant c = new Cuvant(id, cuvantRomana, cuvantEngleza, sensuri, tip, capitol, sinonime);
                dictionar = dictionar + c;


            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AdaugaInLista();
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Add("g");
            list.Add("h");
            list.Add("i");
            list.Add("j");
            list.Add("k");
            list.Add("l");
            list.Add("m");
            list.Add("n");
            list.Add("o");
            list.Add("p");
            list.Add("q");
            list.Add("r");
            list.Add("s");
            list.Add("t");
            list.Add("u");
            list.Add("v");
            list.Add("w");
            list.Add("x");
            list.Add("y");
            list.Add("z");
            cbLitere.DataSource = list;
        }
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            rbAlfabetic.Checked = false;
            string litera = cbLitere.SelectedItem.ToString();
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT DISTINCT CuvantRomana FROM Cuvinte where Capitol=@litera", conexiune);
            adaptor.SelectCommand.Parameters.AddWithValue("@litera", litera);
            adaptor.Fill(dt);
            DGVcuvinte.DataSource = dt;
            conexiune.Close();
            AdaugaInLista();

        }

        private void DGVcuvinte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                List<Cuvant> list = new List<Cuvant>();
                DataGridViewRow rand = DGVcuvinte.Rows[e.RowIndex];
                string cuvant = rand.Cells[0].Value.ToString();
                conexiune.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter("SELECT CuvantRomana,CuvantEngleza,Sensuri,Tip,Capitol,sinonime FROM Cuvinte where CuvantRomana=@cuvant", conexiune);
                adaptor.SelectCommand.Parameters.AddWithValue("@cuvant", cuvant);
                adaptor.Fill(dt);
                conexiune.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string cuvantRomana = row["CuvantRomana"].ToString();
                    string cuvantEngleza = row["CuvantEngleza"].ToString();
                    string sensuri = row["Sensuri"].ToString();
                    string tip = row["Tip"].ToString();
                    string capitol = row["Capitol"].ToString();
                    string sinonime = row["sinonime"].ToString();
                    Cuvant c = new Cuvant(cuvantRomana, cuvantEngleza, sensuri, capitol, tip, sinonime);
                    list.Add(c);
                }

                Form2 form2 = new Form2(list);
                form2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

        }

        List<Cuvant> list;
        bool este_selectat = false;
        private void DGVcuvinte_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                list = new List<Cuvant>();
                string cuvRomana = DGVcuvinte.Rows[e.RowIndex].Cells[0].Value.ToString();//click pe header
                este_selectat = true;
                conexiune.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adaptor = new SqlDataAdapter("SELECT CuvantRomana,CuvantEngleza,Sensuri,Tip,Capitol,sinonime FROM Cuvinte where CuvantRomana=@cuvant", conexiune);
                adaptor.SelectCommand.Parameters.AddWithValue("@cuvant", cuvRomana);
                adaptor.Fill(dt);
                conexiune.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string cuvantRomana = row["CuvantRomana"].ToString();
                    string cuvantEngleza = row["CuvantEngleza"].ToString();
                    string sensuri = row["Sensuri"].ToString();
                    string tip = row["Tip"].ToString();
                    string capitol = row["Capitol"].ToString();
                    string sinonime = row["sinonime"].ToString();
                    Cuvant c = new Cuvant(cuvantRomana, cuvantEngleza, sensuri, capitol, tip, sinonime);
                    list.Add(c);
                }


            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            if (este_selectat == false)
            {
                MessageBox.Show("Inainte sa actualizati trebuie sa selectati cuvantul printr-un click pe header !", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form4 form4 = new Form4(list);
                form4.Show();
            }
        }

        private void rbAlfabetic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlfabetic.Checked)
            {
                AfiseazaCuvinteleInOrdineAlfabetica();
            }
        }
        private void AfiseazaCuvinteleInOrdineAlfabetica()
        {
            string litera = cbLitere.SelectedItem.ToString();
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT DISTINCT CuvantRomana FROM Cuvinte where Capitol=@litera", conexiune);
            adaptor.SelectCommand.Parameters.AddWithValue("@litera", litera);
            adaptor.Fill(dt);
            conexiune.Close();
            DataTable dt2 = dt.Clone();
            dictionar.ListaCuvinte.Sort();
            foreach (Cuvant cuv in dictionar.ListaCuvinte)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string cuvant = row["CuvantRomana"].ToString();
                    if (cuvant == cuv.CuvantRomana)
                    {
                        dt2.Rows.Add(cuv.CuvantRomana);
                    }
                }
            }
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("CuvantRomana");
            foreach (DataRow row in dt2.Rows)
            {
                bool exista = false;
                foreach (DataRow row1 in dt3.Rows)
                {
                    if (row["CuvantRomana"].Equals(row1["CuvantRomana"]))
                    {
                        exista = true;
                    }
                }
                if (!exista)
                {
                    DataRow nou = dt3.NewRow();
                    nou["CuvantRomana"] = row["CuvantRomana"];
                    dt3.Rows.Add(nou);
                }
            }

            DGVcuvinte.DataSource = dt3;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdjective_Click(object sender, EventArgs e)
        {
            List<Cuvant> adjective = new List<Cuvant>();
            adjective.AddRange(dictionar.CautaAdjective(dictionar));
            DataTable dt = new DataTable();
            dt.Columns.Add("Adjective", typeof(string));
            foreach (Cuvant cuvant in adjective)
            {
                DataRow nou = dt.NewRow();
                nou["Adjective"] = cuvant.CuvantRomana;
                dt.Rows.Add(nou);
            }


            DGVcuvinte.DataSource = dt;
        }

        private void btnVerbe_Click(object sender, EventArgs e)
        {
            List<Cuvant> verbe = new List<Cuvant>();
            verbe.AddRange(dictionar.CautaVerbe(dictionar));
            DataTable dt = new DataTable();
            dt.Columns.Add("Verbe", typeof(string));
            foreach (Cuvant cuvant in verbe)
            {
                DataRow nou = dt.NewRow();
                nou["Verbe"] = cuvant.CuvantRomana;
                dt.Rows.Add(nou);
            }
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Verbe");
            foreach (DataRow row in dt.Rows)
            {
                bool exista = false;
                foreach (DataRow row1 in dt1.Rows)
                {
                    if (row["Verbe"].Equals(row1["Verbe"]))
                    {
                        exista = true;
                    }
                }
                if (!exista)
                {
                    DataRow nou = dt1.NewRow();
                    nou["Verbe"] = row["Verbe"];
                    dt1.Rows.Add(nou);
                }
            }

            DGVcuvinte.DataSource = dt1;
        }


        private void btnGrafic_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(dictionar);
            form5.Show();
        }

        int contor = 0;
        private void imprimareDictionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(print);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = pd
            };
            contor = 0;
            pdlg.ShowDialog();
        }
        private void print(object sender, PrintPageEventArgs e)
        {
            int margine = 10;
            if (dictionar.ListaCuvinte!=null)
            {
                Font font=new Font(FontFamily.GenericSansSerif, 10);
                Graphics g = e.Graphics;
                Rectangle dreptunghi = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 4 * margine, e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 5 * margine);
                Pen creion = new Pen(Color.Black, 3);
                Brush brFont=new SolidBrush(Color.Black);
                int y = margine;
                for (int i =contor; i < dictionar.ListaCuvinte.Count; i++)
                {
                    Cuvant cuv = dictionar.ListaCuvinte[i];
                    string line = $"ID: {cuv.Id} - Cuvant Romana: {cuv.CuvantRomana.Trim()} - Cuvant Engleza: {cuv.CuvantEngleza.Trim()}, Sensuri: {cuv.Sensuri.Trim()}, Tip: {cuv.Tip.Trim()},Sinonime: {cuv.Sinonime.Trim()}";
                    g.DrawString(line, font, brFont, new Point(margine, y));
                    y += font.Height + 5;

                    if (y + margine > e.PageBounds.Height)
                    {
                        contor = i + 1;
                        e.HasMorePages = true;
                        return;
                    }
                }
                e.HasMorePages = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nr = 0;
            if (este_selectat == false)
            {
                MessageBox.Show("Inainte sa actualizati trebuie sa selectati cuvantul printr-un click pe header !", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form4 form4 = new Form4(list,nr);
                form4.Show();
            }
        }
    }
}
