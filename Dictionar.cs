using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public class Dictionar:ICloneable
    {
        private List<Cuvant> listaCuvinte;
        private int[] nrSensuri;
        private int[] nrCuvinteDupaSens;
        private int count;

        public Dictionar( int[] nrSensuri, int[] nrCuvinteDupaSens, int count)
        {
            this.count = count;
            this.nrSensuri = new int[count];
            for(int i=0;i<count;i++)
            {
                this.nrSensuri[i] = nrSensuri[i];
            }
            this.nrCuvinteDupaSens = new int[count];
            for (int i = 0; i < count; i++)
            {
                this.nrCuvinteDupaSens[i] = nrCuvinteDupaSens[i];
            }
           
            
        }

        public List<Cuvant> ListaCuvinte { get => listaCuvinte; set => listaCuvinte = value; }
        public int[] NrSensuri { get => nrSensuri; set => nrSensuri = value; }
        public int[] NrCuvinteDupaSens { get => nrCuvinteDupaSens; set => nrCuvinteDupaSens = value; }
        public int Count { get => count; set => count = value; }

        public Dictionar() 
        { 
            this.listaCuvinte = new List<Cuvant>();
        }

        //OPERATOR +
        public static Dictionar operator+(Dictionar d, Cuvant c)
        {
            Cuvant nou=(Cuvant)c.Clone();
            if(nou!=null)
            {
                d.listaCuvinte.Add(nou);
            }
            else
            {
                MessageBox.Show("Cuvant invalid !");
            }
            return d;
        }

        //FOREACH PENTRU COLECTIE
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cuvant cuvant in this.listaCuvinte)
            {
                sb.Append(cuvant.ToString());
            }
            return sb.ToString();
        }

        //1.METODA DE PRELUCRARE
        public List<Cuvant> CautaAdjective(Dictionar d)
        {
            List<Cuvant> listaAdjective=new List<Cuvant>();
            foreach(Cuvant c in d.listaCuvinte)
            {
                if (c.Tip.Trim() == "adjectiv")
                {
                    listaAdjective.Add(c);
                }
            }
            return listaAdjective;
        }

        //2.METODA DE PRELUCRARE
        public List<Cuvant> CautaVerbe(Dictionar d)
        { 
            List<Cuvant> listaVerbe = new List<Cuvant>();
            foreach (Cuvant c in d.listaCuvinte)
            {
                if (c.Tip.Trim() == "verb tranzitiv")
                {
                    listaVerbe.Add(c);
                }
            }
            return listaVerbe;
        }

        //3.METODA DE PRELUCRARE
        public int NumarSensuri(Cuvant c)
        {
            int num = 0;
            foreach(Cuvant cuv in this.listaCuvinte)
            {
                if(c.CuvantRomana == cuv.CuvantRomana)
                {
                    num++;
                }
            }
            return num;
        }

        //4.METODA DE PRELUCRARE
        public int NumarCuvinte(int nr)
        {
            int numarCuvinte = 0;
            foreach (Cuvant cuvant in this.listaCuvinte)
            {
                if (NumarSensuri(cuvant) == nr)
                {
                    numarCuvinte++;
                }
            }
            return numarCuvinte;
        }

        public object Clone()
        {
            Dictionar dictionar = new Dictionar();
            return dictionar;
        }
    }
}
