namespace App_de_gatos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSolicitar = new Button();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtSalud = new TextBox();
            txtRaza = new TextBox();
            txtSexo = new TextBox();
            cmbGatos = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(478, 62);
            label1.Name = "label1";
            label1.Size = new Size(206, 24);
            label1.TabIndex = 0;
            label1.Text = "Adopción de gatitos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 135);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 202);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 266);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Raza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 411);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Salud:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 336);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Sexo";
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(451, 436);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(197, 119);
            btnSolicitar.TabIndex = 6;
            btnSolicitar.Text = "Solicitar Adopción";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(180, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(180, 202);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 9;
            // 
            // txtSalud
            // 
            txtSalud.Location = new Point(173, 408);
            txtSalud.Name = "txtSalud";
            txtSalud.Size = new Size(132, 27);
            txtSalud.TabIndex = 10;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(180, 263);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(125, 27);
            txtRaza.TabIndex = 11;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(180, 336);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(125, 27);
            txtSexo.TabIndex = 12;
            // 
            // cmbGatos
            // 
            cmbGatos.FormattingEnabled = true;
            cmbGatos.Items.AddRange(new object[] { "Siames", "Angoro", "Bengalí", "Maine Coon", "Gato Chino", "Ragdoll", "Garfield", "Gato común", "Rayado" });
            cmbGatos.Location = new Point(728, 183);
            cmbGatos.Name = "cmbGatos";
            cmbGatos.Size = new Size(151, 28);
            cmbGatos.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(728, 135);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 14;
            label7.Text = "Gatos disponibles:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fbc50e3ffcbf38b7cd60ea4a8e829b63;
            ClientSize = new Size(1069, 688);
            Controls.Add(label7);
            Controls.Add(cmbGatos);
            Controls.Add(txtSexo);
            Controls.Add(txtRaza);
            Controls.Add(txtSalud);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(btnSolicitar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSolicitar;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtSalud;
        private TextBox txtRaza;
        private TextBox txtSexo;
        private ComboBox cmbGatos;
        private Label label7;
    }
}
