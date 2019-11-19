using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Passwords_gui
{
    public partial class Form2 : Form
    {
        static string FiltersDirectory = @"Saved_data\Filters";
        static string Filter;
        public Form2(String filtrName)
        {
            InitializeComponent();
            Filter = filtrName;
        }

        private void CrtFiltrButton_Click(object sender, EventArgs e)
        {
            string[] insides = FiltrInsideText.Text.Replace(" ","").Split(',');
            File.WriteAllLines($@"{FiltersDirectory}\{Filter}.txt", insides);
            MessageBox.Show("Filter created","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
    }
}
