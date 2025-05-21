namespace store_products
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
            this.all_products_list_box = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // all_products_list_box
            // 
            this.all_products_list_box.FormattingEnabled = true;
            this.all_products_list_box.Location = new System.Drawing.Point(12, 12);
            this.all_products_list_box.Name = "all_products_list_box";
            this.all_products_list_box.Size = new System.Drawing.Size(493, 641);
            this.all_products_list_box.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(586, 188);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(248, 44);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Добавить товар";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(586, 238);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(248, 44);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Изменить товар";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(586, 288);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(248, 44);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "Удалить товар";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(586, 338);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(248, 44);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Очистить список";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(586, 388);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(248, 44);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Сохранить данные";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_button.Location = new System.Drawing.Point(586, 438);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(248, 44);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "Загрузить данные";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 667);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.all_products_list_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox all_products_list_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
    }
}

