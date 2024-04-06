using ChatEngine;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ChatClient
{
    public partial class GroupCreatorForm : Form
    {
        private TcpClient server;
        public GroupCreatorForm(TcpClient server)
        {
            this.server = server;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "" || txtMembers.Text == "")
            {
                MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StreamWriter streamWriter = new StreamWriter(server.GetStream());

            Group group = new Group(txtGroupName.Text, txtMembers.Text);
            String jsonString = JsonSerializer.Serialize(group);
            Json json = new Json("CREATE_GROUP", jsonString);

            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(json);
            String S = Encoding.ASCII.GetString(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);

            streamWriter.WriteLine(S);
            streamWriter.Flush();

            this.Close();
        }
    }
}
