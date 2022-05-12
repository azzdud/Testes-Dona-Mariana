using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesDonaMariana.Forms
{
    public partial class CadastrosDisciplinasForms : Form
    {
        public CadastrosDisciplinasForms()
        {
            InitializeComponent();
        }

        string nome, numero;

        private void buttonVoltarCadastroDisciplinas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrarNovoCadastroDisciplinas_Click(object sender, EventArgs e)
        {
            if (textBoxNomeDisciplina != null && textBoxNumeroDisciplina != null)
            {            
                nome = textBoxNomeDisciplina.Text;
                numero = textBoxNumeroDisciplina.Text;

                //textBoxNomeDisciplina = new AutoCompleteSource
            }
        }
    }
}