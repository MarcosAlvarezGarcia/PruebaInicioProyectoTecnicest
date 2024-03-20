namespace PruebaInicioProyectoTecnicest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnStart = new System.Windows.Forms.Button();
            this.axisSelector = new System.Windows.Forms.ComboBox();
            this.labelAxis = new System.Windows.Forms.Label();
            this.bttnMin = new System.Windows.Forms.Button();
            this.bttnMax = new System.Windows.Forms.Button();
            this.axisCoordinate = new System.Windows.Forms.TextBox();
            this.regiserCoordinates = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.coordinates = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coordListBox = new System.Windows.Forms.ListBox();
            this.searchedCoordsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnStart
            // 
            this.bttnStart.BackColor = System.Drawing.Color.Red;
            this.bttnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bttnStart.Location = new System.Drawing.Point(323, 11);
            this.bttnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(188, 105);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Text = "OFF";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // axisSelector
            // 
            this.axisSelector.Enabled = false;
            this.axisSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.axisSelector.FormattingEnabled = true;
            this.axisSelector.Items.AddRange(new object[] {
            "Eje X",
            "Eje Y",
            "Eje Z",
            "Eje U"});
            this.axisSelector.Location = new System.Drawing.Point(19, 142);
            this.axisSelector.Margin = new System.Windows.Forms.Padding(4);
            this.axisSelector.Name = "axisSelector";
            this.axisSelector.Size = new System.Drawing.Size(489, 28);
            this.axisSelector.TabIndex = 2;
            this.axisSelector.Text = "Select an axis";
            this.axisSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAxis.Location = new System.Drawing.Point(262, 205);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(155, 25);
            this.labelAxis.TabIndex = 3;
            this.labelAxis.Text = "No axis selected";
            // 
            // bttnMin
            // 
            this.bttnMin.Enabled = false;
            this.bttnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnMin.Location = new System.Drawing.Point(19, 194);
            this.bttnMin.Name = "bttnMin";
            this.bttnMin.Size = new System.Drawing.Size(114, 47);
            this.bttnMin.TabIndex = 4;
            this.bttnMin.Text = "Min";
            this.bttnMin.UseVisualStyleBackColor = true;
            this.bttnMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnMin_MouseDown);
            this.bttnMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnMin_MouseUp);
            // 
            // bttnMax
            // 
            this.bttnMax.Enabled = false;
            this.bttnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnMax.Location = new System.Drawing.Point(142, 194);
            this.bttnMax.Name = "bttnMax";
            this.bttnMax.Size = new System.Drawing.Size(114, 47);
            this.bttnMax.TabIndex = 5;
            this.bttnMax.Text = "Max";
            this.bttnMax.UseVisualStyleBackColor = true;
            this.bttnMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnMax_MouseDown);
            this.bttnMax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnMax_MouseUp);
            // 
            // axisCoordinate
            // 
            this.axisCoordinate.Location = new System.Drawing.Point(423, 205);
            this.axisCoordinate.Name = "axisCoordinate";
            this.axisCoordinate.Size = new System.Drawing.Size(85, 22);
            this.axisCoordinate.TabIndex = 7;
            this.axisCoordinate.Visible = false;
            // 
            // regiserCoordinates
            // 
            this.regiserCoordinates.Enabled = false;
            this.regiserCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.regiserCoordinates.Location = new System.Drawing.Point(19, 485);
            this.regiserCoordinates.Name = "regiserCoordinates";
            this.regiserCoordinates.Size = new System.Drawing.Size(492, 47);
            this.regiserCoordinates.TabIndex = 8;
            this.regiserCoordinates.Text = "Register coordinates";
            this.regiserCoordinates.UseVisualStyleBackColor = true;
            this.regiserCoordinates.Click += new System.EventHandler(this.regiserCoordinates_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(25, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movement speed";
            // 
            // speedBar
            // 
            this.speedBar.Enabled = false;
            this.speedBar.Location = new System.Drawing.Point(29, 300);
            this.speedBar.Maximum = 100;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(479, 56);
            this.speedBar.TabIndex = 12;
            this.speedBar.Value = 25;
            this.speedBar.ValueChanged += new System.EventHandler(this.speedBar_ValueChanged);
            // 
            // coordinates
            // 
            this.coordinates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordinates.AutoSize = true;
            this.coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coordinates.Location = new System.Drawing.Point(24, 435);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(291, 25);
            this.coordinates.TabIndex = 13;
            this.coordinates.Text = "Coordinates: X (); Y (); Z (); U ()";
            this.coordinates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Coordinates List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordListBox
            // 
            this.coordListBox.FormattingEnabled = true;
            this.coordListBox.ItemHeight = 16;
            this.coordListBox.Location = new System.Drawing.Point(19, 623);
            this.coordListBox.Name = "coordListBox";
            this.coordListBox.Size = new System.Drawing.Size(489, 132);
            this.coordListBox.TabIndex = 15;
            this.coordListBox.SelectedIndexChanged += new System.EventHandler(this.coordListBox_SelectedIndexChanged);
            // 
            // searchedCoordsLabel
            // 
            this.searchedCoordsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchedCoordsLabel.AutoSize = true;
            this.searchedCoordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchedCoordsLabel.Location = new System.Drawing.Point(25, 769);
            this.searchedCoordsLabel.Name = "searchedCoordsLabel";
            this.searchedCoordsLabel.Size = new System.Drawing.Size(376, 25);
            this.searchedCoordsLabel.TabIndex = 16;
            this.searchedCoordsLabel.Text = "Searched coordinates: X (); Y (); Z (); U ()";
            this.searchedCoordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 846);
            this.Controls.Add(this.searchedCoordsLabel);
            this.Controls.Add(this.coordListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regiserCoordinates);
            this.Controls.Add(this.axisCoordinate);
            this.Controls.Add(this.bttnMax);
            this.Controls.Add(this.bttnMin);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.axisSelector);
            this.Controls.Add(this.bttnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.ComboBox axisSelector;
        private System.Windows.Forms.Label labelAxis;
        private System.Windows.Forms.Button bttnMin;
        private System.Windows.Forms.Button bttnMax;
        private System.Windows.Forms.TextBox axisCoordinate;
        private System.Windows.Forms.Button regiserCoordinates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox coordListBox;
        private System.Windows.Forms.Label searchedCoordsLabel;
    }
}

