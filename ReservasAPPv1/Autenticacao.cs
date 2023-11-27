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

        private void bt1_Click(object sender, EventArgs e)
        {
            string RA = textBox1.Text;
            string senha = textBox2.Text;

            try
            {
                if (Reservas.BLL.UsuarioRepository.AutenticaUsuario(RA, senha))
                {
                    string resultado = label4.Text;
                    resultado = "Reserva realizada com sucesso";
                    label4.Visible = true;
                }
                else
                {
                    label4.Text = "Não foi possível realizar a reserva. Aluno não encontrado";
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
