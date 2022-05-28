namespace projectsamozachet
{
    partial class insurancesheetForm
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
            this.dgvIns = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tb_insuranceSheetID = new System.Windows.Forms.TextBox();
            this.tb_cl = new System.Windows.Forms.TextBox();
            this.tb_em = new System.Windows.Forms.TextBox();
            this.tb_autoid = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.execute_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIns
            // 
            this.dgvIns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIns.Location = new System.Drawing.Point(12, 12);
            this.dgvIns.Name = "dgvIns";
            this.dgvIns.RowHeadersWidth = 72;
            this.dgvIns.RowTemplate.Height = 31;
            this.dgvIns.Size = new System.Drawing.Size(797, 416);
            this.dgvIns.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(890, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(231, 171);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1141, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(231, 171);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(890, 229);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(231, 171);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tb_insuranceSheetID
            // 
            this.tb_insuranceSheetID.Location = new System.Drawing.Point(224, 458);
            this.tb_insuranceSheetID.Name = "tb_insuranceSheetID";
            this.tb_insuranceSheetID.Size = new System.Drawing.Size(585, 29);
            this.tb_insuranceSheetID.TabIndex = 4;
            this.tb_insuranceSheetID.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_cl
            // 
            this.tb_cl.Location = new System.Drawing.Point(224, 510);
            this.tb_cl.Name = "tb_cl";
            this.tb_cl.Size = new System.Drawing.Size(585, 29);
            this.tb_cl.TabIndex = 5;
            // 
            // tb_em
            // 
            this.tb_em.Location = new System.Drawing.Point(224, 563);
            this.tb_em.Name = "tb_em";
            this.tb_em.Size = new System.Drawing.Size(585, 29);
            this.tb_em.TabIndex = 6;
            // 
            // tb_autoid
            // 
            this.tb_autoid.Location = new System.Drawing.Point(224, 608);
            this.tb_autoid.Name = "tb_autoid";
            this.tb_autoid.Size = new System.Drawing.Size(585, 29);
            this.tb_autoid.TabIndex = 7;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(224, 665);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(585, 29);
            this.tb_date.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "insuranceSheetID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "clientID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "emploeeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "automobilID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "date";
            // 
            // execute_info
            // 
            this.execute_info.AutoSize = true;
            this.execute_info.Location = new System.Drawing.Point(1055, 528);
            this.execute_info.Name = "execute_info";
            this.execute_info.Size = new System.Drawing.Size(127, 25);
            this.execute_info.TabIndex = 14;
            this.execute_info.Text = "Нет запроса";
            // 
            // insurancesheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 808);
            this.Controls.Add(this.execute_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_autoid);
            this.Controls.Add(this.tb_em);
            this.Controls.Add(this.tb_cl);
            this.Controls.Add(this.tb_insuranceSheetID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvIns);
            this.Name = "insurancesheetForm";
            this.Text = "insurancesheetForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.insurancesheetForm_FormClosed);
            this.Load += new System.EventHandler(this.insurancesheetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIns;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox tb_insuranceSheetID;
        private System.Windows.Forms.TextBox tb_cl;
        private System.Windows.Forms.TextBox tb_em;
        private System.Windows.Forms.TextBox tb_autoid;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label execute_info;
    }
}