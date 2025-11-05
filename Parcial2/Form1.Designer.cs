namespace Parcial2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBz3 = new System.Windows.Forms.ListBox();
            this.listBz2 = new System.Windows.Forms.ListBox();
            this.listBz1 = new System.Windows.Forms.ListBox();
            this.btnImportarPaquetesPedidos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBkg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCamiones = new System.Windows.Forms.ComboBox();
            this.listBcargas = new System.Windows.Forms.ListBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBz3);
            this.groupBox1.Controls.Add(this.listBz2);
            this.groupBox1.Controls.Add(this.listBz1);
            this.groupBox1.Controls.Add(this.btnImportarPaquetesPedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depositos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zona 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zona 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zona 1";
            // 
            // listBz3
            // 
            this.listBz3.FormattingEnabled = true;
            this.listBz3.Location = new System.Drawing.Point(259, 53);
            this.listBz3.Name = "listBz3";
            this.listBz3.Size = new System.Drawing.Size(120, 95);
            this.listBz3.TabIndex = 3;
            // 
            // listBz2
            // 
            this.listBz2.FormattingEnabled = true;
            this.listBz2.Location = new System.Drawing.Point(133, 53);
            this.listBz2.Name = "listBz2";
            this.listBz2.Size = new System.Drawing.Size(120, 95);
            this.listBz2.TabIndex = 2;
            // 
            // listBz1
            // 
            this.listBz1.FormattingEnabled = true;
            this.listBz1.Location = new System.Drawing.Point(7, 53);
            this.listBz1.Name = "listBz1";
            this.listBz1.Size = new System.Drawing.Size(120, 95);
            this.listBz1.TabIndex = 1;
            // 
            // btnImportarPaquetesPedidos
            // 
            this.btnImportarPaquetesPedidos.Location = new System.Drawing.Point(385, 53);
            this.btnImportarPaquetesPedidos.Name = "btnImportarPaquetesPedidos";
            this.btnImportarPaquetesPedidos.Size = new System.Drawing.Size(98, 95);
            this.btnImportarPaquetesPedidos.TabIndex = 0;
            this.btnImportarPaquetesPedidos.Text = "Importar Paquetes Pedidos";
            this.btnImportarPaquetesPedidos.UseVisualStyleBackColor = true;
            this.btnImportarPaquetesPedidos.Click += new System.EventHandler(this.btnImportarPaquetesPedidos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBkg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxCamiones);
            this.groupBox2.Controls.Add(this.listBcargas);
            this.groupBox2.Controls.Add(this.btnRetirar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.btnIniciar);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preparar Reparto";
            // 
            // tBkg
            // 
            this.tBkg.Location = new System.Drawing.Point(99, 142);
            this.tBkg.Name = "tBkg";
            this.tBkg.Size = new System.Drawing.Size(75, 20);
            this.tBkg.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Peso Acumulado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Carga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Camiones";
            // 
            // cBoxCamiones
            // 
            this.cBoxCamiones.FormattingEnabled = true;
            this.cBoxCamiones.Location = new System.Drawing.Point(7, 70);
            this.cBoxCamiones.Name = "cBoxCamiones";
            this.cBoxCamiones.Size = new System.Drawing.Size(167, 21);
            this.cBoxCamiones.TabIndex = 5;
            // 
            // listBcargas
            // 
            this.listBcargas.FormattingEnabled = true;
            this.listBcargas.Location = new System.Drawing.Point(180, 41);
            this.listBcargas.Name = "listBcargas";
            this.listBcargas.Size = new System.Drawing.Size(201, 134);
            this.listBcargas.TabIndex = 4;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(387, 70);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(96, 23);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(387, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(99, 100);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(7, 101);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBz3;
        private System.Windows.Forms.ListBox listBz2;
        private System.Windows.Forms.ListBox listBz1;
        private System.Windows.Forms.Button btnImportarPaquetesPedidos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCamiones;
        private System.Windows.Forms.ListBox listBcargas;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tBkg;
        private System.Windows.Forms.Label label6;
    }
}

