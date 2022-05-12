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
    public partial class DisciplinasForm : Form
    {
        public DisciplinasForm()
        {
            InitializeComponent();
        }

        private void buttonInserirDisciplinas_Click(object sender, EventArgs e)
        {
            CadastrosDisciplinasForms cadastrosDisciplinas = new CadastrosDisciplinasForms();
            cadastrosDisciplinas.ShowDialog();
        }
    }
}