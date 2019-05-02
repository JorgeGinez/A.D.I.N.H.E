namespace ADINHE
{
    partial class Recepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recepcion));
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.BotonHerramientas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(453, 392);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(116, 40);
            this.BotonCerrarSesion.TabIndex = 11;
            this.BotonCerrarSesion.Text = "Cerrar Sesión";
            this.BotonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // BotonHerramientas
            // 
            this.BotonHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.BotonHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHerramientas.Location = new System.Drawing.Point(157, 121);
            this.BotonHerramientas.Name = "BotonHerramientas";
            this.BotonHerramientas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonHerramientas.Size = new System.Drawing.Size(261, 67);
            this.BotonHerramientas.TabIndex = 12;
            this.BotonHerramientas.Text = "Herramientas";
            this.BotonHerramientas.UseVisualStyleBackColor = false;
            this.BotonHerramientas.Click += new System.EventHandler(this.BotonHerramientas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Recepcion";
            // 
            // BComprar
            // 
            this.BComprar.BackColor = System.Drawing.Color.Transparent;
            this.BComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprar.Location = new System.Drawing.Point(157, 194);
            this.BComprar.Name = "BComprar";
            this.BComprar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BComprar.Size = new System.Drawing.Size(261, 67);
            this.BComprar.TabIndex = 14;
            this.BComprar.Text = "Comprar";
            this.BComprar.UseVisualStyleBackColor = false;
            // 
            // Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.BComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonHerramientas);
            this.Controls.Add(this.BotonCerrarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recepcion";
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.Recepcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.Button BotonHerramientas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BComprar;
    }
}