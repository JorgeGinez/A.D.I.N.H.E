namespace ADINHE
{
    partial class DetallesdeProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesdeProyecto));
            this.MaterialesdeProyecto = new System.Windows.Forms.TabControl();
            this.DMateriales = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHerramientas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.heramientasproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadodeheramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.MaterialesdeProyecto.SuspendLayout();
            this.DMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialesdeProyecto
            // 
            this.MaterialesdeProyecto.Controls.Add(this.DMateriales);
            this.MaterialesdeProyecto.Controls.Add(this.DHerramientas);
            this.MaterialesdeProyecto.Location = new System.Drawing.Point(95, 52);
            this.MaterialesdeProyecto.Name = "MaterialesdeProyecto";
            this.MaterialesdeProyecto.SelectedIndex = 0;
            this.MaterialesdeProyecto.Size = new System.Drawing.Size(642, 344);
            this.MaterialesdeProyecto.TabIndex = 0;
            // 
            // DMateriales
            // 
            this.DMateriales.Controls.Add(this.label3);
            this.DMateriales.Controls.Add(this.dataGridView1);
            this.DMateriales.Location = new System.Drawing.Point(4, 22);
            this.DMateriales.Name = "DMateriales";
            this.DMateriales.Padding = new System.Windows.Forms.Padding(3);
            this.DMateriales.Size = new System.Drawing.Size(634, 318);
            this.DMateriales.TabIndex = 0;
            this.DMateriales.Text = "Materiales";
            this.DMateriales.UseVisualStyleBackColor = true;
            this.DMateriales.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Materiales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(109, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 59);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Material";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de material";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad de material";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DHerramientas
            // 
            this.DHerramientas.Controls.Add(this.label1);
            this.DHerramientas.Controls.Add(this.dataGridView2);
            this.DHerramientas.Location = new System.Drawing.Point(4, 22);
            this.DHerramientas.Name = "DHerramientas";
            this.DHerramientas.Padding = new System.Windows.Forms.Padding(3);
            this.DHerramientas.Size = new System.Drawing.Size(629, 334);
            this.DHerramientas.TabIndex = 1;
            this.DHerramientas.Text = "Herramientas";
            this.DHerramientas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Herramientas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heramientasproyecto,
            this.Responsables,
            this.Estadodeheramienta});
            this.dataGridView2.Location = new System.Drawing.Point(160, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 59);
            this.dataGridView2.TabIndex = 18;
            // 
            // heramientasproyecto
            // 
            this.heramientasproyecto.HeaderText = "Heramientas del proyecto";
            this.heramientasproyecto.Name = "heramientasproyecto";
            // 
            // Responsables
            // 
            this.Responsables.HeaderText = "Responsables";
            this.Responsables.Name = "Responsables";
            // 
            // Estadodeheramienta
            // 
            this.Estadodeheramienta.HeaderText = "Estado";
            this.Estadodeheramienta.Name = "Estadodeheramienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalles del proyecto";
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.Color.Red;
            this.BotonRegresar.Location = new System.Drawing.Point(684, 402);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(116, 40);
            this.BotonRegresar.TabIndex = 20;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // DetallesdeProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaterialesdeProyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetallesdeProyecto";
            this.Text = "MaterialesdeProyecto";
            this.Load += new System.EventHandler(this.DetallesdeProyecto_Load);
            this.MaterialesdeProyecto.ResumeLayout(false);
            this.DMateriales.ResumeLayout(false);
            this.DMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DHerramientas.ResumeLayout(false);
            this.DHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MaterialesdeProyecto;
        private System.Windows.Forms.TabPage DMateriales;
        private System.Windows.Forms.TabPage DHerramientas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heramientasproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadodeheramienta;
        private System.Windows.Forms.Button BotonRegresar;
    }
}