namespace Parcial2
{
    partial class RegistroNotasForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnGuardarNotas = new System.Windows.Forms.Button();
            this.txtGit = new System.Windows.Forms.MaskedTextBox();
            this.txtParticipación = new System.Windows.Forms.MaskedTextBox();
            this.txtTalleres = new System.Windows.Forms.MaskedTextBox();
            this.txtProyecto = new System.Windows.Forms.MaskedTextBox();
            this.txtParcial2 = new System.Windows.Forms.MaskedTextBox();
            this.txtParcial1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtCódigo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCódigo);
            this.groupBox1.Controls.Add(this.btnGuardarNotas);
            this.groupBox1.Controls.Add(this.txtGit);
            this.groupBox1.Controls.Add(this.txtParticipación);
            this.groupBox1.Controls.Add(this.txtTalleres);
            this.groupBox1.Controls.Add(this.txtProyecto);
            this.groupBox1.Controls.Add(this.txtParcial2);
            this.groupBox1.Controls.Add(this.txtParcial1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(120, 441);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(86, 16);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(100, 20);
            this.txtCódigo.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Location = new System.Drawing.Point(20, 16);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(40, 13);
            this.lblCódigo.TabIndex = 12;
            this.lblCódigo.Text = "Código";
            // 
            // btnGuardarNotas
            // 
            this.btnGuardarNotas.Location = new System.Drawing.Point(6, 441);
            this.btnGuardarNotas.Name = "btnGuardarNotas";
            this.btnGuardarNotas.Size = new System.Drawing.Size(84, 23);
            this.btnGuardarNotas.TabIndex = 1;
            this.btnGuardarNotas.Text = "Guardar Notas";
            this.btnGuardarNotas.UseVisualStyleBackColor = true;
            this.btnGuardarNotas.Click += new System.EventHandler(this.btnGuardarNotas_Click);
            // 
            // txtGit
            // 
            this.txtGit.Location = new System.Drawing.Point(86, 387);
            this.txtGit.Mask = "99";
            this.txtGit.Name = "txtGit";
            this.txtGit.Size = new System.Drawing.Size(100, 20);
            this.txtGit.TabIndex = 11;
            this.txtGit.ValidatingType = typeof(int);
            // 
            // txtParticipación
            // 
            this.txtParticipación.Location = new System.Drawing.Point(86, 333);
            this.txtParticipación.Mask = "99";
            this.txtParticipación.Name = "txtParticipación";
            this.txtParticipación.Size = new System.Drawing.Size(100, 20);
            this.txtParticipación.TabIndex = 10;
            this.txtParticipación.ValidatingType = typeof(int);
            // 
            // txtTalleres
            // 
            this.txtTalleres.Location = new System.Drawing.Point(86, 279);
            this.txtTalleres.Mask = "99";
            this.txtTalleres.Name = "txtTalleres";
            this.txtTalleres.Size = new System.Drawing.Size(100, 20);
            this.txtTalleres.TabIndex = 9;
            this.txtTalleres.ValidatingType = typeof(int);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(86, 225);
            this.txtProyecto.Mask = "99";
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtProyecto.TabIndex = 8;
            this.txtProyecto.ValidatingType = typeof(int);
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(86, 171);
            this.txtParcial2.Mask = "99";
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(100, 20);
            this.txtParcial2.TabIndex = 7;
            this.txtParcial2.ValidatingType = typeof(int);
            // 
            // txtParcial1
            // 
            this.txtParcial1.Location = new System.Drawing.Point(86, 117);
            this.txtParcial1.Mask = "99";
            this.txtParcial1.Name = "txtParcial1";
            this.txtParcial1.Size = new System.Drawing.Size(100, 20);
            this.txtParcial1.TabIndex = 6;
            this.txtParcial1.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Curso de Git";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Participación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Talleres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcial 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parcial 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 423);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(632, 463);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio";
            // 
            // RegistroNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 494);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroNotasForm";
            this.Text = "RegistroNotasForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtGit;
        public System.Windows.Forms.MaskedTextBox txtParticipación;
        public System.Windows.Forms.MaskedTextBox txtTalleres;
        public System.Windows.Forms.MaskedTextBox txtProyecto;
        public System.Windows.Forms.MaskedTextBox txtParcial2;
        public System.Windows.Forms.MaskedTextBox txtParcial1;
        public System.Windows.Forms.Button btnGuardarNotas;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPromedio;
    }
}