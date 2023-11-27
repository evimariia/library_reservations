using System.Windows.Forms;

namespace ReservasAPPv1
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string[] tipoSala = { "Individual", "Grupo" };
            comboBox1.Items.AddRange(tipoSala);
            string[] qtdePessoas = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", };
            comboBox2.Items.AddRange(qtdePessoas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date; // Obtém a parte da data
            DateTime selectedTime = dateTimePicker2.Value; // Obtém a parte da hora

            // Combina a parte da data com a parte da hora
            DateTime dataHoraReserva = new DateTime(
                selectedDate.Year,
                selectedDate.Month,
                selectedDate.Day,
                selectedTime.Hour,
                selectedTime.Minute,
                selectedTime.Second
            );
            String tipoSala = (String)comboBox1.SelectedItem;
            String qtdePessoas = (String)comboBox2.SelectedItem;

            if(tipoSala == "Grupo" && qtdePessoas == "1")
            {
                //MessageBox("Não é possível reservar sala de grupo para uma pessoa.\n" +
                //           "Selecione o tipo de sala como individual");
            }

            if(selectedDate < DateTime.Now)
            {
                //MessageBox("Não é possível reservar sala em datas passadas");
            }

            Autenticacao autenticacao = new Autenticacao();
            autenticacao.Show();

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}