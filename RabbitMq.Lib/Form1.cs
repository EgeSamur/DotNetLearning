using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMq.Lib
{
    public partial class Form1 : Form
    {

        private bool isConnectionOpen = false;
        private IConnection connection;
        private IModel _channel;
        private IModel channel => _channel ?? (_channel = GetChannel());
        public Form1()
        {
            InitializeComponent();
            Init();
            UpdateConnectionStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectTextBox.Text = "amqp://guest:guest@localhost:5672";
            connectionStatusLabel.Text = "Disconnected";
            connectionStatusLabel.ForeColor = Color.Red;
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
                connection = GetConnection();
            isConnectionOpen = !isConnectionOpen;
            UpdateConnectionStatus();
        }

        #region Extra Methodos
        private void UpdateConnectionStatus()
        {
            if (isConnectionOpen)
            {
                connectionStatusLabel.Text = "Connected";
                connectButton.Text = "Disconnect";
                connectionStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                connectionStatusLabel.Text = "Disconnected";
                connectButton.Text = "Connect";
                connectionStatusLabel.ForeColor = Color.Red;
            }
        }
        private void Init()
        {
            DeclareQueueTypecomboBox.Items.Add("Direct");
            DeclareQueueTypecomboBox.Items.Add("Fanout");
            DeclareQueueTypecomboBox.Items.Add("Topic");
            DeclareQueueTypecomboBox.Items.Add("Headers");

            ExchangeComboBox.Items.Add("Direct");
            ExchangeComboBox.Items.Add("Fanout");
            ExchangeComboBox.Items.Add("Topic");
            ExchangeComboBox.Items.Add("Headers");

            DeclareQueueTypecomboBox.SelectedIndex = ExchangeComboBox.SelectedIndex - 0;
        }
        #endregion

        #region Private Methods
        private IConnection GetConnection()
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri(connectTextBox.Text.Trim(), UriKind.RelativeOrAbsolute),
            };

            return factory.CreateConnection();
        }
        private IModel GetChannel()
        {
            return connection.CreateModel();
        }

        private void WriteDataToExchange(string exchangeName, string routingKey, object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(exchangeName, routingKey, null, dataArr);
        }
        #endregion

        private void declareButton_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(queueNameTextBox.Text.Trim());
        }

        private void declarev2button_Click_2(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(NameTextBox.Text.Trim(),
                DeclareQueueTypecomboBox.Text.Trim().ToLower());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(NameTextBox.Text.Trim(),
               DeclareQueueTypecomboBox.Text.Trim().ToLower());
        }

        private void bindQueuebutton_Click(object sender, EventArgs e)
        {
            channel.QueueBind(queueNameTextBox.Text.Trim(),
                NameTextBox.Text.Trim(),
                rotingKeytextBox.Text.Trim());
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            WriteDataToExchange(ExchangeNameTypetextBox2.Text.Trim(),
                routingKeyTextBox.Text.Trim(), richTextBox1.Text);
        }
    }
}
