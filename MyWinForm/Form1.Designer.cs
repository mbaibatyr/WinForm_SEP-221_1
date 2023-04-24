namespace MyWinForm
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
            this.btTestConnection = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.btLoadFromList = new System.Windows.Forms.Button();
            this.btLoadFromDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTestConnection
            // 
            this.btTestConnection.Location = new System.Drawing.Point(707, 90);
            this.btTestConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTestConnection.Name = "btTestConnection";
            this.btTestConnection.Size = new System.Drawing.Size(115, 44);
            this.btTestConnection.TabIndex = 1;
            this.btTestConnection.Text = "Тест соединение";
            this.btTestConnection.UseVisualStyleBackColor = true;
            this.btTestConnection.Click += new System.EventHandler(this.btTestConnection_Click);
            // 
            // cbCity
            // 
            this.cbCity.DisplayMember = "name";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Алматы",
            "Астана",
            "Актобе"});
            this.cbCity.Location = new System.Drawing.Point(79, 57);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(222, 21);
            this.cbCity.TabIndex = 2;
            this.cbCity.ValueMember = "id";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(76, 37);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(43, 13);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "Города";
            // 
            // btLoadFromList
            // 
            this.btLoadFromList.Location = new System.Drawing.Point(340, 55);
            this.btLoadFromList.Name = "btLoadFromList";
            this.btLoadFromList.Size = new System.Drawing.Size(157, 23);
            this.btLoadFromList.TabIndex = 4;
            this.btLoadFromList.Text = "Загрузка из LIST";
            this.btLoadFromList.UseVisualStyleBackColor = true;
            this.btLoadFromList.Click += new System.EventHandler(this.btLoadFromList_Click);
            // 
            // btLoadFromDB
            // 
            this.btLoadFromDB.Location = new System.Drawing.Point(340, 104);
            this.btLoadFromDB.Name = "btLoadFromDB";
            this.btLoadFromDB.Size = new System.Drawing.Size(157, 23);
            this.btLoadFromDB.TabIndex = 5;
            this.btLoadFromDB.Text = "Загрузка из БД";
            this.btLoadFromDB.UseVisualStyleBackColor = true;
            this.btLoadFromDB.Click += new System.EventHandler(this.btLoadFromDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.btLoadFromDB);
            this.Controls.Add(this.btLoadFromList);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.btTestConnection);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTestConnection;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Button btLoadFromList;
        private System.Windows.Forms.Button btLoadFromDB;
    }
}

