
namespace ProyectoFinalGasolineras
{
    partial class EstadisticasForm
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
            this.listViewEstadisticas = new System.Windows.Forms.ListView();
            this.listBoxEstadisticas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listViewEstadisticas
            // 
            this.listViewEstadisticas.HideSelection = false;
            this.listViewEstadisticas.Location = new System.Drawing.Point(-1, 1);
            this.listViewEstadisticas.Name = "listViewEstadisticas";
            this.listViewEstadisticas.Size = new System.Drawing.Size(202, 98);
            this.listViewEstadisticas.TabIndex = 0;
            this.listViewEstadisticas.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxEstadisticas
            // 
            this.listBoxEstadisticas.FormattingEnabled = true;
            this.listBoxEstadisticas.Location = new System.Drawing.Point(241, 12);
            this.listBoxEstadisticas.Name = "listBoxEstadisticas";
            this.listBoxEstadisticas.Size = new System.Drawing.Size(547, 420);
            this.listBoxEstadisticas.TabIndex = 1;
            // 
            // EstadisticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEstadisticas);
            this.Controls.Add(this.listViewEstadisticas);
            this.Name = "EstadisticasForm";
            this.Text = "EstadisticasForm";
            this.Load += new System.EventHandler(this.EstadisticasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEstadisticas;
        private System.Windows.Forms.ListBox listBoxEstadisticas;
    }
}