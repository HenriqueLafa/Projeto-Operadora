using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Orange;// formatação cor
            pictureBox1.Image = Properties.Resources.OI;

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.DarkViolet;// formatação cor
            Lbl_Sejabemvindo.ForeColor = Color.White;// formatação cor branca
            Lbl_Nome.ForeColor = Color.White;// formatação cor branca
            Grp_Operadoras.ForeColor = Color.White;// formatação cor branca
            Lbl_Operadoraselecionada.ForeColor = Color.White;
            Lbl_DDD.ForeColor = Color.White;
            Lbl_Numerodocelular.ForeColor = Color.White;
            Lbl_Valordarecarga.ForeColor = Color.White;
            Lbl_DadosdaRecarga.ForeColor = Color.White;
            Lbl_V1.ForeColor = Color.White;
            Lbl_V2.ForeColor = Color.White;
            Lbl_V3.ForeColor = Color.White;
            Lbl_V4.ForeColor = Color.White;
            Lbl_V5.ForeColor = Color.White;
            Lbl_V6.ForeColor = Color.White;
            Lbl_V7.ForeColor = Color.White;
            Lbl_V8.ForeColor = Color.White;
            //Lbl_Validade.Forecolor = color.white;
            //Lbl_Total.forecolor = color.white;
            Btn_1.ForeColor = Color.Violet;
            Btn_1.FlatAppearance.MouseDownBackColor = Color.White;
            Btn_2.ForeColor = Color.Violet;
            Btn_2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_3.ForeColor = Color.Violet;
            Btn_3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_4.ForeColor = Color.Violet;
            Btn_4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_5.ForeColor = Color.Violet;
            Btn_5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_6.ForeColor = Color.Violet;
            Btn_6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_7.ForeColor = Color.Violet;
            Btn_7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_8.ForeColor = Color.Violet;
            Btn_8.FlatAppearance.MouseOverBackColor = Color.White;

            Lbl_Sejabemvindo.Enabled = true;
            Lbl_DadosdaRecarga.Enabled = true;
            Lbl_DDD.Enabled = true;
            Lbl_Numerodocelular.Enabled = true;
            Lbl_V1.Enabled = true;
            Lbl_V2.Enabled = true;
            Lbl_V3.Enabled = true;
            Lbl_V4.Enabled = true;
            Lbl_V5.Enabled = true;
            Lbl_V6.Enabled = true;
            Lbl_V7.Enabled = true;
            Lbl_V8.Enabled = true;
            Btn_1.Enabled = true;
            Btn_2.Enabled = true;
            Btn_3.Enabled = true;
            Btn_4.Enabled = true;
            Btn_5.Enabled = true;
            Btn_6.Enabled = true;
            Btn_7.Enabled = true;
            Btn_8.Enabled = true;
            txt_DDD.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_NumerodoCelular.Enabled = true;
            Txt_OperadoraSelecionada.Enabled = true;
            txt_Valordarecarga.Enabled = true;
            Btn_1.Text = "12 Reais";
            Lbl_V1.Text = "30 dias";
            Btn_2.Text = "15 Reais";
            Lbl_V2.Text = "30 dias";
            Btn_3.Text = "20 Reais";
            Lbl_V3.Text = "60 dias";
            Btn_4.Text = "25 Reais";
            Lbl_V4.Text = "30 dias";
            Btn_5.Text = "30 Reais";
            Lbl_V5.Text = "90 dias";
            Btn_6.Text = "40 Reais";
            Lbl_V6.Text = "90 dias";
            Btn_7.Text = "100 Reais";
            Lbl_V7.Text = "180 dias";
            Btn_8.Text = "200 Reais";
            Lbl_V8.Text = "365 dias";
            pictureBox1.Image = Properties.Resources.download__2_;

           


            
            
            

                


            











          

                

       


                                                     
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;// formatação cor
            pictureBox1.Image = Properties.Resources.download__1_;
        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;// formatação cor
            pictureBox1.Image = Properties.Resources.Claro;
        }
    }
}
