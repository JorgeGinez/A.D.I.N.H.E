namespace ADINHE
{
    partial class Almacenista
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
            this.BComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BAlmacen = new System.Windows.Forms.Button();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BComprar
            // 
            this.BComprar.BackColor = System.Drawing.Color.Transparent;
            this.BComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprar.Location = new System.Drawing.Point(113, 220);
            this.BComprar.Name = "BComprar";
            this.BComprar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BComprar.Size = new System.Drawing.Size(261, 67);
            this.BComprar.TabIndex = 18;
            this.BComprar.Text = "Comprar";
            this.BComprar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Almacen";
            // 
            // BAlmacen
            // 
            this.BAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAlmacen.Location = new System.Drawing.Point(113, 147);
            this.BAlmacen.Name = "BAlmacen";
            this.BAlmacen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BAlmacen.Size = new System.Drawing.Size(261, 67);
            this.BAlmacen.TabIndex = 16;
            this.BAlmacen.Text = "Almacen";
            this.BAlmacen.UseVisualStyleBackColor = false;
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(409, 418);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(116, 40);
            this.BotonCerrarSesion.TabIndex = 15;
            this.BotonCerrarSesion.Text = "Cerrar Sesión";
            this.BotonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Almacenista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 463);
            this.Controls.Add(this.BComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAlmacen);
            this.Controls.Add(this.BotonCerrarSesion);
            this.Name = "Almacenista";
            this.Text = "Almacenista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAlmacen;
        private System.Windows.Forms.Button BotonCerrarSesion;
    }
}