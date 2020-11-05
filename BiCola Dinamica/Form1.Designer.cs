namespace BiCola_Dinamica
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnDesencolarDer = new System.Windows.Forms.Button();
            this.btnEncolarDer = new System.Windows.Forms.Button();
            this.btnEncolarIzq = new System.Windows.Forms.Button();
            this.btnDesencolarIzq = new System.Windows.Forms.Button();
            this.btnFrente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(293, 26);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(28, 13);
            this.lblCola.TabIndex = 1;
            this.lblCola.Text = "Cola";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(61, 19);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(30, 20);
            this.txtDato.TabIndex = 2;
            // 
            // btnDesencolarDer
            // 
            this.btnDesencolarDer.Location = new System.Drawing.Point(427, 58);
            this.btnDesencolarDer.Name = "btnDesencolarDer";
            this.btnDesencolarDer.Size = new System.Drawing.Size(111, 23);
            this.btnDesencolarDer.TabIndex = 3;
            this.btnDesencolarDer.Text = "Desencolar Der";
            this.btnDesencolarDer.UseVisualStyleBackColor = true;
            this.btnDesencolarDer.Click += new System.EventHandler(this.btnDesencolarDer_Click);
            // 
            // btnEncolarDer
            // 
            this.btnEncolarDer.Location = new System.Drawing.Point(182, 17);
            this.btnEncolarDer.Name = "btnEncolarDer";
            this.btnEncolarDer.Size = new System.Drawing.Size(75, 23);
            this.btnEncolarDer.TabIndex = 4;
            this.btnEncolarDer.Text = "Encolar Der";
            this.btnEncolarDer.UseVisualStyleBackColor = true;
            this.btnEncolarDer.Click += new System.EventHandler(this.btnEncolarDer_Click);
            // 
            // btnEncolarIzq
            // 
            this.btnEncolarIzq.Location = new System.Drawing.Point(101, 17);
            this.btnEncolarIzq.Name = "btnEncolarIzq";
            this.btnEncolarIzq.Size = new System.Drawing.Size(75, 23);
            this.btnEncolarIzq.TabIndex = 5;
            this.btnEncolarIzq.Text = "Encolar Izq";
            this.btnEncolarIzq.UseVisualStyleBackColor = true;
            this.btnEncolarIzq.Click += new System.EventHandler(this.btnEncolarIzq_Click);
            // 
            // btnDesencolarIzq
            // 
            this.btnDesencolarIzq.Location = new System.Drawing.Point(296, 58);
            this.btnDesencolarIzq.Name = "btnDesencolarIzq";
            this.btnDesencolarIzq.Size = new System.Drawing.Size(111, 23);
            this.btnDesencolarIzq.TabIndex = 6;
            this.btnDesencolarIzq.Text = "Desencolar Izq";
            this.btnDesencolarIzq.UseVisualStyleBackColor = true;
            this.btnDesencolarIzq.Click += new System.EventHandler(this.btnDesencolarIzq_Click);
            // 
            // btnFrente
            // 
            this.btnFrente.Location = new System.Drawing.Point(384, 87);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new System.Drawing.Size(75, 23);
            this.btnFrente.TabIndex = 7;
            this.btnFrente.Text = "Frente";
            this.btnFrente.UseVisualStyleBackColor = true;
            this.btnFrente.Click += new System.EventHandler(this.btnFrente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(8, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFrente);
            this.groupBox1.Controls.Add(this.lblCola);
            this.groupBox1.Controls.Add(this.btnDesencolarIzq);
            this.groupBox1.Controls.Add(this.btnDesencolarDer);
            this.groupBox1.Controls.Add(this.btnEncolarIzq);
            this.groupBox1.Controls.Add(this.btnEncolarDer);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(89, 60);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(299, 16);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(185, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 190);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnDesencolarDer;
        private System.Windows.Forms.Button btnEncolarDer;
        private System.Windows.Forms.Button btnEncolarIzq;
        private System.Windows.Forms.Button btnDesencolarIzq;
        private System.Windows.Forms.Button btnFrente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}

