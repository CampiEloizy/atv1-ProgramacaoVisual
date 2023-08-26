using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuOpcoes_LPV.Formularios
{
    public partial class FmExemploComboBox : Form
    {
        public FmExemploComboBox()
        {
            InitializeComponent();
            txtPercDesconto.Visible = false;
            lbPercentual.Visible = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorComDesconto = 0;

            switch (tipoCliente)
            {
                case 0://C1iente Diamante:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.25;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                case 1: //C1iente Ouro:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.20;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                case 2: //vip comum aleatorio
                    { 
                        valorComDesconto = valorCompra - valorCompra * 0.15;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                case 3: //comum 
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.10;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                case 4: //aleatorio 
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.05;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                default :
                    {
                        MessageBox.Show("Selecione um Cliente", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;

            if (tipoCliente == 4)
            {
                txtPercDesconto.Visible = true; // <-- A caixa de texto "Perc(%) Desconto" ficará visível
                lbPercentual.Visible = true; // <-- O label "Perc(%) Desconto" ficará visível
            }
            else
            {
                txtPercDesconto.Visible = false; // <-- A caixa de texto "Perc(%) Desconto" ficará invisível
                lbPercentual.Visible = false; // <-- O label "Perc(%) Desconto" ficará invisível
            }
        }
        private void txtValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtValorCompra.Text == "")
                {
                    MessageBox.Show("O campo está vazio!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorCompra.Select();
                }
                else
                {
                    txtPercDesconto.Select();
                }
            }
        }

        private void txtValorCompra_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true; // <-- Liberar a virgula

                if (e.KeyCode == Keys.Enter) verificarNumero = true; // <-- Liberar a tecla "enter"

                if (e.KeyCode == Keys.Back) verificarNumero = true; // <-- Liberar a tecla "backspace"

                int qtdVirgula = txtValorCompra.Text.Count(v => v == ','); // <-- Contar as virgulas

                if (qtdVirgula > 1) verificarNumero = false; // <-- Verificar as virgulas
            }


            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Text = txtValorCompra.Text.Remove(txtValorCompra.Text.Length - 1);
            }
        }

        private void txtPercDescontos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPercDesconto.Text == "")
                {
                    MessageBox.Show("O campo está vazio!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPercDesconto.Select();
                }
            }
        }

        private void txtPercDescontos_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
