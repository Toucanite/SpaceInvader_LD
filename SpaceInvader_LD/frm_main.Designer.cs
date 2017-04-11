namespace SpaceInvader_LD
{
    partial class frm_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrInvalidate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrInvalidate
            // 
            this.tmrInvalidate.Enabled = true;
            this.tmrInvalidate.Interval = 24;
            this.tmrInvalidate.Tick += new System.EventHandler(this.tmrInvalidate_Tick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 658);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "SpaceInvader";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrInvalidate;
    }
}

