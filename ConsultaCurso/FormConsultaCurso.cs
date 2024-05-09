using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsultaCurso
{
    public partial class FormConsultaCurso : Form
    {

        private Dictionary<string, Tuple<string, string>> alunos = new Dictionary<string, Tuple<string, string>>()
        {
            {"G089324", Tuple.Create("Luiz Oliveira", "Análise e Desenvolvimento de Sistemas")},
            {"B789012", Tuple.Create("Maria Oliveira", "Medicina")},
            {"A123456", Tuple.Create("José Oliveira", "Administração")},
        };

        public FormConsultaCurso()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string ra = txtRA.Text.Trim();

            if (alunos.ContainsKey(ra))
            {
                Tuple<string, string> aluno = alunos[ra];
                string nome = aluno.Item1;
                string curso = aluno.Item2;

                lblNome.Text = "Nome: " + nome;
                lblCurso.Text = "Curso: " + curso;
            }
            else
            {
                lblNome.Text = "";
                lblCurso.Text = "RA não encontrado.";
            }
        }
    }
}
