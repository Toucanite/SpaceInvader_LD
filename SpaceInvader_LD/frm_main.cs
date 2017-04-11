using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvader_LD
{
    public partial class frm_Main : Form
    {
        Jeu partie;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Size tailleForm = new Size((sender as Form).Width, (sender as Form).Height);
            partie = new Jeu(tailleForm);
            Invalidate();

        }

        private void frm_Main_Paint(object sender, PaintEventArgs e)
        {
            partie.Paint(sender,e);
        }
        

    }
}
