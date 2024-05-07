namespace DBAutonomus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrueba = new Button();
            textNombre = new TextBox();
            textAPaterno = new TextBox();
            textAMaterno = new TextBox();
            textNControl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tablaAlumnos = new DataGridView();
            butAgregar = new Button();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            apPaterno = new DataGridViewTextBoxColumn();
            apMaterno = new DataGridViewTextBoxColumn();
            noControl = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tablaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(312, 242);
            btnPrueba.Margin = new Padding(2);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(80, 26);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Probar";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(110, 12);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 1;
            // 
            // textAPaterno
            // 
            textAPaterno.Location = new Point(110, 53);
            textAPaterno.Name = "textAPaterno";
            textAPaterno.Size = new Size(100, 23);
            textAPaterno.TabIndex = 2;
            // 
            // textAMaterno
            // 
            textAMaterno.Location = new Point(110, 99);
            textAMaterno.Name = "textAMaterno";
            textAMaterno.Size = new Size(100, 23);
            textAMaterno.TabIndex = 3;
            // 
            // textNControl
            // 
            textNControl.Location = new Point(110, 141);
            textNControl.Name = "textNControl";
            textNControl.Size = new Size(100, 23);
            textNControl.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "ap paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 107);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "ap materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "no control";
            // 
            // tablaAlumnos
            // 
            tablaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaAlumnos.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, apPaterno, apMaterno, noControl });
            tablaAlumnos.Location = new Point(244, 12);
            tablaAlumnos.Name = "tablaAlumnos";
            tablaAlumnos.Size = new Size(544, 150);
            tablaAlumnos.TabIndex = 9;
            tablaAlumnos.CellContentClick += dataGridViewAlumnos_CellContentClick;
            // 
            // butAgregar
            // 
            butAgregar.Location = new Point(55, 216);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(75, 23);
            butAgregar.TabIndex = 10;
            butAgregar.Text = "Agregar";
            butAgregar.UseVisualStyleBackColor = true;
            butAgregar.Click += butAgregar_Click;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // apPaterno
            // 
            apPaterno.HeaderText = "Paterno";
            apPaterno.Name = "apPaterno";
            // 
            // apMaterno
            // 
            apMaterno.HeaderText = "Materno";
            apMaterno.Name = "apMaterno";
            // 
            // noControl
            // 
            noControl.HeaderText = "Control";
            noControl.Name = "noControl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 279);
            Controls.Add(butAgregar);
            Controls.Add(tablaAlumnos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNControl);
            Controls.Add(textAMaterno);
            Controls.Add(textAPaterno);
            Controls.Add(textNombre);
            Controls.Add(btnPrueba);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tablaAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrueba;
        private TextBox textNombre;
        private TextBox textAPaterno;
        private TextBox textAMaterno;
        private TextBox textNControl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView tablaAlumnos;
        private Button butAgregar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn apPaterno;
        private DataGridViewTextBoxColumn apMaterno;
        private DataGridViewTextBoxColumn noControl;
    }
}
