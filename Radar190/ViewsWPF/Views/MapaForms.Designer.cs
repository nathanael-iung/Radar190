namespace ViewsWPF.Views
{
    partial class MapaForms
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
            this.gmMapa = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gmMapa
            // 
            this.gmMapa.Bearing = 0F;
            this.gmMapa.CanDragMap = true;
            this.gmMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmMapa.GrayScaleMode = false;
            this.gmMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmMapa.LevelsKeepInMemmory = 5;
            this.gmMapa.Location = new System.Drawing.Point(12, 12);
            this.gmMapa.MarkersEnabled = true;
            this.gmMapa.MaxZoom = 2;
            this.gmMapa.MinZoom = 2;
            this.gmMapa.MouseWheelZoomEnabled = true;
            this.gmMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmMapa.Name = "gmMapa";
            this.gmMapa.NegativeMode = false;
            this.gmMapa.PolygonsEnabled = true;
            this.gmMapa.RetryLoadTile = 0;
            this.gmMapa.RoutesEnabled = true;
            this.gmMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmMapa.ShowTileGridLines = false;
            this.gmMapa.Size = new System.Drawing.Size(552, 397);
            this.gmMapa.TabIndex = 0;
            this.gmMapa.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teste";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(605, 51);
            this.txtLatitude.Multiline = true;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(489, 20);
            this.txtLatitude.TabIndex = 3;
            // 
            // MapaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 421);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmMapa);
            this.Name = "MapaForms";
            this.Text = "MapaForms";
            this.Load += new System.EventHandler(this.MapaForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmMapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLatitude;
    }
}