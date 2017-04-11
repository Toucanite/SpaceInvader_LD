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
        Jeu partie;
        Rectangle spriteJoueur;
        Point position;
        bool bougeGauche, bougeDroite;
        int mouvement = 10;

        public Joueur(Jeu partie)
        {
            this.partie = partie;
            Size tailleJoueur = new Size(70, 20);
            position = new Point(partie.ZoneJeu.Left, partie.ZoneJeu.Bottom - tailleJoueur.Height);
            spriteJoueur = new Rectangle(position, tailleJoueur);
        }

        public Point Position
        {
            get { return position; }
            set { 
                position = value;
                spriteJoueur = new Rectangle(position, new Size(spriteJoueur.Width, spriteJoueur.Height));
            }
        }

        public bool BougeDroite
        {
            get { return bougeDroite; }
            set { bougeDroite = value; }
        }

        public bool BougeGauche
        {
            get { return bougeGauche; }
            set { bougeGauche = value; }
        }

        public void Tire()
        {
            partie.TirJoueur.Add(new Tir(new PointF((float)(spriteJoueur.X + (spriteJoueur.Width) / 2 - 5), (float)(spriteJoueur.Y - 10)), partie.ZoneJeu));
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if (bougeGauche && ((Position.X - mouvement) >= partie.ZoneJeu.X))
            {
                Position = new Point(Position.X - mouvement, Position.Y);
            }
            if (bougeDroite && ((Position.X + mouvement) < partie.ZoneJeu.Width - mouvement))
            {
                Position = new Point(Position.X + mouvement, Position.Y);
            }


            e.Graphics.FillRectangle(Brushes.DarkOliveGreen, spriteJoueur);
            e.Graphics.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(new Point(spriteJoueur.X+(spriteJoueur.Width)/2-5,spriteJoueur.Y-10),new Size(10, 30)));
        }
    }
}
