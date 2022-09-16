namespace GHelper.panels
{
    partial class optionPanel
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.getPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // getPath
            // 
            this.getPath.Enabled = false;
            this.getPath.Location = new System.Drawing.Point(3, 3);
            this.getPath.Name = "getPath";
            this.getPath.Size = new System.Drawing.Size(75, 20);
            this.getPath.TabIndex = 0;
            this.getPath.Text = "GmodFolder";
            this.getPath.UseVisualStyleBackColor = true;
            this.getPath.Click += new System.EventHandler(this.getPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(84, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(715, 20);
            this.txtPath.TabIndex = 1;
            // 
            // optionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.getPath);
            this.Name = "optionPanel";
            this.Size = new System.Drawing.Size(802, 429);
            this.Load += new System.EventHandler(this.optionPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button getPath;
        private System.Windows.Forms.TextBox txtPath;
    }
}
