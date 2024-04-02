using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Raí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int vPesoValue, vIdadeValue;

            vPesoValue = (Convert.ToInt16(txtPeso.Text) + 1);
            vIdadeValue = Convert.ToInt16(txtIdade.Text);

            if ((vPesoValue >= 40 && vPesoValue <= 180) && (vIdadeValue >= 20 && vIdadeValue <= 65))
            {
                txtPeso.Text = vPesoValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = true;
            }
            else
            {
                txtPeso.Text = vPesoValue.ToString();
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "Dados Inválidos: Somente entre 40kg e 180kg e idade entre 20 e 65 anos";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int vPesoValue, vIdadeValue;

            vPesoValue = (Convert.ToInt16(txtPeso.Text) - 1);
            vIdadeValue = Convert.ToInt16(txtIdade.Text);

            if ((vPesoValue >= 40 && vPesoValue <= 180) && (vIdadeValue >= 20 && vIdadeValue <= 65))
            {
                txtPeso.Text = vPesoValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = true;
            }
            else
            {
                txtPeso.Text = vPesoValue.ToString();
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "Dados Inválidos: Somente entre 40kg e 180kg e idade entre 20 e 65 anos";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int vIdadeValue, vPesoValue;

            vIdadeValue = (Convert.ToInt16(txtIdade.Text) + 1);
            vPesoValue = Convert.ToInt16(txtPeso.Text);

            if ((vIdadeValue >= 20 && vIdadeValue <= 65) && (vPesoValue >= 40 && vPesoValue <= 180))
            {
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = true;
            }
            else
            {
                txtPeso.Text = vPesoValue.ToString();
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "Dados Inválidos: Somente entre 40kg e 180kg e idade entre 20 e 65 anos";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int vIdadeValue, vPesoValue;

            vIdadeValue = (Convert.ToInt16(txtIdade.Text) - 1);
            vPesoValue = Convert.ToInt16(txtPeso.Text);

            if ((vIdadeValue >= 20 && vIdadeValue <= 65) && (vPesoValue >= 40 && vPesoValue <= 180))
            {
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = true;
            }
            else
            {
                txtPeso.Text = vPesoValue.ToString();
                txtIdade.Text = vIdadeValue.ToString();
                txtImc.Text = "0";
                txtPesoIdeal.Text = "0";
                txtReferencia.Text = "...";
                txtObs.Text = "Dados Inválidos: Somente entre 40kg e 180kg e idade entre 20 e 65 anos";

                txtImc.BackColor = Color.White;
                txtPesoIdeal.BackColor = Color.White;
                txtReferencia.BackColor = Color.White;

                btnCalcular.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtAltura.Text = trackBar1.Value.ToString();
            
            if(btnHomem.Enabled == true)
            {
                if (trackBar1.Value < 100)
                {
                    txtPeso.Text = "55";
                }
                else if (trackBar1.Value >= 100 && trackBar1.Value < 150)
                {
                    txtPeso.Text = "65";
                }
                else if (trackBar1.Value >= 150 && trackBar1.Value < 180)
                {
                    txtPeso.Text = "75";
                }
                else
                {
                    txtPeso.Text = "80";
                }
            }
            else
            {
                if (trackBar1.Value < 100)
                {
                    txtPeso.Text = "50";
                }
                else if (trackBar1.Value >= 100 && trackBar1.Value < 150)
                {
                    txtPeso.Text = "55";
                }
                else if (trackBar1.Value >= 150 && trackBar1.Value < 180)
                {
                    txtPeso.Text = "60";
                }
                else
                {
                    txtPeso.Text = "75";
                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtHomem.Text = "HOMEM";
            txtMulher.Text = "";
            txtPeso.Text = "80";
            txtIdade.Text = "30";
            txtAltura.Text = "180";
            trackBar1.Value = 180;
            txtImc.Text = "0";
            txtPesoIdeal.Text = "0";
            txtReferencia.Text = "...";
            txtObs.Text = "";

            txtImc.BackColor = Color.White;
            txtPesoIdeal.BackColor = Color.White;
            txtReferencia.BackColor = Color.White;

            btnCalcular.Enabled = true;
            btnPesoM.Enabled = true;
            btnPesoMe.Enabled = true;
            btnIdadeM.Enabled = true;
            btnIdadeMe.Enabled = true;
            btnHomem.Enabled = true;
            btnMulher.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHomem.Text = "";
            txtMulher.Text = "MULHER";
            txtPeso.Text = "60";
            txtIdade.Text = "30";
            txtAltura.Text = "160";
            trackBar1.Value = 160;
            txtImc.Text = "0";
            txtPesoIdeal.Text = "0";
            txtReferencia.Text = "...";
            txtObs.Text = "";

            txtImc.BackColor = Color.White;
            txtPesoIdeal.BackColor = Color.White;
            txtReferencia.BackColor = Color.White;

            btnCalcular.Enabled = true;
            btnPesoM.Enabled = true;
            btnPesoMe.Enabled = true;
            btnIdadeM.Enabled = true;
            btnIdadeMe.Enabled = true;
            btnHomem.Enabled = false;
            btnMulher.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int vPeso, vPesoIdeal;
            double vAltura, vImc;

            vPeso = Convert.ToInt16(txtPeso.Text);
            vAltura = Convert.ToDouble(txtAltura.Text) / 100;
            vImc = Math.Round((vPeso / Math.Pow(vAltura, 2)), 2);

            txtImc.Text = vImc.ToString();
            txtPesoIdeal.BackColor = Color.LightGreen;

            if (txtHomem.Text == "HOMEM")
            {
                vPesoIdeal = Convert.ToInt16((72.7 * vAltura) - 58);
                txtPesoIdeal.Text = vPesoIdeal.ToString();
            }
            else if (txtMulher.Text == "MULHER")
            {
                vPesoIdeal = Convert.ToInt16((62.1 * vAltura) - 44.7);
                txtPesoIdeal.Text = vPesoIdeal.ToString();
            }


            if (vImc < 15)
            {
                txtImc.BackColor = Color.OrangeRed;
                txtReferencia.BackColor = Color.OrangeRed;
                txtReferencia.Text = "Abaixo do peso I";
                txtObs.Text = "IMPLICAÇÕES E RISCOS: Anorexia, bulimia, osteoporose e auto consumo de massa muscular.";
            }
            else if (vImc >= 15 && vImc <= 18.5)
            {
                txtImc.BackColor = Color.Yellow;
                txtReferencia.BackColor = Color.Yellow;
                txtReferencia.Text = "Abaixo do peso";
                txtObs.Text = "IMPLICAÇÕES E RISCOS: Transtornos digestivos, debilidade, fadiga crónica, stress, ansiedade e difusão das hormonas.";
            }
            else if (vImc > 18.5 && vImc < 25)
            {

                txtImc.BackColor = Color.Green;
                txtReferencia.BackColor = Color.LightGreen;
                txtReferencia.Text = "Peso Normal";
                txtObs.Text = "Estado normal, bom nível de energia, vitalidade e boa condição física. Mantenha o seu peso e IMC.";
            }
            else if (vImc >= 25 && vImc < 30)
            {

                txtImc.BackColor = Color.Yellow;
                txtReferencia.BackColor = Color.Yellow;
                txtReferencia.Text = "Acima do peso";
                txtObs.Text = "IMPLICAÇÕES E RISCOS: Fadiga, problemas digestivo, problemas circulatórios, má circulação nas pernas e varizes.";
            }
            else if (vImc >= 30 && vImc < 40)
            {
                txtImc.BackColor = Color.OrangeRed;
                txtReferencia.BackColor = Color.DarkOrange;
                txtReferencia.Text = "Obesidade I";
                txtObs.Text = "IMPLICAÇÕES E RISCOS: Diabetes, angina de peito, enfartes, trombo flebites, arteroscleroses, embolias, alterações menstruais.";
            }
            else
            {
                txtImc.BackColor = Color.OrangeRed;
                txtReferencia.BackColor = Color.OrangeRed;
                txtReferencia.Text = "Obesidade II";
                txtObs.Text = "IMPLICAÇÕES E RISCOS: Anorexia, bulimia, osteoporose e auto consumo de massa muscular. Falta de ar, apneia, sonolência, trombose pulmonar," +
                "úlceras varicosas, cancro de cólon, uterino e mamário, refluxo esofágico, discriminação social, laboral e sexual.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHomem.Text = "";
            txtMulher.Text = "";
            txtPeso.Text = "70";
            txtIdade.Text = "30";
            txtAltura.Text = "170";
            trackBar1.Value = 170;
            txtImc.Text = "0";
            txtPesoIdeal.Text = "0";
            txtReferencia.Text = "...";
            txtObs.Text = "Selecione o Gênero";

            txtImc.BackColor = Color.White;
            txtPesoIdeal.BackColor = Color.White;
            txtReferencia.BackColor = Color.White;

            btnCalcular.Enabled = false;
            btnPesoM.Enabled = false;
            btnPesoMe.Enabled = false;
            btnIdadeM.Enabled = false;
            btnIdadeMe.Enabled = false;
            btnHomem.Enabled = true;
            btnMulher.Enabled = true;
        }
    }
}
