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
            this.btnMapaIndex = new System.Windows.Forms.Button();
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
            this.gmMapa.Size = new System.Drawing.Size(629, 397);
            this.gmMapa.TabIndex = 0;
            this.gmMapa.Zoom = 0D;
            // 
            // btnMapaIndex
            // 
            this.btnMapaIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMapaIndex.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapaIndex.Location = new System.Drawing.Point(216, 415);
            this.btnMapaIndex.Name = "btnMapaIndex";
            this.btnMapaIndex.Size = new System.Drawing.Size(214, 36);
            this.btnMapaIndex.TabIndex = 1;
            this.btnMapaIndex.Text = "Voltar para Index";
            this.btnMapaIndex.UseVisualStyleBackColor = false;
            this.btnMapaIndex.Click += new System.EventHandler(this.btnMapaIndex_Click);
            // 
            // MapaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 461);
            this.Controls.Add(this.btnMapaIndex);
            this.Controls.Add(this.gmMapa);
            this.Name = "MapaForms";
            this.Text = "MapaForms";
            this.Load += new System.EventHandler(this.MapaForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmMapa;
        private System.Windows.Forms.Button btnMapaIndex;
    }
}