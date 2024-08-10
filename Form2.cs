using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Dictionar_Traduceri
{
    public partial class Form2 : Form
    {
        //BINDING INTRE DATE SI CONTROALE
        public Form2(List<Cuvant> list)
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            bindingNavigator1.BindingSource = bs;
            tbOriginal.DataBindings.Add(new Binding("Text", bs, "CuvantRomana", true));
            tbSensuri.DataBindings.Add(new Binding("Text", bs, "Sensuri", true));
            tbTip.DataBindings.Add(new Binding("Text", bs, "Tip", true));
            tbTraducere.DataBindings.Add(new Binding("Text", bs, "CuvantEngleza", true));
            tbSinonime.DataBindings.Add(new Binding("Text", bs, "sinonime", true));
        }

        
        
    }
}
