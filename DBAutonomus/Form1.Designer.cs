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
            label1 = new Label();
            txtControl = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPaterno = new TextBox();
            label3 = new Label();
            txtMaterno = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(206, 124);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(115, 43);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Agregar";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Control";
            // 
            // txtControl
            // 
            txtControl.Location = new Point(12, 37);
            txtControl.Name = "txtControl";
            txtControl.Size = new Size(150, 31);
            txtControl.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(12, 186);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(150, 31);
            txtPaterno.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 5;
            label3.Text = "A. Paterno";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(12, 263);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(150, 31);
            txtMaterno.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 7;
            label4.Text = "A. Materno";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 313);
            Controls.Add(txtMaterno);
            Controls.Add(label4);
            Controls.Add(txtPaterno);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtControl);
            Controls.Add(label1);
            Controls.Add(btnPrueba);
            Name = "Form1";
            Text = "Oracle Autonomus Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrueba;
        private Label label1;
        private TextBox txtControl;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPaterno;
        private Label label3;
        private TextBox txtMaterno;
        private Label label4;
    }
}
