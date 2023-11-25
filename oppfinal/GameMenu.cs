using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppfinal
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
            Application.OpenForms["Form1"].Hide();
            
        }
        //setting nut trong menu
        //nut start
        private void btnstart_MouseHover(object sender, EventArgs e)
        {
            btnstart.Image = Properties.Resources.start_hover;
        }

        private void btnstart_MouseLeave_1(object sender, EventArgs e)
        {
            btnstart.Image = Properties.Resources.start_normal;
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            lvl1 Lv1 = new lvl1();
            Lv1.ShowDialog();
        }
        //nut option
        private void btnoption_MouseHover(object sender, EventArgs e)
        {
            btnoption.Image = Properties.Resources.option_hover;
        }

        private void btnoption_MouseLeave(object sender, EventArgs e)
        {
            btnoption.Image = Properties.Resources.option_normal;
        }
        private void btnoption_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }
        //nut exit
        private void btnexit_MouseHover(object sender, EventArgs e)
        {
            btnexit.Image = Properties.Resources.exit_hover;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.Image = Properties.Resources.exit_normal;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
