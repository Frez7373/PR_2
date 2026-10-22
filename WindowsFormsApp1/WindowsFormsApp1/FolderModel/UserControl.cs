using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FolderModel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Fill (Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
