using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectsamozachet
{
    public partial class PostForm : Form
    {
        Facade facade;
        Form1 form1;
        MySqlConnection connection;
        MySqlCommand command;
        public PostForm(Facade facade, Form1 form1)
        {
            InitializeComponent();

            this.facade = facade;
            this.form1 = form1;
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=strahovaya");
            connect();
        }
        void connect()
        {
            init_view();
            data_reuse();
        }
        void data_reuse()
        {
            this.dgvPost.Rows.Clear();
            List<List<string>> list_cl = this.facade.post_list.mass_post();
            foreach (List<string> i in list_cl)
            {
                dgvPost.Rows.Add(i[0], i[1]);
            }
        }
        void init_view()
        {
            this.dgvPost.Columns.Add("clientID", "clientID");
            this.dgvPost.Columns.Add("Name", "Name");
        }
        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void PostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
