using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasAPPv1
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string RA = textBox1.Text;
            string senha = textBox2.Text;

            try
            {
                if (Reservas.BLL.UsuarioRepository.AutenticaUsuario(RA, senha))
                //if (RA == "1t1.111111" && senha == "1234")
                {
                    label4.Text = "Reserva realizada com sucesso";
                    label4.Visible = true;
                }
                else
                {
                    label4.Text = "Não foi possível realizar a reserva. Aluno não encontrado ou credenciais inválidas";
                    label4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label4.Text = "Nao foi possivel realizar o login: " + ex.Message;
                label4.Visible = true;
                textBox2.Text = "";
            }
        }
    }
}
