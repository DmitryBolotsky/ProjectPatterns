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
            int postID = Convert.ToInt32(tb_id.Text);
            string postName = tb_name.Text;
            


            Object[] list = { postID,postName};
            facade.create_post_list(list);
            string insert_query = "INSERT INTO posts(postID,Name) VALUES " +
                $"({postID}, \"{postName}\")";
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            facade.post_list.delete_el(Convert.ToInt32(tb_id.Text));
            string insert_query = string.Format("DELETE FROM `posts` WHERE `postID`={0}",
                Convert.ToInt32(tb_id.Text));
            executeMyQuery(insert_query);
            data_reuse();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int postID = Convert.ToInt32(tb_id.Text);
            string postName = tb_name.Text;
            Object[] list = { postID, postName };
            facade.update_post_list(list);

            string insert_query = string.Format("UPDATE posts SET " +
                "`postID`={0}, `postName`={1}",postID.ToString(), Name);
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    execute_info.ForeColor = System.Drawing.Color.Green;
                    execute_info.Text = "Выполнено";
                }
                else
                {
                    execute_info.ForeColor = System.Drawing.Color.Red;
                    execute_info.Text = "Не выполнено";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}

