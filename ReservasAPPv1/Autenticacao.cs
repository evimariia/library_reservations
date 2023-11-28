using Reservas.MODEL;
using Reservas.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ReservasAPPv1
{
    public partial class Autenticacao : Form
    {
        public Autenticacao(Sala sala, DateTime dataHoraReserva)
        {
            InitializeComponent();
            label4.Text = sala.ToString();
            label4.Visible = true;

        }


        private void button1_Click(object sender, EventArgs e, Sala sala, DateTime dataHoraReserva)
        {
            string RA = textBox1.Text;
            string senha = textBox2.Text;

            try
            {
                if (UsuarioRepository.AutenticaUsuario(RA, senha))
                {
                    Usuario user = UsuarioRepository.GetByRa(RA);
                    if (ReservaRepository.SalaOcupada(sala.Id, dataHoraReserva) && ReservaRepository.UsuarioOcupada(user.Id, dataHoraReserva))
                    {
                        Reserva reserva = new Reserva();
                        //reserva.IdUsuario = user.Id;
                        label4.Text = "Reserva realizada com sucesso";
                        label4.Visible = true;
                    }
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
