using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_loja
{
    public partial class Form1 : Form
    {
        decimal bicicleta; //Guardando o preço de cada produto
        int e1; //Guardar o valor de estoque de cada produto
        decimal q1; //Guardar o valor da quantidade de cada produto
        
        private void total() //Criando metódo total
        {
            label1.Text = ((bicicleta * q1)).ToString("c2"); //Transição pra moeda
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void check_produto1_CheckedChanged(object sender, EventArgs e)
        {
            bicicleta = 500; //Guardando o valor do produto
            e1 = 10; //guardando a quantidade  do produto

            if (check_produto1.Checked == true)
            {
                check_produto1.Text = "Bicicleta"; //Alterando Para o Nome do 

                pic_carrinho1.Image = Properties.Resources.Bicicleta;//trocar a imagem
                List_Produtos.Items.Add("Bicicleta"); //Adicionando a Bicicleta
                List_Preço.Items.Add(bicicleta); //Adicionando o Preço
                List_Descrição.Items.Add("Aro 29 Speed"); //Adicionando a descrição
                nump1.Visible = true; //Tornando o NumericUpDown Visivel
                nump1.Maximum = e1; //Limitando a quantidade Maxima

            }

            else {
                check_produto1.Text = "Produto 1";
                pic_carrinho1.Image = Properties.Resources.carrinho;
                List_Produtos.Items.Remove("Bicicleta");
                List_Descrição.Items.Remove("Aro 29 Speed");
                List_Preço.Items.Remove(bicicleta);
                nump1.Visible = false;
                nump1.Value = 0;
                //termino da programção alterar o nome do produto /  altera img,/informações das listas/ preço /tornar visivel
                
            }

            
            
            
            
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            q1 = nump1.Value;
            label1.Text = "Disponível: " + (e1 - q1);
            total();
            //termino da programação numericUpDown, recebe os produtos, indica a quantidade disponivel e usa o metodo para fazer o calculo socinho .

        }
    }
}
