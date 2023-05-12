using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            loadHistory();
        }

        public void AddNewRow(string column1Value, string column2Value, string column3Value)
        {
            // Add a new row to the DataGridView
            dataGridView1.Rows.Add(column1Value, column2Value, column3Value);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loadHistory();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SocketHistory.History.Count > dataGridView1.Rows.Count)
            {
                loadHistory();
            }
        }
    }
}
