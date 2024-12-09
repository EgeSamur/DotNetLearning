namespace RabbitMq.Lib
{
    public partial class Form1 : Form
    {

        private bool _isConnectionOpen;
        private bool isConnectionOpen = false;
        public Form1()
        {
            InitializeComponent();
            Init();
            UpdateConnectionStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionStatusLabel.Text = "Disconnected";
            connectionStatusLabel.ForeColor = Color.Red;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            isConnectionOpen = !isConnectionOpen;
            UpdateConnectionStatus();
        }

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
    }
}
