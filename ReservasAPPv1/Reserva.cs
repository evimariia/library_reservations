using Reservas.BLL;
using Reservas.MODEL;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            string[] qtdePessoas = { "1", "2", "3", "4", "5", "6" };
            string[] numSala = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};

            comboBox1.Items.AddRange(tipoSala);
            comboBox2.Items.AddRange(qtdePessoas);
            comboBox3.Items.AddRange(numSala);  

        }

        private async void bt1_ClickAsync(object sender, EventArgs e)
        {
            String tipoSala = (String)comboBox1.SelectedItem;
            String qtdePessoas = (String)comboBox2.SelectedItem;
            String numSala = (String)comboBox3.SelectedItem;

            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime selectedTime = dateTimePicker2.Value;

            DateTime dataHoraReserva = new DateTime(
                selectedDate.Year,
                selectedDate.Month,
                selectedDate.Day,
                selectedTime.Hour,
                selectedTime.Minute,
                selectedTime.Second
            );

            int intNumSala = int.Parse(numSala);

            if (tipoSala == "Grupo" && qtdePessoas == "1")
            {
                label6.Text = "Não é possível reservar sala de grupo para uma pessoa.\n" +
                              "Selecione o tipo de sala como individual";
                label6.Visible = true;
            }
            else if (selectedDate < DateTime.Now)
            {
                label6.Text = "Não é possível reservar sala em datas e horários passados";
                label6.Visible = true;
            }
            else
            {

                string path = "http://localhost:5197/api/Sala";

                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(path);
                var content = await response.Content.ReadAsStringAsync();
                List<Sala> salas = JsonConvert.DeserializeObject<List<Sala>>(content);

                foreach(Sala _sala in salas)
                {
                    if(_sala.Numero == intNumSala)
                    {
                        Autenticacao autenticacao = new(_sala, dataHoraReserva);
                        autenticacao.Show();
                    }
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }


}