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
    class Joueur
    {
        Rectangle spriteJoueur;
        Point position;

        public Joueur(Rectangle zoneJeu)
        {
            Size tailleJoueur = new Size(70, 20);
            position = new Point(zoneJeu.Left, zoneJeu.Bottom-tailleJoueur.Height);
            spriteJoueur = new Rectangle(position, tailleJoueur);
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkOliveGreen, spriteJoueur);
            e.Graphics.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(new Point(spriteJoueur.X+(spriteJoueur.Width)/2-5,spriteJoueur.Y-10),new Size(10, 30)));
        }
    }
}
