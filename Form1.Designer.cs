
namespace projectsamozachet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dish = new System.Windows.Forms.Button();
            this.ingredient = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dish
            // 
            this.dish.BackColor = System.Drawing.Color.White;
            this.dish.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish.Location = new System.Drawing.Point(20, 148);
            this.dish.Margin = new System.Windows.Forms.Padding(4);
            this.dish.Name = "dish";
            this.dish.Size = new System.Drawing.Size(596, 120);
            this.dish.TabIndex = 2;
            this.dish.Text = "Client";
            this.dish.UseVisualStyleBackColor = false;
            this.dish.Click += new System.EventHandler(this.dish_Click);
            // 
            // ingredient
            // 
            this.ingredient.BackColor = System.Drawing.Color.White;
            this.ingredient.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ingredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredient.Location = new System.Drawing.Point(20, 275);
            this.ingredient.Margin = new System.Windows.Forms.Padding(4);
            this.ingredient.Name = "ingredient";
            this.ingredient.Size = new System.Drawing.Size(596, 120);
            this.ingredient.TabIndex = 3;
            this.ingredient.Text = "Insurancesheet";
            this.ingredient.UseVisualStyleBackColor = false;
            this.ingredient.Click += new System.EventHandler(this.ingredient_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.White;
            this.product.Cursor = System.Windows.Forms.Cursors.Cross;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(20, 20);
            this.product.Margin = new System.Windows.Forms.Padding(4);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(596, 120);
            this.product.TabIndex = 4;
            this.product.Text = "Post";
            this.product.UseVisualStyleBackColor = false;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.product);
            this.Controls.Add(this.ingredient);
            this.Controls.Add(this.dish);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dish;
        private System.Windows.Forms.Button ingredient;
        private System.Windows.Forms.Button product;
    }
}

