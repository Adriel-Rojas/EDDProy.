namespace EDDemo.Metodos_de_ordenamiento_y_busqueda
{
    partial class frmBusquedaHASH
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
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtClaveBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ltsResultado = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(249, 359);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(100, 47);
            this.btnArchivo.TabIndex = 0;
            this.btnArchivo.Text = "Cargar Archivos";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(261, 187);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(261, 297);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(249, 94);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 22);
            this.txtClave.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(249, 149);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 4;
            // 
            // txtClaveBuscar
            // 
            this.txtClaveBuscar.Location = new System.Drawing.Point(249, 259);
            this.txtClaveBuscar.Name = "txtClaveBuscar";
            this.txtClaveBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtClaveBuscar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar Claves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar claves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingresar Valores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Busqueda HASH";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ltsResultado
            // 
            this.ltsResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltsResultado.FormattingEnabled = true;
            this.ltsResultado.ItemHeight = 20;
            this.ltsResultado.Location = new System.Drawing.Point(500, 94);
            this.ltsResultado.Name = "ltsResultado";
            this.ltsResultado.Size = new System.Drawing.Size(132, 84);
            this.ltsResultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datos ingresados:";
            // 
            // frmBusquedaHASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ltsResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveBuscar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnArchivo);
            this.Name = "frmBusquedaHASH";
            this.Text = "Busqueda HASH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtClaveBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltsResultado;
        private System.Windows.Forms.Label label5;
    }
}