namespace CapaPresentacion1
{
    partial class FrmTiposCompetencias
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 399);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTiposCompetencias";
            this.Text = "Tipos de competencia";
            this.Load += new System.EventHandler(this.FrmTiposCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoCompetencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoCompetencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}