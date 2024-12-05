
namespace EDDemo
{
    partial class frmPilas
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnINICIALIZAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDATO = new System.Windows.Forms.TextBox();
            this.lblPILA = new System.Windows.Forms.Label();
            this.btnRECORRER = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnVACIAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnPOP = new System.Windows.Forms.Button();
            this.btnPUSH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pila";
            // 
            // btnINICIALIZAR
            // 
            this.btnINICIALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIALIZAR.Location = new System.Drawing.Point(316, 37);
            this.btnINICIALIZAR.Name = "btnINICIALIZAR";
            this.btnINICIALIZAR.Size = new System.Drawing.Size(99, 33);
            this.btnINICIALIZAR.TabIndex = 9;
            this.btnINICIALIZAR.Text = "Inicializar";
            this.btnINICIALIZAR.UseVisualStyleBackColor = true;
            this.btnINICIALIZAR.Click += new System.EventHandler(this.btnINICIALIZAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese un valor";
            // 
            // txtDATO
            // 
            this.txtDATO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDATO.Location = new System.Drawing.Point(208, 116);
            this.txtDATO.Name = "txtDATO";
            this.txtDATO.Size = new System.Drawing.Size(88, 24);
            this.txtDATO.TabIndex = 14;
            // 
            // lblPILA
            // 
            this.lblPILA.AutoSize = true;
            this.lblPILA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPILA.Location = new System.Drawing.Point(218, 270);
            this.lblPILA.Name = "lblPILA";
            this.lblPILA.Size = new System.Drawing.Size(124, 25);
            this.lblPILA.TabIndex = 21;
            this.lblPILA.Text = "Resultados...";
            // 
            // btnRECORRER
            // 
            this.btnRECORRER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRECORRER.Location = new System.Drawing.Point(381, 172);
            this.btnRECORRER.Name = "btnRECORRER";
            this.btnRECORRER.Size = new System.Drawing.Size(121, 53);
            this.btnRECORRER.TabIndex = 20;
            this.btnRECORRER.Text = "Recorrer o mostrar";
            this.btnRECORRER.UseVisualStyleBackColor = true;
            this.btnRECORRER.Click += new System.EventHandler(this.btnRECORRER_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(674, 114);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(93, 29);
            this.btnLIMPIAR.TabIndex = 19;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // btnVACIAR
            // 
            this.btnVACIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVACIAR.Location = new System.Drawing.Point(595, 182);
            this.btnVACIAR.Name = "btnVACIAR";
            this.btnVACIAR.Size = new System.Drawing.Size(131, 33);
            this.btnVACIAR.TabIndex = 18;
            this.btnVACIAR.Text = "Esta Vacia?";
            this.btnVACIAR.UseVisualStyleBackColor = true;
            this.btnVACIAR.Click += new System.EventHandler(this.btnVACIAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.Location = new System.Drawing.Point(564, 114);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 29);
            this.btnBUSCAR.TabIndex = 17;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnPOP
            // 
            this.btnPOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOP.Location = new System.Drawing.Point(454, 114);
            this.btnPOP.Name = "btnPOP";
            this.btnPOP.Size = new System.Drawing.Size(93, 31);
            this.btnPOP.TabIndex = 16;
            this.btnPOP.Text = "Quitar";
            this.btnPOP.UseVisualStyleBackColor = true;
            this.btnPOP.Click += new System.EventHandler(this.btnPOP_Click);
            // 
            // btnPUSH
            // 
            this.btnPUSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUSH.Location = new System.Drawing.Point(345, 114);
            this.btnPUSH.Name = "btnPUSH";
            this.btnPUSH.Size = new System.Drawing.Size(93, 31);
            this.btnPUSH.TabIndex = 15;
            this.btnPUSH.Text = "Agregar";
            this.btnPUSH.UseVisualStyleBackColor = true;
            this.btnPUSH.Click += new System.EventHandler(this.btnPUSH_Click_1);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 414);
            this.Controls.Add(this.lblPILA);
            this.Controls.Add(this.btnRECORRER);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btnVACIAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnPOP);
            this.Controls.Add(this.btnPUSH);
            this.Controls.Add(this.txtDATO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnINICIALIZAR);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnINICIALIZAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDATO;
        private System.Windows.Forms.Label lblPILA;
        private System.Windows.Forms.Button btnRECORRER;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Button btnVACIAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnPOP;
        private System.Windows.Forms.Button btnPUSH;
    }
}