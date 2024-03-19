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
            this.label1 = new System.Windows.Forms.Label();
            this.axisSelector = new System.Windows.Forms.ComboBox();
            this.labelAxis = new System.Windows.Forms.Label();
            this.bttnMin = new System.Windows.Forms.Button();
            this.bttnMax = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regiserCoordinates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnStart
            // 
            this.bttnStart.BackColor = System.Drawing.Color.Red;
            this.bttnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bttnStart.Location = new System.Drawing.Point(320, 94);
            this.bttnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(188, 105);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Text = "OFF";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // axisSelector
            // 
            this.axisSelector.Enabled = false;
            this.axisSelector.FormattingEnabled = true;
            this.axisSelector.Items.AddRange(new object[] {
            "Eje X",
            "Eje Y",
            "Eje Z",
            "Eje U"});
            this.axisSelector.Location = new System.Drawing.Point(16, 218);
            this.axisSelector.Margin = new System.Windows.Forms.Padding(4);
            this.axisSelector.Name = "axisSelector";
            this.axisSelector.Size = new System.Drawing.Size(489, 24);
            this.axisSelector.TabIndex = 2;
            this.axisSelector.Text = "Select an axis";
            this.axisSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAxis.Location = new System.Drawing.Point(259, 273);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(155, 25);
            this.labelAxis.TabIndex = 3;
            this.labelAxis.Text = "No axis selected";
            // 
            // bttnMin
            // 
            this.bttnMin.Enabled = false;
            this.bttnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnMin.Location = new System.Drawing.Point(16, 262);
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
            this.bttnMax.Location = new System.Drawing.Point(139, 262);
            this.bttnMax.Name = "bttnMax";
            this.bttnMax.Size = new System.Drawing.Size(114, 47);
            this.bttnMax.TabIndex = 5;
            this.bttnMax.Text = "Max";
            this.bttnMax.UseVisualStyleBackColor = true;
            this.bttnMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnMax_MouseDown);
            this.bttnMax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnMax_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // regiserCoordinates
            // 
            this.regiserCoordinates.Enabled = false;
            this.regiserCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.regiserCoordinates.Location = new System.Drawing.Point(16, 437);
            this.regiserCoordinates.Name = "regiserCoordinates";
            this.regiserCoordinates.Size = new System.Drawing.Size(492, 47);
            this.regiserCoordinates.TabIndex = 8;
            this.regiserCoordinates.Text = "Register coordinates";
            this.regiserCoordinates.UseVisualStyleBackColor = true;
            this.regiserCoordinates.Click += new System.EventHandler(this.regiserCoordinates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 846);
            this.Controls.Add(this.regiserCoordinates);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttnMax);
            this.Controls.Add(this.bttnMin);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.axisSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox axisSelector;
        private System.Windows.Forms.Label labelAxis;
        private System.Windows.Forms.Button bttnMin;
        private System.Windows.Forms.Button bttnMax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button regiserCoordinates;
    }
}

