using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regex_orn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_islem_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_islem.Text, "^\\s*$"))
            {
                MessageBox.Show("Text Kutusu Boş");
            }
            else
            {
                MessageBox.Show("Text Kutusu Boş Değil");
            }
        }
    }
}
