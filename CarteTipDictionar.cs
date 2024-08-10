using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proiect_PAW_Dictionar_Traduceri
{
    internal class CarteTipDictionar:ICloneable,IComparable<CarteTipDictionar>,ICautare
    {
        private int id;
        private string autor;
        private string titlu;
        private string gen;
        private float[] pret;
        private string editura;
        private string[] librariiOnline;
        private static int nrDictionare=3;

        public CarteTipDictionar(string autor, string titlu, string gen, float[] pret, string editura, string[] librariiOnline)
        { 
            this.autor = autor;
            this.titlu = titlu;
            this.gen = gen;
            this.pret = new float[nrDictionare];
            for(int i=0;i<nrDictionare;i++)
            {
                this.pret[i] = pret[i];
            }
            this.editura = editura;
            this.librariiOnline = new string[nrDictionare];
            for (int i = 0; i < nrDictionare; i++)
            {
                this.librariiOnline[i] = librariiOnline[i];
            }
        }

        public CarteTipDictionar(string titlu,string autor,string editura)
        {
            this.autor = autor;
            this.titlu = titlu;
            this.editura = editura;
            
        }
        public string Autor { get => autor; set => autor = value; }
        public string Titlu { get => titlu; set => titlu = value; }
        public string Gen { get => gen; set => gen = value; }
        public float[] Pret { get => pret; set => pret = value; }
        public string Editura { get => editura; set => editura = value; }
        public string[] LibrariiOnline { get => librariiOnline; set => librariiOnline = value; }

        //INTERFATA CLONE
        public object Clone()
        {
            CarteTipDictionar c=new CarteTipDictionar(this.autor, this.titlu, this.gen, this.pret, this.editura, this.librariiOnline);
            return c;
        }

        //INTERFATA COMPARABLE
        public int CompareTo(CarteTipDictionar obj)
        {
            if(obj is CarteTipDictionar)
            {
                float pret=this.pret.Min();
                float pret1= obj.pret.Min();
                if(pret>pret1)
                {
                    return 1;//valoarea trebuie pusa dupa 
                }
                else
                    if(pret<pret1) 
                { 
                    return -1;//valoarea trebuie pusa dupa inainte
                }
                else
                    return 0;

            }
            else
                return -2;
        }

        //1. OPERATOR >
        public static bool operator >(CarteTipDictionar a, CarteTipDictionar b)
        {
            float pret=a.pret.Min();
            float pret1=b.pret.Min();
            if (pret > pret1)
            {
                return true;
            }
            else
                if (pret < pret1)
            {
                return false;

            }
            else
                return false;
        }

        //2. OPERATOR <
        public static bool operator <(CarteTipDictionar a, CarteTipDictionar b)
        {
            float pret = a.pret.Min();
            float pret1 = b.pret.Min();
            if (pret > pret1)
            {
                return false;
            }
            else
                if (pret < pret1)
            {
                return true;

            }
            else
                return false;
        }

        //OPERATOR INDEX
        public float this[int index]
        {
            get
            {
                if(index < 0 && index<this.pret.Length)
                {
                    return this.pret[index];
                }
                else
                {
                    MessageBox.Show("Nu exista indexul");
                    return 0;
                }
            }
        }

        //1.cautare dupa editura METODA DE PRELUCRARE
        public List<CarteTipDictionar> CautareDePeSite(string site)
        {
            List<CarteTipDictionar> cartiGasite = new List<CarteTipDictionar>();
            CarteTipDictionar c = (CarteTipDictionar)this.Clone();
            foreach (string siteCarte in c.librariiOnline)
            {
                if (string.IsNullOrEmpty(site) || siteCarte == site)
                {
                    cartiGasite.Add(c);
                }
            }

            return cartiGasite;
        }

        //2.calculare pret total din wishlist METODA DE PRELUCRARE
        public static float CalculeazaSuma(float pret)
        {
            float suma = 0;
            suma += pret;
            return suma;
        }
    }
}
