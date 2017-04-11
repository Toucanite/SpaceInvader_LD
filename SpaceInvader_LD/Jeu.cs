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
    class Jeu
    {
        const int MARGE = 50;
        Rectangle zoneJeu;
        Joueur joueur;
        Ennemi e1 = new Ennemi();

        public Jeu(Size tailleForm)
        {
            zoneJeu = new Rectangle(new Point(MARGE,MARGE), new Size(tailleForm.Width-2*MARGE, tailleForm.Height-2*MARGE));
            joueur = new Joueur(zoneJeu);
        }

        public Rectangle ZoneJeu
        {
            get { return zoneJeu; }
            set { zoneJeu = value; }
        }

        internal Joueur Joueur
        {
            get { return joueur; }
            set { joueur = value; }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, zoneJeu);
            joueur.Paint(sender,e);
        }
    }
}
