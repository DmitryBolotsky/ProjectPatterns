
namespace projectsamozachet
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.tb_id_cl = new System.Windows.Forms.TextBox();
            this.tb_name_cl = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_pas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_license = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.execute_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_client
            // 
            this.dgv_client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Location = new System.Drawing.Point(4, 4);
            this.dgv_client.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.RowHeadersWidth = 51;
            this.dgv_client.RowTemplate.Height = 24;
            this.dgv_client.Size = new System.Drawing.Size(920, 343);
            this.dgv_client.TabIndex = 0;
            // 
            // tb_id_cl
            // 
            this.tb_id_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id_cl.Location = new System.Drawing.Point(230, 354);
            this.tb_id_cl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_cl.Name = "tb_id_cl";
            this.tb_id_cl.Size = new System.Drawing.Size(693, 39);
            this.tb_id_cl.TabIndex = 3;
            // 
            // tb_name_cl
            // 
            this.tb_name_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name_cl.Location = new System.Drawing.Point(230, 403);
            this.tb_name_cl.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name_cl.Name = "tb_name_cl";
            this.tb_name_cl.Size = new System.Drawing.Size(693, 39);
            this.tb_name_cl.TabIndex = 4;
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_surname.Location = new System.Drawing.Point(230, 452);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(693, 39);
            this.tb_surname.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(952, 371);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(202, 197);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "изменить";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(999, 174);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(255, 190);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_insert.Location = new System.Drawing.Point(953, 17);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(246, 150);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "добавить";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.tb_pas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_license);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_lastname);
            this.panel1.Controls.Add(this.dgv_client);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_id_cl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_name_cl);
            this.panel1.Controls.Add(this.tb_surname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 772);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 645);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 598);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "pasportNS";
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_phone.Location = new System.Drawing.Point(235, 645);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(693, 39);
            this.tb_phone.TabIndex = 18;
            // 
            // tb_pas
            // 
            this.tb_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pas.Location = new System.Drawing.Point(231, 598);
            this.tb_pas.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(693, 39);
            this.tb_pas.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 554);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "driversLicense";
            // 
            // tb_license
            // 
            this.tb_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_license.Location = new System.Drawing.Point(230, 551);
            this.tb_license.Margin = new System.Windows.Forms.Padding(4);
            this.tb_license.Name = "tb_license";
            this.tb_license.Size = new System.Drawing.Size(693, 39);
            this.tb_license.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "LastName";
            // 
            // tb_lastname
            // 
            this.tb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_lastname.Location = new System.Drawing.Point(230, 502);
            this.tb_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(693, 39);
            this.tb_lastname.TabIndex = 13;
            // 
            // execute_info
            // 
            this.execute_info.AutoSize = true;
            this.execute_info.Location = new System.Drawing.Point(1074, 737);
            this.execute_info.Name = "execute_info";
            this.execute_info.Size = new System.Drawing.Size(124, 25);
            this.execute_info.TabIndex = 19;
            this.execute_info.Text = "без запроса";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 802);
            this.Controls.Add(this.execute_info);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "Блюдо";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dish_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.TextBox tb_id_cl;
        private System.Windows.Forms.TextBox tb_name_cl;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_license;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_pas;
        private System.Windows.Forms.Label execute_info;
    }
}