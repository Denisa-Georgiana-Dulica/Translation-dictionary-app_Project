using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public class Cuvant:ICloneable,IComparable<Cuvant>
    {
        private int id;
        private string cuvantRomana;
        private string cuvantEngleza;
        private string sensuri;
        private string tip;
        private string capitol;
        private string sinonime;

        public Cuvant(int id, string cuvantRomana, string cuvantEngleza, string sensuri, string tip, string capitol,string sinonime)
        {
            this.id = id;
            this.cuvantRomana = cuvantRomana;
            this.cuvantEngleza = cuvantEngleza;
            this.sensuri = sensuri;
            this.tip = tip;
            this.capitol = capitol;
            this.sinonime = sinonime;
        }

        public Cuvant(string cuvantRomana, string cuvantEngleza, string sensuri, string capitol, string tip,string sinonime)
        { 
            this.cuvantRomana = cuvantRomana;
            this.cuvantEngleza = cuvantEngleza;
            this.sensuri = sensuri;
            this.tip = tip;
            this.capitol= capitol;
            this.sinonime = sinonime;
        }

       
        public int Id { get => id; set => id = value; }
        public string CuvantRomana { get => cuvantRomana; set => cuvantRomana = value; }
        public string CuvantEngleza { get => cuvantEngleza; set => cuvantEngleza = value; }
        public string Sensuri { get => sensuri; set => sensuri = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Capitol { get => capitol; set => capitol = value; }
        public string Sinonime { get => sinonime; set => sinonime = value; }

        //CLONE
        public object Clone()
        {
            Cuvant c = new Cuvant(this.id,this.CuvantRomana, this.CuvantEngleza, this.sensuri, this.tip, this.capitol,this.sinonime);
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.CuvantRomana);
            sb.Append(" Traducere:");
            sb.Append(this.CuvantEngleza);
            sb.Append(" Sens: ");
            sb.Append(this.Sensuri);
            sb.Append(" Tip: ");
            sb.Append(this.Tip);
            sb.Append(" Capitol: ");
            sb.Append(this.Capitol);
            sb.Append(" Sinonime: ");
            if(this.sinonime == "")
            {
                sb.Append("fara sinonim");
            }
            else
             sb.Append(this.sinonime);
            return sb.ToString();
        }

        //COMPARABLE
        public int CompareTo(Cuvant obj)
        {
            if (obj is Cuvant)
            {
                
                if (this.cuvantRomana.Trim().Length< obj.cuvantRomana.Trim().Length)
                {
                    return -1;
                }
                else
                {
                    if (this.cuvantRomana.Trim().Length > obj.cuvantRomana.Trim().Length)
                    {
                        return 1;
                    }
                    else
                    {
                        
                        return 0;
                    }
                }
                return -2;
            }
            return -3;
        }

        //OPERATOR +
        public static Cuvant operator+(Cuvant c,string sinonim)
        {
            if (c != null)
            {
                Cuvant cuvant = (Cuvant)c.Clone();
                cuvant.sinonime += "," + sinonim;
                return cuvant;
            }
            else
                return null;
        }

        //OPERATOR -
        public static Cuvant operator -(Cuvant c, string sinonim)
        {
            if (c != null)
            {
                Cuvant cuvant = (Cuvant)c.Clone();
                string[] date = cuvant.sinonime.Split(',');
                List<string> sinonime= new List<string>(date);
                if (date.Length > 0)
                {
                    if(sinonime.Contains(sinonim))
                    {
                        sinonime.Remove(sinonim);
                    }
                }

                cuvant.sinonime = string.Join(",", sinonime); 
                return cuvant;
            }
            else
                return null;
        }

        //1.METODA DE PRELUCRARE
        public void ConvertesteLaUppercase()
        {
            this.cuvantRomana = this.cuvantRomana.ToUpper();
            this.cuvantEngleza = this.cuvantEngleza.ToUpper();
            this.sensuri = this.sensuri.ToUpper();
            this.tip = this.tip.ToUpper();
            this.capitol = this.capitol.ToUpper();
            this.sinonime = this.sinonime.ToUpper();
        }

        //2.METODA DE PRELUCRARE
        public void ConvertesteLaLowercase()
        {
            this.cuvantRomana = this.cuvantRomana.ToLower();
            this.cuvantEngleza = this.cuvantEngleza.ToLower();
            this.sensuri = this.sensuri.ToLower();
            this.tip = this.tip.ToLower();
            this.capitol = this.capitol.ToLower();
            this.sinonime = this.sinonime.ToLower();
        }

    }
}
