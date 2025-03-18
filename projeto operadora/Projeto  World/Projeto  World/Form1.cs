using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto__World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\\Arquivo\texto" + DateTime.Now.ToString("dd_MM_yy") + ".txt", Txt_Texto.Text);
            Txt_Texto.Text = string.Empty;
            MessageBox.Show("ARQUIVO SALVO COM SUCESSO !!!");

        }   




          
        
    



        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Texto.Clear();
        }
    }
}
