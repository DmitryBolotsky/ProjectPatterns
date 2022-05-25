using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectsamozachet
{
    public partial class Form1 : Form
    {
        Facade facade;
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            this.facade = new Facade();
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=strahovaya");
            connect();
        }

        public Form1(Facade facade)
        {
            InitializeComponent();

            this.facade = facade;
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=strahovaya");
        }

        private void ingredient_Click(object sender, EventArgs e)
        {
            insurancesheetForm ins = new insurancesheetForm(facade, this);
            ins.Show();
            Hide();
        }

        private void dish_Click(object sender, EventArgs e)
        {
            ClientForm cl = new ClientForm(facade, this);
            cl.Show();
            Hide();
        }

        private void product_Click(object sender, EventArgs e)
        {
            PostForm posts = new PostForm(facade, this);
            posts.Show();
            Hide();
        }

        void connect()
        {
            string query = "SELECT * FROM client";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                facade.create_client_list(row.ItemArray);
            query = "SELECT * FROM posts";
            table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                facade.create_post_list(row.ItemArray);
            query = "SELECT * FROM insurancesheet";
            table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                facade.create_insurancesheet_list(row.ItemArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
