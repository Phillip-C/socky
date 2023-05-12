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
    public partial class MainIface : UserControl
    {
        
        public MainIface()
        {
            InitializeComponent();
        }

        private void btnAddMarker_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Form1.ConnectAndSendAsync(tbTarget.Text, tbMessage.Text);
        }

        public void update_history(List<SocketHistory.SocketRecord>newrecord)
        {
            foreach (var item in newrecord)
            {
                dataGridView1.Rows.Add(item.id, item.client, item.server);
            }
        }
    }
}
