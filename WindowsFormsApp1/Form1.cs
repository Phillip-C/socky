using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        history frmHistory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SocketHistory.SocketRecord rec = new SocketHistory.SocketRecord();
            rec.client = "";
            rec.server = "";
            rec.id = 0;
            SocketHistory.History.Add(rec);
            //frmHistory = new history();
            //frmHistory.Show();
        }

        public void AddNewRow(string column1Value, string column2Value, string column3Value)
        {
            // Add a new row to the DataGridView
            dataGridView1.Rows.Add(column1Value, column2Value, column3Value);
        }

        public void loadHistory()
        {
            try
            {
                dataGridView1.Rows.Clear();
                if (SocketHistory.History.Count != null && SocketHistory.History.Count > 0)
                {
                    int id = 0;
                    foreach (SocketHistory.SocketRecord item in SocketHistory.History)
                    {
                        AddNewRow(id.ToString(), item.client, item.server);
                        id++;
                    }
                }
            }
            catch { }
        }

        public static async Task ConnectAndSendAsync(string webSocketUri, string messageToSend)
        {
            // Create an instance of ClientWebSocket
            ClientWebSocket webSocket = new ClientWebSocket();

            // Connect to the WebSocket server
            Uri serverUri = new Uri(webSocketUri);
            await webSocket.ConnectAsync(serverUri, CancellationToken.None);

            // Send the message
            byte[] messageBytes = Encoding.UTF8.GetBytes(messageToSend);
            SocketHistory.SocketRecord rec = new SocketHistory.SocketRecord();
            rec.id = 0;
            rec.client = messageToSend;
            SocketHistory.History.Add(rec);
            await webSocket.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);

            // Receive a message (optional)
            ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);
            WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);
            string receivedMessage = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
            Console.WriteLine($"Received message: {receivedMessage}");
            rec = new SocketHistory.SocketRecord();
            rec.id = 0;
            rec.server = receivedMessage;
            SocketHistory.History.Add(rec);
            // Close the WebSocket connection
            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing connection", CancellationToken.None);
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            string webSocketUri = "wss://ws.postman-echo.com/raw";
            string messageToSend = "Hello, WebSocket!";
            await ConnectAndSendAsync(webSocketUri, messageToSend);
        }
    }
}
