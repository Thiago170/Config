
namespace proyectopantallaconfig
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
            this.components = new System.ComponentModel.Container();
            this.trckBrVolumen = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trackbrbrillo = new System.Windows.Forms.TrackBar();
            this.Radiobtnaudio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxsountrack = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbrbrillo)).BeginInit();
            this.SuspendLayout();
            // 
            // trckBrVolumen
            // 
            this.trckBrVolumen.Location = new System.Drawing.Point(84, 184);
            this.trckBrVolumen.Maximum = 100;
            this.trckBrVolumen.Name = "trckBrVolumen";
            this.trckBrVolumen.Size = new System.Drawing.Size(141, 45);
            this.trckBrVolumen.TabIndex = 0;
            this.trckBrVolumen.Scroll += new System.EventHandler(this.trckBrVolumen_Scroll);
            // 
            // trackbrbrillo
            // 
            this.trackbrbrillo.Location = new System.Drawing.Point(489, 184);
            this.trackbrbrillo.Name = "trackbrbrillo";
            this.trackbrbrillo.Size = new System.Drawing.Size(141, 45);
            this.trackbrbrillo.TabIndex = 1;
            this.trackbrbrillo.Scroll += new System.EventHandler(this.trackbrbrillo_Scroll);
            // 
            // Radiobtnaudio
            // 
            this.Radiobtnaudio.AutoSize = true;
            this.Radiobtnaudio.Location = new System.Drawing.Point(197, 131);
            this.Radiobtnaudio.Name = "Radiobtnaudio";
            this.Radiobtnaudio.Size = new System.Drawing.Size(14, 13);
            this.Radiobtnaudio.TabIndex = 2;
            this.Radiobtnaudio.TabStop = true;
            this.Radiobtnaudio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Audio descriptivo:";
            // 
            // cmbbxsountrack
            // 
            this.cmbbxsountrack.AutoCompleteCustomSource.AddRange(new string[] {
            "Alarma de Iphone"});
            this.cmbbxsountrack.FormattingEnabled = true;
            this.cmbbxsountrack.Location = new System.Drawing.Point(103, 75);
            this.cmbbxsountrack.Name = "cmbbxsountrack";
            this.cmbbxsountrack.Size = new System.Drawing.Size(121, 21);
            this.cmbbxsountrack.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbxsountrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Radiobtnaudio);
            this.Controls.Add(this.trackbrbrillo);
            this.Controls.Add(this.trckBrVolumen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckBrVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbrbrillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trckBrVolumen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar trackbrbrillo;
        private System.Windows.Forms.RadioButton Radiobtnaudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxsountrack;
    }
}

