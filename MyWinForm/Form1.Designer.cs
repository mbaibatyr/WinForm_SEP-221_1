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
            this.components = new System.ComponentModel.Container();
            this.btTestConnection = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.btLoadFromList = new System.Windows.Forms.Button();
            this.btLoadFromDB = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.msTest = new System.Windows.Forms.MenuStrip();
            this.meFile = new System.Windows.Forms.ToolStripMenuItem();
            this.meCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.meOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAlmaty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAstana = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btColor = new System.Windows.Forms.Button();
            this.msTest.SuspendLayout();
            this.cmsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTestConnection
            // 
            this.btTestConnection.Location = new System.Drawing.Point(854, 93);
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
            this.cbCity.Location = new System.Drawing.Point(12, 138);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(222, 21);
            this.cbCity.TabIndex = 2;
            this.cbCity.ValueMember = "id";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(9, 118);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(43, 13);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "Города";
            // 
            // btLoadFromList
            // 
            this.btLoadFromList.Location = new System.Drawing.Point(545, 55);
            this.btLoadFromList.Name = "btLoadFromList";
            this.btLoadFromList.Size = new System.Drawing.Size(157, 23);
            this.btLoadFromList.TabIndex = 4;
            this.btLoadFromList.Text = "Загрузка из LIST";
            this.btLoadFromList.UseVisualStyleBackColor = true;
            this.btLoadFromList.Click += new System.EventHandler(this.btLoadFromList_Click);
            // 
            // btLoadFromDB
            // 
            this.btLoadFromDB.Location = new System.Drawing.Point(545, 104);
            this.btLoadFromDB.Name = "btLoadFromDB";
            this.btLoadFromDB.Size = new System.Drawing.Size(157, 23);
            this.btLoadFromDB.TabIndex = 5;
            this.btLoadFromDB.Text = "Загрузка из БД";
            this.btLoadFromDB.UseVisualStyleBackColor = true;
            this.btLoadFromDB.Click += new System.EventHandler(this.btLoadFromDB_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "name";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(15, 60);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(219, 21);
            this.cbCountry.TabIndex = 7;
            this.cbCountry.ValueMember = "id";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(71, 254);
            this.tbLN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(131, 20);
            this.tbLN.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя";
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(71, 286);
            this.tbFN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(131, 20);
            this.tbFN.TabIndex = 12;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(231, 280);
            this.btSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(89, 25);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "СОхранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // msTest
            // 
            this.msTest.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meFile});
            this.msTest.Location = new System.Drawing.Point(0, 0);
            this.msTest.Name = "msTest";
            this.msTest.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.msTest.Size = new System.Drawing.Size(1107, 24);
            this.msTest.TabIndex = 19;
            this.msTest.Text = "menuStrip1";
            // 
            // meFile
            // 
            this.meFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meCreate,
            this.meOpen});
            this.meFile.Name = "meFile";
            this.meFile.Size = new System.Drawing.Size(48, 22);
            this.meFile.Text = "Файл";
            // 
            // meCreate
            // 
            this.meCreate.Name = "meCreate";
            this.meCreate.Size = new System.Drawing.Size(121, 22);
            this.meCreate.Text = "Создать";
            // 
            // meOpen
            // 
            this.meOpen.Name = "meOpen";
            this.meOpen.Size = new System.Drawing.Size(121, 22);
            this.meOpen.Text = "Открыть";
            // 
            // cmsTest
            // 
            this.cmsTest.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAlmaty,
            this.cmsAstana});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(113, 48);
            // 
            // cmsAlmaty
            // 
            this.cmsAlmaty.Name = "cmsAlmaty";
            this.cmsAlmaty.Size = new System.Drawing.Size(112, 22);
            this.cmsAlmaty.Text = "Almaty";
            this.cmsAlmaty.Click += new System.EventHandler(this.cmsAlmaty_Click);
            // 
            // cmsAstana
            // 
            this.cmsAstana.Name = "cmsAstana";
            this.cmsAstana.Size = new System.Drawing.Size(112, 22);
            this.cmsAstana.Text = "Astana";
            this.cmsAstana.Click += new System.EventHandler(this.cmsAlmaty_Click);
            // 
            // cbTest
            // 
            this.cbTest.ContextMenuStrip = this.cmsTest;
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(545, 284);
            this.cbTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(233, 21);
            this.cbTest.TabIndex = 21;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(545, 343);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(233, 21);
            this.cbColor.TabIndex = 22;
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(810, 343);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(75, 23);
            this.btColor.TabIndex = 23;
            this.btColor.Text = "Цвета";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 621);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btLoadFromDB);
            this.Controls.Add(this.btLoadFromList);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.btTestConnection);
            this.Controls.Add(this.msTest);
            this.MainMenuStrip = this.msTest;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msTest.ResumeLayout(false);
            this.msTest.PerformLayout();
            this.cmsTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTestConnection;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Button btLoadFromList;
        private System.Windows.Forms.Button btLoadFromDB;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.MenuStrip msTest;
        private System.Windows.Forms.ToolStripMenuItem meFile;
        private System.Windows.Forms.ToolStripMenuItem meCreate;
        private System.Windows.Forms.ToolStripMenuItem meOpen;
        private System.Windows.Forms.ContextMenuStrip cmsTest;
        private System.Windows.Forms.ToolStripMenuItem cmsAlmaty;
        private System.Windows.Forms.ToolStripMenuItem cmsAstana;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btColor;
    }
}

