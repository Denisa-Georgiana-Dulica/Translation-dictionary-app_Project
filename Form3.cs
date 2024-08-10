using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public partial class Form3 : Form
    {
        List<CarteTipDictionar> carteTipDictionar_lista=new List<CarteTipDictionar>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Dictionar.xml");
            XmlNodeList xnlist = xmlDocument.SelectNodes("/catalog");
            foreach (XmlNode xn in xnlist)
            {
                XmlNodeList xnlist2 = xn.ChildNodes;
                foreach (XmlNode xn2 in xnlist2)
                {
                    string autor = xn2["autor"].InnerText;
                    string titlu = xn2["titlu"].InnerText;
                    string gen = xn2["gen"].InnerText;
                    XmlNode preturi = xn2["preturiDisponibile"];
                    XmlNodeList xnlist3 = preturi.ChildNodes;
                    List<float> lista_preturi=new List<float>();
                    foreach(XmlNode xn3 in xnlist3)
                    {
                        float pret;
                        if (float.TryParse(xn3.InnerText, NumberStyles.Float | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint,CultureInfo.InvariantCulture, out pret))
                        {
                            lista_preturi.Add(pret);
                        }
                    }
                    float[] preturi_vector=lista_preturi.ToArray();
                    string editura = xn2["editura"].InnerText;
                    XmlNode siteuri = xn2["siteUriDisponibile"];
                    XmlNodeList xnlist4 = siteuri.ChildNodes;
                    List<string> lista_site = new List<string>();
                    foreach (XmlNode xn4 in xnlist4)
                    {
                        string site = xn4.InnerText;
                        lista_site.Add(site);
                    }
                    string[] site_vestor = lista_site.ToArray();
                    CarteTipDictionar c=new CarteTipDictionar(autor,titlu,gen,preturi_vector,editura,site_vestor);
                    lbDictionare.Items.Add(c.Titlu+","+c.Autor+ "," + c.Editura);
                    carteTipDictionar_lista.Add(c);
                }

            }
        }

        private void rbPretCrescator_CheckedChanged(object sender, EventArgs e)
        {
            carteTipDictionar_lista.Sort();
            lbDictionare.Items.Clear();
            foreach (CarteTipDictionar c in carteTipDictionar_lista)
            {
                lbDictionare.Items.Add(c.Titlu + "," + c.Autor + "," + c.Editura);
            }
        }

        private string titlu;
        private string autor;
        private string editura;
        private void lbDictionare_SelectedIndexChanged(object sender, EventArgs e)
        {

            string rand = lbDictionare.SelectedItem.ToString();
            titlu = rand.Split(',')[0];
            autor = rand.Split(',')[1];
            editura = rand.Split(',')[2];
            foreach (CarteTipDictionar carte in carteTipDictionar_lista)
            {
                if (titlu == carte.Titlu && autor==carte.Autor && editura==carte.Editura)
                {
                    cbLibrariiOnline.DataSource = carte.LibrariiOnline;
                }
            }


        }

        private void rbPretDescrescator_CheckedChanged(object sender, EventArgs e)
        {
            int nr=carteTipDictionar_lista.Count;
            for(int i=0;i<nr;i++)
            {
                for(int j=i+1;j<nr;j++)
                {
                    if (carteTipDictionar_lista[i] < carteTipDictionar_lista[j])
                    {
                        CarteTipDictionar temp=carteTipDictionar_lista[i];
                        carteTipDictionar_lista[i]= carteTipDictionar_lista[j];
                        carteTipDictionar_lista[j] = temp;
                    }
                }
            }
            lbDictionare.Items.Clear();
            foreach (CarteTipDictionar c in carteTipDictionar_lista)
            {
                lbDictionare.Items.Add(c.Titlu + "," + c.Autor + "," + c.Editura);
            }
        }

        private void cbLibrariiOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CarteTipDictionar> alteCarti=new List<CarteTipDictionar>();
            string alegere = cbLibrariiOnline.SelectedItem.ToString();
            int index = 0;
            tbPret.Clear();
            foreach (CarteTipDictionar carte in carteTipDictionar_lista)
            {
                if (titlu == carte.Titlu && autor == carte.Autor && editura == carte.Editura)
                {
                    for (int i = 0; i < carte.LibrariiOnline.Count(); i++)
                    {
                        if (alegere == carte.LibrariiOnline[i])
                        {
                            index = i;
                        }
                    }
                    tbPret.Text = carte.Pret[index].ToString();//operator index

                }
               alteCarti.AddRange(carte.CautareDePeSite(alegere));
                
            }
            tbDisponibile.Clear();
            foreach (CarteTipDictionar c in alteCarti)
            {
                tbDisponibile.Text += "Titlu: "+ c.Titlu+" Autor: "+c.Autor + Environment.NewLine;
            }
        }

        private void saveToWishListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbDictionare.SelectedItem == null)
            {
                MessageBox.Show("Alegeti un dictionar din lista pentru a adauga in wishList !", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string rand = lbDictionare.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Ati selectat libraria online de unde să achiziționați dictionarul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Nu ați ales librăria online. Pentru a adăuga în wishList, trebuie să selectați o librărie online.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    saveFileDialog1.Filter = "(*.txt)|*.txt";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);

                        titlu = rand.Split(',')[0];
                        autor = rand.Split(',')[1];
                        editura = rand.Split(',')[2];
                        int index = cbLibrariiOnline.SelectedIndex;
                        foreach (CarteTipDictionar carte in carteTipDictionar_lista)
                        {
                            if (titlu == carte.Titlu && autor == carte.Autor && editura == carte.Editura)
                            {
                                sw.Write(carte.Titlu);
                                sw.Write(";");
                                sw.Write(carte.Autor);
                                sw.Write(";");
                                sw.Write(carte.Editura);
                                sw.Write(";");
                                sw.Write(carte.Pret[index]);
                                sw.Write(";");
                                sw.Write(carte.LibrariiOnline[index]);

                            }
                        }
                        sw.WriteLine();
                        sw.Close();
                        MessageBox.Show($"S-a salvat fisierul {saveFileDialog1.FileName}");
                    }
                }
            }
        }

        private void veziWishListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                float sumaTotala = 0;
                lvCitireDinFisier.Items.Clear();
                StreamReader sr=new StreamReader(openFileDialog1.FileName);
                while( !sr.EndOfStream )
                {
                    string linie=sr.ReadLine();
                    if(string.IsNullOrEmpty(linie))
                    {
                        continue;
                    }
                    string[] date = linie.Split(';');
                    string titlu = date[0];
                    string autor = date[1];
                    string editura = date[2];
                    float pret = float.Parse(date[3]);
                    string librarie = date[4];
                    ListViewItem listView=new ListViewItem(titlu);
                    listView.SubItems.Add(autor);
                    listView.SubItems.Add(editura);
                    listView.SubItems.Add(pret.ToString());
                    listView.SubItems.Add(librarie);
                    lvCitireDinFisier.Items.Add(listView);
                    sumaTotala += CarteTipDictionar.CalculeazaSuma(pret);
                }
                tbPretTotal.Text=sumaTotala.ToString();
                sr.Close();
            }
        }
    }
}
