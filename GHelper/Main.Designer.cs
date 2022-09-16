namespace GHelper
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainpanel = new System.Windows.Forms.Panel();
            this.midiplayersw = new System.Windows.Forms.Button();
            this.patchersw = new System.Windows.Forms.Button();
            this.optionsw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.optionsw)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(-1, 21);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(802, 429);
            this.mainpanel.TabIndex = 3;
            // 
            // midiplayersw
            // 
            this.midiplayersw.Location = new System.Drawing.Point(73, -1);
            this.midiplayersw.Name = "midiplayersw";
            this.midiplayersw.Size = new System.Drawing.Size(75, 23);
            this.midiplayersw.TabIndex = 3;
            this.midiplayersw.Text = "midi player";
            this.midiplayersw.UseVisualStyleBackColor = true;
            this.midiplayersw.Click += new System.EventHandler(this.midiplayersw_Click);
            // 
            // patchersw
            // 
            this.patchersw.Location = new System.Drawing.Point(-1, -1);
            this.patchersw.Name = "patchersw";
            this.patchersw.Size = new System.Drawing.Size(75, 23);
            this.patchersw.TabIndex = 2;
            this.patchersw.Text = "patcher";
            this.patchersw.UseVisualStyleBackColor = true;
            this.patchersw.Click += new System.EventHandler(this.patchersw_Click);
            // 
            // optionsw
            // 
            this.optionsw.Image = global::GHelper.Properties.Resources.option;
            this.optionsw.Location = new System.Drawing.Point(777, -1);
            this.optionsw.Name = "optionsw";
            this.optionsw.Size = new System.Drawing.Size(23, 23);
            this.optionsw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optionsw.TabIndex = 4;
            this.optionsw.TabStop = false;
            this.optionsw.Click += new System.EventHandler(this.optionsw_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionsw);
            this.Controls.Add(this.midiplayersw);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.patchersw);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.optionsw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button midiplayersw;
        private System.Windows.Forms.Button patchersw;
        private System.Windows.Forms.PictureBox optionsw;
    }
}