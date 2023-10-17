using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
         Double tutar;
         tutar=Convert.ToDouble(textBox1.Text);
         if(rb2Taksit.Checked==true|| rb3Taksit.Checked == true)
         {
           tutar = tutar + (tutar * 0.05);
         }
         if(rb4Taksit.Checked!=true|| rb5Taksit.Checked == true)
         {
           tutar = tutar + (tutar * 0.10);
         }
          MessageBox.Show("Ödenecek toplam tutar :" + tutar.ToString() + "TL");
        }    
    }
}
