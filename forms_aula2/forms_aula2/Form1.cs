using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_aula2
{
    public partial class Form1 : Form
    {

        bool VezX = false;
        int rodada = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // metodo com ações caso escolha o X bola

        private void btnX_Click(object sender, EventArgs e)
        {

            VezX = true;

            lblVez.Text = "X";

            botoesEnable();

            btnBola.Enabled = false;
            btnX.Enabled = false;
        }

        // metodo com ações caso escolha o botão bola
        private void btnBola_Click(object sender, EventArgs e)
        {
            VezX = false;

            lblVez.Text = "O";

            botoesEnable();

            btnBola.Enabled = false;
            btnX.Enabled = false;
        }

        // metodo para habilitar os botões
        private void botoesEnable()
        {
            //habilitando os botões do jogo

            btnC1L1.Enabled = true;
            btnC1L2.Enabled = true;
            btnC1L3.Enabled = true;
            btnC2L1.Enabled = true;
            btnC2L2.Enabled = true;
            btnC2L3.Enabled = true;
            btnC3L1.Enabled = true;
            btnC3L2.Enabled = true;
            btnC3L3.Enabled = true;
        }

        private void botoesEnableF()
        {
            //desabilitando os botões do jogo após vencer

            btnC1L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L1.Enabled = false;
            btnC2L2.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L1.Enabled = false;
            btnC3L2.Enabled = false;
            btnC3L3.Enabled = false;
        }

        // processo de reinicialização do jogo
        private void btnRecomecar_Click(object sender, EventArgs e)
        {

            // bloqueando os botões do jogo

            btnC1L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L1.Enabled = false;
            btnC2L2.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L1.Enabled = false;
            btnC3L2.Enabled = false;
            btnC3L3.Enabled = false;

            // resetando os valores dos botões

            btnC1L1.Text = "";
            btnC1L2.Text = "";
            btnC1L3.Text = "";
            btnC2L1.Text = "";
            btnC2L2.Text = "";
            btnC2L3.Text = "";
            btnC3L1.Text = "";
            btnC3L2.Text = "";
            btnC3L3.Text = "";

            // habilitando novamente os botões dew escolha

            btnX.Enabled = true;
            btnBola.Enabled = true;

            // resetando os valores das labels

            lblVez.Text = " - ";
            lblVencedor.Text = " - ";

            rodada = 0;

        }

        //metodo para alterar os texts do botões
        private void btn_lick(object sender, EventArgs e)
        {
            //pegando o sender para saber onde trocar os valores
            // captando o valor do label VEZ para mudar o text do botão
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;
            btn.Enabled = false;

            // verificando o valor e modificando a lbl para o próximo jogador
            if (VezX)
            {
                lblVez.Text = "O";
                rodada++;
            }
            else
            {
                lblVez.Text = "X";
                rodada++;
            }
            verificarVencedor();
            VezX = !VezX;
            
        }
        //metodo para verificar o vecedor.
        private void verificarVencedor()
        {
            if (btnC1L1.Text == btnC2L1.Text && btnC1L1.Text == btnC3L1.Text && btnC1L1.Text !="")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if(btnC1L2.Text == btnC2L2.Text && btnC1L2.Text == btnC3L2.Text && btnC1L2.Text != "")
            {
                lblVencedor.Text = btnC1L2.Text;
                MessageBox.Show(btnC1L2.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC1L3.Text == btnC2L3.Text && btnC1L3.Text == btnC3L3.Text && btnC1L3.Text != "")
            {
                lblVencedor.Text = btnC1L3.Text;
                MessageBox.Show(btnC1L3.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC1L1.Text == btnC1L2.Text && btnC1L1.Text == btnC1L3.Text && btnC1L1.Text != "")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC2L1.Text == btnC2L2.Text && btnC2L1.Text == btnC2L3.Text && btnC2L1.Text != "")
            {
                lblVencedor.Text = btnC2L1.Text;
                MessageBox.Show(btnC2L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC3L1.Text == btnC3L2.Text && btnC3L1.Text == btnC3L3.Text && btnC3L1.Text != "")
            {
                lblVencedor.Text = btnC3L1.Text;
                MessageBox.Show(btnC3L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC1L1.Text == btnC2L2.Text && btnC1L1.Text == btnC3L3.Text && btnC1L1.Text != "")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (btnC3L1.Text == btnC2L2.Text && btnC3L1.Text == btnC1L3.Text && btnC3L1.Text != "")
            {
                lblVencedor.Text = btnC3L1.Text;
                MessageBox.Show(btnC3L1.Text + " é o vencedor!");
                botoesEnableF();
            }
            else if (rodada == 9)
            {
                lblVencedor.Text = "Empate";
                MessageBox.Show("O jogo empatou!");
                botoesEnableF();
            }


        }
    }
}
