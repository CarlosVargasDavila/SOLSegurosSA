namespace FrmSegurosSA
{
    partial class FrmMainSeguros
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
            panel1 = new Panel();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtSalario = new TextBox();
            txtCedula = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabla = new DataGridView();
            colCedula = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            colSalario = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(rbMujer);
            panel1.Controls.Add(rbHombre);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(16, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 211);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(179, 176);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(69, 25);
            rbMujer.TabIndex = 12;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(54, 176);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(85, 25);
            rbHombre.TabIndex = 11;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 29);
            txtNombre.TabIndex = 10;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(67, 84);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(127, 29);
            txtEdad.TabIndex = 9;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(67, 128);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(127, 29);
            txtSalario.TabIndex = 7;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(67, 5);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(127, 29);
            txtCedula.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(5, 131);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 5;
            label5.Text = "Salario";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(5, 176);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 4;
            label4.Text = "Sexo";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(4, 84);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(4, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(4, 13);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Cedula";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { colCedula, colNombre, colEdad, colSexo, colSalario });
            tabla.Location = new Point(35, 278);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(639, 150);
            tabla.TabIndex = 13;
            // 
            // colCedula
            // 
            colCedula.HeaderText = "Cedula";
            colCedula.Name = "colCedula";
            colCedula.ReadOnly = true;
            colCedula.Width = 146;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 150;
            // 
            // colEdad
            // 
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            // 
            // colSexo
            // 
            colSexo.HeaderText = "Sexo";
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            // 
            // colSalario
            // 
            colSalario.HeaderText = "Salario";
            colSalario.Name = "colSalario";
            colSalario.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(274, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 211);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Botones";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 33);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(119, 84);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 33);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(119, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 33);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(64, 143);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 33);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 23);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 33);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardad";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmMainSeguros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(tabla);
            Name = "FrmMainSeguros";
            Text = "FrmMainSeguros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCedula;
        private RadioButton rbMujer;
        private RadioButton rbHombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtSalario;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn colCedula;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colSalario;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnGuardar;
    }
}