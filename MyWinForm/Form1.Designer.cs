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
            this.msTest.SuspendLayout();
            this.cmsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTestConnection
            // 
            this.btTestConnection.Location = new System.Drawing.Point(1281, 143);
            this.btTestConnection.Name = "btTestConnection";
            this.btTestConnection.Size = new System.Drawing.Size(172, 68);
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
            this.cbCity.Location = new System.Drawing.Point(18, 212);
            this.cbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(331, 28);
            this.cbCity.TabIndex = 2;
            this.cbCity.ValueMember = "id";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(14, 182);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(65, 20);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "Города";
            // 
            // btLoadFromList
            // 
            this.btLoadFromList.Location = new System.Drawing.Point(818, 85);
            this.btLoadFromList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoadFromList.Name = "btLoadFromList";
            this.btLoadFromList.Size = new System.Drawing.Size(236, 35);
            this.btLoadFromList.TabIndex = 4;
            this.btLoadFromList.Text = "Загрузка из LIST";
            this.btLoadFromList.UseVisualStyleBackColor = true;
            this.btLoadFromList.Click += new System.EventHandler(this.btLoadFromList_Click);
            // 
            // btLoadFromDB
            // 
            this.btLoadFromDB.Location = new System.Drawing.Point(818, 160);
            this.btLoadFromDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoadFromDB.Name = "btLoadFromDB";
            this.btLoadFromDB.Size = new System.Drawing.Size(236, 35);
            this.btLoadFromDB.TabIndex = 5;
            this.btLoadFromDB.Text = "Загрузка из БД";
            this.btLoadFromDB.UseVisualStyleBackColor = true;
            this.btLoadFromDB.Click += new System.EventHandler(this.btLoadFromDB_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "name";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(22, 92);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(326, 28);
            this.cbCountry.TabIndex = 7;
            this.cbCountry.ValueMember = "id";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(107, 391);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(194, 26);
            this.tbLN.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя";
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(107, 440);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(194, 26);
            this.tbFN.TabIndex = 12;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(347, 431);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(134, 38);
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
            this.msTest.Size = new System.Drawing.Size(1660, 33);
            this.msTest.TabIndex = 19;
            this.msTest.Text = "menuStrip1";
            // 
            // meFile
            // 
            this.meFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meCreate,
            this.meOpen});
            this.meFile.Name = "meFile";
            this.meFile.Size = new System.Drawing.Size(69, 29);
            this.meFile.Text = "Файл";
            // 
            // meCreate
            // 
            this.meCreate.Name = "meCreate";
            this.meCreate.Size = new System.Drawing.Size(270, 34);
            this.meCreate.Text = "Создать";
            // 
            // meOpen
            // 
            this.meOpen.Name = "meOpen";
            this.meOpen.Size = new System.Drawing.Size(270, 34);
            this.meOpen.Text = "Открыть";
            // 
            // cmsTest
            // 
            this.cmsTest.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAlmaty,
            this.cmsAstana});
            this.cmsTest.Name = "cmsTest";
            this.cmsTest.Size = new System.Drawing.Size(241, 101);
            // 
            // cmsAlmaty
            // 
            this.cmsAlmaty.Name = "cmsAlmaty";
            this.cmsAlmaty.Size = new System.Drawing.Size(240, 32);
            this.cmsAlmaty.Text = "Almaty";
            this.cmsAlmaty.Click += new System.EventHandler(this.cmsAlmaty_Click);
            // 
            // cmsAstana
            // 
            this.cmsAstana.Name = "cmsAstana";
            this.cmsAstana.Size = new System.Drawing.Size(240, 32);
            this.cmsAstana.Text = "Astana";
            this.cmsAstana.Click += new System.EventHandler(this.cmsAlmaty_Click);
            // 
            // cbTest
            // 
            this.cbTest.ContextMenuStrip = this.cmsTest;
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(818, 437);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(348, 28);
            this.cbTest.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 955);
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
    }
}

