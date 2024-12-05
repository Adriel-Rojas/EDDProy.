namespace EDDemo.Metodos_de_ordenamiento_y_busqueda
{
    partial class frmBusquedaBinaria
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
            this.label5 = new System.Windows.Forms.Label();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Datos ingresados:";
            // 
            // lstResultado
            // 
            this.lstResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 18;
            this.lstResultado.Location = new System.Drawing.Point(523, 112);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(194, 238);
            this.lstResultado.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Busqueda Binaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingresar Valores";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(305, 180);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(318, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(318, 217);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // frmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "frmBusquedaBinaria";
            this.Text = "Busqueda Binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
    }
}