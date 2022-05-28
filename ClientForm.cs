using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace projectsamozachet
{
    public partial class ClientForm : Form
    {
        Facade facade;
        Form1 form1;
        MySqlConnection connection;
        MySqlCommand command;

        public ClientForm(Facade facade, Form1 form1)
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

        void init_view()
        {
            this.dgv_client.Columns.Add("clientID", "clientID");
            this.dgv_client.Columns.Add("Name", "Name");
            this.dgv_client.Columns.Add("Surname", "Surname");
            this.dgv_client.Columns.Add("LastName", "LastName");
            this.dgv_client.Columns.Add("driversLicense", "driversLicense");
            this.dgv_client.Columns.Add("pasportNS", "pasportNS");
            this.dgv_client.Columns.Add("phone", "phone");
        }

        void data_reuse()
        {
            this.dgv_client.Rows.Clear();
            List<List<string>> list_cl = this.facade.client_List.mass_klient();
            foreach (List<string> i in list_cl)
            {
                dgv_client.Rows.Add(i[0], i[1], i[2], i[3], i[4], i[5], i[6]);
            }
        }

        private void Dish_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(tb_id_cl.Text);
            string Name = tb_name_cl.Text;
            string Surname = tb_surname.Text;
            string LastName = tb_lastname.Text;
            int drivel = Convert.ToInt32(tb_license.Text);
            int pas = Convert.ToInt32(tb_pas.Text);
            int phone = Convert.ToInt32(tb_phone.Text);


            Object[] list = { clientID, Name, Surname, LastName, drivel,pas,phone };
            facade.create_client_list(list);
            string insert_query = "INSERT INTO client(clientID, Name, Surname, LastName, driversLicense, pasportNS,phone) VALUES " +
                $"({clientID}, \"{Name}\", \"{Surname}\",\"{LastName}\", {drivel}, {pas}, {phone})";
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(tb_id_cl.Text);
            string Name = tb_name_cl.Text;
            string Surname = tb_surname.Text;
            string LastName = tb_lastname.Text;
            int drivel = Convert.ToInt32(tb_license.Text);
            int pas = Convert.ToInt32(tb_pas.Text);
            int phone = Convert.ToInt32(tb_phone.Text);

            Object[] list = { clientID, Name, Surname, LastName, drivel, pas, phone };
            facade.update_client_list(list);
            string insert_query = string.Format("UPDATE client SET " +
                "`clientID`={0}, `Name`='{1}', `Surname`='{2}', " +
                "`LastName`={3}, `driversLicense`={4}, `pasportNS`={5}, `phone`={6}" +
                "WHERE `clientID`={0}",
                clientID.ToString(), Name, Surname,
                LastName, drivel.ToString(),pas.ToString(),phone.ToString());
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            facade.client_List.delete_el(Convert.ToInt32(tb_id_cl.Text));
            string insert_query = string.Format("DELETE FROM `client` WHERE `clientID`={0}",
                Convert.ToInt32(tb_id_cl.Text));
            executeMyQuery(insert_query);
            data_reuse();
        }

        private bool el_is_valid(string name_dish, string price_rub)
        {
            bool flag = true;
            string regex = @"[0-9]{11}";
            if (!Regex.IsMatch(price_rub, regex))
                flag = false;
            if (name_dish == "")
                flag = false;
            return flag;
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
