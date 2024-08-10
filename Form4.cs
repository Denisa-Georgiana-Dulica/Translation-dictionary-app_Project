using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public partial class Form4 : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProiectPAWBazaDate;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form4()
        {
            InitializeComponent();
            button2.Hide();
            btnActualizare.Hide();
            btnStergeSinonim.Hide();
            label9.Hide();
            button1.Hide();
            label10.Hide();    
            tbSinonimNou.Hide();
            cbAlege.Hide();
            
        }

        List<Cuvant> lista=new List<Cuvant>();
        public Form4(List<Cuvant> list)
        {
            InitializeComponent();
            lista.AddRange(list);
            button2.Hide();
            btnInsereaza.Hide();
            tbId.Hide();
            label2.Hide();
            tbCvRom.ReadOnly = true;
            tbCapitol.ReadOnly = true;
            tbSinonim.ReadOnly = true;
            foreach(Cuvant cuvant in list)
            {
                cbAlege.Items.Add(cuvant.Sensuri);
            }
           
        }

        public Form4(List<Cuvant> list, int nr)
        {
            InitializeComponent();
            lista.AddRange(list);
            btnInsereaza.Hide();
            tbId.Hide();
            label2.Hide();
            btnActualizare.Hide();
            btnStergeSinonim.Hide();
            label9.Hide();
            button1.Hide();
            label10.Hide();
            tbSinonimNou.Hide();
            tbCvRom.ReadOnly = true;
            tbCapitol.ReadOnly = true;
            tbSinonim.ReadOnly = true;
            foreach (Cuvant cuvant in list)
            {
                cbAlege.Items.Add(cuvant.Sensuri);
            }

        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
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
            conexiune.Open();
            SqlCommand comanda2 = new SqlCommand("SELECT MAX(ID) FROM CUVINTE", conexiune);
            int nrMax= Convert.ToInt32(comanda2.ExecuteScalar());
            SqlCommand comanda1= new SqlCommand("SELECT ID FROM CUVINTE",conexiune);
            SqlDataReader citeste = comanda1.ExecuteReader();
            List<int> ints = new List<int>();
            while(citeste.Read())
            {
                ints.Add(citeste.GetInt32(0));
            }
            citeste.Close();
           
            if (ints.Contains(Convert.ToInt32(tbId.Text)))
            {
                MessageBox.Show("Acest id deja exista, introduceti un id mai mare de " + nrMax, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbId.Clear();
            }
            else
            {
                char primaLitera = tbCvRom.Text[0];
                if (!list.Contains(tbCapitol.Text) || primaLitera != tbCapitol.Text[0])
                {
                    MessageBox.Show("Trebuie sa introduceti prima litera a cuvantului !", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCapitol.Clear();
                }
                else
                {
                    SqlCommand comanda = new SqlCommand("INSERT INTO CUVINTE " + "VALUES (@id,@cuvantRomana,@cuvantEngleza,@sensuri,@tip,@capitol,@sinonime)", conexiune);

                    comanda.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
                    comanda.Parameters.AddWithValue("@cuvantRomana", tbCvRom.Text);
                    comanda.Parameters.AddWithValue("@cuvantEngleza", tbCvEngl.Text);
                    comanda.Parameters.AddWithValue("@sensuri", tbSensuri.Text);
                    comanda.Parameters.AddWithValue("@tip", tbTip.Text);
                    comanda.Parameters.AddWithValue("@capitol", tbCapitol.Text);
                    comanda.Parameters.AddWithValue("@sinonime", tbSinonim.Text);
                    comanda.ExecuteNonQuery();//nu primesc ce s-a inserat/ ce s-a returnat
                    MessageBox.Show("Cuvant inserat !");
                   
                }
            }
            conexiune.Close();
           
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();//se inchide formularul
        }


        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (cbAlege.SelectedItem == null)
            {
                MessageBox.Show("Alege prima dată cuvântul cu un anumit sens!", "Alege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Sigur doriti sa actualizati cuvantul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexiune.Open();
                        SqlCommand comanda = new SqlCommand("UPDATE CUVINTE SET CuvantEngleza=@cuvantEngleza,Tip=@tip, Sensuri=@sensuri WHERE CuvantRomana=@cuvRom AND Sensuri=@sens", conexiune);

                        comanda.Parameters.AddWithValue("@sens", cbAlege.SelectedItem.ToString());
                        comanda.Parameters.AddWithValue("@cuvRom", tbCvRom.Text);
                        comanda.Parameters.AddWithValue("@cuvantEngleza", tbCvEngl.Text);
                        comanda.Parameters.AddWithValue("@sensuri", tbSensuri.Text);
                        comanda.Parameters.AddWithValue("@tip", tbTip.Text);
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Cuvânt actualizat!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbAlege.SelectedItem == null)
            {
                MessageBox.Show("Alege prima dată cuvântul cu un anumit sens!", "Alege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Sigur doriti sa stergeti cuvantul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    conexiune.Open();
                    SqlCommand comanda = new SqlCommand("DELETE FROM Cuvinte WHERE CuvantRomana=@cuvRom AND Sensuri=@sens", conexiune);
                    comanda.Parameters.AddWithValue("@sens", cbAlege.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@cuvRom", tbCvRom.Text);
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Cuvant sters!");
                    conexiune.Close();
                }
            }
        }
        private void cbAlege_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Cuvant cuvant in lista)
            {
                if (cbAlege.SelectedItem.ToString() == cuvant.Sensuri.ToString())
                {
                    tbCvRom.Text = cuvant.CuvantRomana;
                    tbCvEngl.Text = cuvant.CuvantEngleza;
                    tbSensuri.Text = cuvant.Sensuri;
                    tbTip.Text = cuvant.Tip;
                    tbCapitol.Text = cuvant.Capitol;
                    tbSinonim.Text = cuvant.Sinonime;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAlege.SelectedItem == null)
            {
                MessageBox.Show("Alege prima dată cuvântul cu un anumit sens!", "Alege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Sigur doriti sa actualizati cuvantul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sinonim_Nou=tbSinonimNou.Text;
                    Cuvant c = new Cuvant(tbCvRom.Text, tbCvEngl.Text, tbSensuri.Text, tbCapitol.Text, tbTip.Text, tbSinonim.Text);
                    c = c + sinonim_Nou;
                    conexiune.Open();
                    SqlCommand comanda = new SqlCommand("UPDATE CUVINTE SET sinonime=@sinonime WHERE CuvantRomana=@cuvRom AND Sensuri=@sens", conexiune);
                    comanda.Parameters.AddWithValue("@sens", cbAlege.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@cuvRom", tbCvRom.Text);
                    comanda.Parameters.AddWithValue("@sinonime", c.Sinonime);
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Cuvânt actualizat!");
                    conexiune.Close();
                }
            }
        }

        private void btnStergeSinonim_Click(object sender, EventArgs e)
        {
            if (cbAlege.SelectedItem == null)
            {
                MessageBox.Show("Alege prima dată cuvântul cu un anumit sens!", "Alege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Sigur doriti sa actualizati cuvantul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sinonim_Nou = tbSinonimNou.Text;
                    Cuvant c = new Cuvant(tbCvRom.Text, tbCvEngl.Text, tbSensuri.Text, tbCapitol.Text, tbTip.Text, tbSinonim.Text);
                    c = c - sinonim_Nou;
                    conexiune.Open();
                    SqlCommand comanda = new SqlCommand("UPDATE CUVINTE SET sinonime=@sinonime WHERE CuvantRomana=@cuvRom AND Sensuri=@sens", conexiune);
                    comanda.Parameters.AddWithValue("@sens", cbAlege.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@cuvRom", tbCvRom.Text);
                    comanda.Parameters.AddWithValue("@sinonime", c.Sinonime);
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Cuvant actualizat!");
                    conexiune.Close();
                }
            }
        }

        
    }
}
