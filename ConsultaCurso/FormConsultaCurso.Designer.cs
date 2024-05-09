namespace ConsultaCurso
{
    partial class FormConsultaCurso
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
            lblNome = new Label();
            lblCurso = new Label();
            txtRA = new TextBox();
            btnConsultar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 166);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(14, 191);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(38, 15);
            lblCurso.TabIndex = 1;
            lblCurso.Text = "Curso";
            // 
            // txtRA
            // 
            txtRA.Location = new Point(12, 57);
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(156, 23);
            txtRA.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 86);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(156, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Insira o RA";
            // 
            // FormConsultaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(180, 224);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(txtRA);
            Controls.Add(lblCurso);
            Controls.Add(lblNome);
            Name = "FormConsultaCurso";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCurso;
        private TextBox txtRA;
        private Button btnConsultar;
        private Label label1;
    }
}
