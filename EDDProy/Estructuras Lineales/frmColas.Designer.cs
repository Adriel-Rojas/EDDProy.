namespace EDDemo.Estructuras_Lineales
{
    partial class frmColas
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
            this.lblCOLA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnINICIALIZAR = new System.Windows.Forms.Button();
            this.btnVACIAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnPUSH = new System.Windows.Forms.Button();
            this.txtDATO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCOLA
            // 
            this.lblCOLA.AutoSize = true;
            this.lblCOLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOLA.Location = new System.Drawing.Point(188, 344);
            this.lblCOLA.Name = "lblCOLA";
            this.lblCOLA.Size = new System.Drawing.Size(124, 25);
            this.lblCOLA.TabIndex = 22;
            this.lblCOLA.Text = "Resultados...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Recorrer o Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(667, 188);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(90, 31);
            this.btnLIMPIAR.TabIndex = 20;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // btnINICIALIZAR
            // 
            this.btnINICIALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIALIZAR.Location = new System.Drawing.Point(339, 121);
            this.btnINICIALIZAR.Name = "btnINICIALIZAR";
            this.btnINICIALIZAR.Size = new System.Drawing.Size(98, 33);
            this.btnINICIALIZAR.TabIndex = 19;
            this.btnINICIALIZAR.Text = "Inicializar";
            this.btnINICIALIZAR.UseVisualStyleBackColor = true;
            this.btnINICIALIZAR.Click += new System.EventHandler(this.btnINICIALIZAR_Click);
            // 
            // btnVACIAR
            // 
            this.btnVACIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVACIAR.Location = new System.Drawing.Point(636, 255);
            this.btnVACIAR.Name = "btnVACIAR";
            this.btnVACIAR.Size = new System.Drawing.Size(121, 33);
            this.btnVACIAR.TabIndex = 18;
            this.btnVACIAR.Text = "Esta Vacia?";
            this.btnVACIAR.UseVisualStyleBackColor = true;
            this.btnVACIAR.Click += new System.EventHandler(this.btnVACIAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.Location = new System.Drawing.Point(559, 188);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(90, 31);
            this.btnBUSCAR.TabIndex = 17;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(451, 188);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(90, 31);
            this.btnQueue.TabIndex = 16;
            this.btnQueue.Text = "Quitar";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnPUSH
            // 
            this.btnPUSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUSH.Location = new System.Drawing.Point(339, 188);
            this.btnPUSH.Name = "btnPUSH";
            this.btnPUSH.Size = new System.Drawing.Size(90, 33);
            this.btnPUSH.TabIndex = 15;
            this.btnPUSH.Text = "Agregar";
            this.btnPUSH.UseVisualStyleBackColor = true;
            this.btnPUSH.Click += new System.EventHandler(this.btnPUSH_Click);
            // 
            // txtDATO
            // 
            this.txtDATO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDATO.Location = new System.Drawing.Point(222, 197);
            this.txtDATO.Name = "txtDATO";
            this.txtDATO.Size = new System.Drawing.Size(90, 24);
            this.txtDATO.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese un valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cola";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCOLA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btnINICIALIZAR);
            this.Controls.Add(this.btnVACIAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnPUSH);
            this.Controls.Add(this.txtDATO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmColas";
            this.Text = "frmColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOLA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Button btnINICIALIZAR;
        private System.Windows.Forms.Button btnVACIAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnPUSH;
        private System.Windows.Forms.TextBox txtDATO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}