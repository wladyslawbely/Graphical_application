using System.IO.Pipes;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public async Task SendCommandToOpenTK(string command)
        {
            using (var client = new NamedPipeClientStream("OpenTK"))
            {
                await client.ConnectAsync();
                using (var writer = new StreamWriter(client))
                {
                    await writer.WriteLineAsync(command);
                    await writer.FlushAsync();
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await SendCommandToOpenTK("cube");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await SendCommandToOpenTK("pyramid");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await SendCommandToOpenTK("CUBE");
        }
    }
}