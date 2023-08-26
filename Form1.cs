using menuOpcoes_LPV.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuOpcoes_LPV
{
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void btAlertas_Click(object sender, EventArgs e)
        {
            FmAlertas fmAlertas = new FmAlertas();  
            fmAlertas.ShowDialog();
        }

        private void btExemploAlerta_Click(object sender, EventArgs e)
        {
            FmExemploAlerta fmExAlerta = new FmExemploAlerta();
            fmExAlerta.ShowDialog();
        }

        private void btAlteracaoRotulo_Click(object sender, EventArgs e)
        {
            FmExemploRotulos fmExRotulos = new FmExemploRotulos();
            fmExRotulos.ShowDialog();
        }

        private void btComboBox_Click(object sender, EventArgs e)
        {
            FmExemploComboBox fmExComboBox = new FmExemploComboBox();  
            fmExComboBox.ShowDialog();
        }
    }
}
