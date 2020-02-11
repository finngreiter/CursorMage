using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorMage
{
    public partial class CMage : Form
    {
        public CMage()
        {
            InitializeComponent();
        }

        private void CMage_Load(object sender, EventArgs e)
        {
            xNum.Maximum = Screen.PrimaryScreen.Bounds.Width;
            yNum.Maximum = Screen.PrimaryScreen.Bounds.Height;
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Convert.ToInt32(xNum.Value), Convert.ToInt32(yNum.Value));
        }
    }
}
