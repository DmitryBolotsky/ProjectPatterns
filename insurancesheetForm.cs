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
    public partial class insurancesheetForm : Form
    {
        Facade facade;
        Form1 form1;
        MySqlConnection connection;
        MySqlCommand command;
        public insurancesheetForm(Facade facade, Form1 form1)
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
            this.dgvIns.Rows.Clear();
            List<List<string>> list_cl = this.facade.insurancesheet_list.mass_insurancesheet();
            foreach (List<string> i in list_cl)
            {
                dgvIns.Rows.Add(i[0], i[1], i[2], i[3], i[4]);
            }
        }
        void init_view()
        {
            this.dgvIns.Columns.Add("insuranceSheetID", "insuranceSheetID");
            this.dgvIns.Columns.Add("clientID", "clientID");
            this.dgvIns.Columns.Add("emploeeID", "emploeeID");
            this.dgvIns.Columns.Add("automobilID", "automobilID");
            this.dgvIns.Columns.Add("date", "date");
        }
        private void insurancesheetForm_Load(object sender, EventArgs e)
        {

        }

        private void insurancesheetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            facade.insurancesheet_list.delete_el(Convert.ToInt32(tb_insuranceSheetID.Text));
            string insert_query = string.Format("DELETE FROM `insurancesheet` WHERE `clientID`={0}",
                Convert.ToInt32(tb_insuranceSheetID.Text));
            executeMyQuery(insert_query);
            data_reuse();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int insuranceSheetID = Convert.ToInt32(tb_insuranceSheetID.Text);
            int clientID = Convert.ToInt32(tb_cl.Text);
            int emploeeID = Convert.ToInt32(tb_em.Text);
            int automobilID = Convert.ToInt32(tb_autoid.Text);
            string date = tb_date.Text;

            Object[] list = { insuranceSheetID, clientID, emploeeID, automobilID, date};
            facade.update_insurancesheet_list(list);
            string insert_query = string.Format("UPDATE insurancesheet SET " +
                "`insuranceSheetID`={0}, `clientID`='{1}', `emploeeID`='{2}', " +
                "`automobilID`={3}, `date`={4}",insuranceSheetID.ToString(), clientID.ToString(), emploeeID.ToString(),automobilID.ToString(), date);
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
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
    }
}
