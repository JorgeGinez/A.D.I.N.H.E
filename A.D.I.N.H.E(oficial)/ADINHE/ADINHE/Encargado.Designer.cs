namespace ADINHE
{
    partial class Encargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encargado));
            this.BotonMaterial = new System.Windows.Forms.Button();
            this.BotonHerramienta = new System.Windows.Forms.Button();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonMaterial
            // 
            this.BotonMaterial.BackColor = System.Drawing.Color.Transparent;
            this.BotonMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMaterial.Location = new System.Drawing.Point(218, 280);
            this.BotonMaterial.Name = "BotonMaterial";
            this.BotonMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonMaterial.Size = new System.Drawing.Size(261, 67);
            this.BotonMaterial.TabIndex = 6;
            this.BotonMaterial.Text = "Material";
            this.BotonMaterial.UseVisualStyleBackColor = false;
            this.BotonMaterial.Click += new System.EventHandler(this.BotonMaterial_Click);
            // 
            // BotonHerramienta
            // 
            this.BotonHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.BotonHerramienta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHerramienta.Location = new System.Drawing.Point(218, 194);
            this.BotonHerramienta.Name = "BotonHerramienta";
            this.BotonHerramienta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotonHerramienta.Size = new System.Drawing.Size(261, 70);
            this.BotonHerramienta.TabIndex = 7;
            this.BotonHerramienta.Text = "Herramienta";
            this.BotonHerramienta.UseVisualStyleBackColor = false;
            this.BotonHerramienta.Click += new System.EventHandler(this.BotonHerramienta_Click);
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(571, 395);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(116, 40);
            this.BotonCerrarSesion.TabIndex = 10;
            this.BotonCerrarSesion.Text = "Cerrar Sesión";
            this.BotonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Encargado";
            // 
            // Encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCerrarSesion);
            this.Controls.Add(this.BotonHerramienta);
            this.Controls.Add(this.BotonMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encargado";
            this.Text = "Encargado";
            this.Load += new System.EventHandler(this.Encargado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonMaterial;
        private System.Windows.Forms.Button BotonHerramienta;
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.Label label1;
    }
}