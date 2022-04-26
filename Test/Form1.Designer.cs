
namespace Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testAutorizationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testAutorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testBdDataSet = new Test.TestBdDataSet();
            this.testAutorizationTableAdapter = new Test.TestBdDataSetTableAdapters.TestAutorizationTableAdapter();
            this.MainMenuDeleteButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.testTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTable2TableAdapter = new Test.TestBdDataSetTableAdapters.TestTable2TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.testTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testId2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testAutorizationIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testData2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.testTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTable1TableAdapter = new Test.TestBdDataSetTableAdapters.TestTable1TableAdapter();
            this.testId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testData2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTable2IdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.testId1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testData2DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTable2IdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testAutorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable1BindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=WIN-VV8FA29SI22\\SQLEXPRESS;Initial Catalog=TestBd;Integrated Security" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TestAutorization", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TestId1", "TestId1"),
                        new System.Data.Common.DataColumnMapping("TestData", "TestData"),
                        new System.Data.Common.DataColumnMapping("TestData2", "TestData2"),
                        new System.Data.Common.DataColumnMapping("TestTable2Id", "TestTable2Id"),
                        new System.Data.Common.DataColumnMapping("TestAutorizationId", "TestAutorizationId"),
                        new System.Data.Common.DataColumnMapping("Login", "Login"),
                        new System.Data.Common.DataColumnMapping("Password", "Password"),
                        new System.Data.Common.DataColumnMapping("TestId2", "TestId2"),
                        new System.Data.Common.DataColumnMapping("TestAutorizationId1", "TestAutorizationId1"),
                        new System.Data.Common.DataColumnMapping("TestData1", "TestData1"),
                        new System.Data.Common.DataColumnMapping("TestData21", "TestData21")})});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testAutorizationIdDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testAutorizationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // testAutorizationIdDataGridViewTextBoxColumn
            // 
            this.testAutorizationIdDataGridViewTextBoxColumn.DataPropertyName = "TestAutorizationId";
            this.testAutorizationIdDataGridViewTextBoxColumn.HeaderText = "TestAutorizationId";
            this.testAutorizationIdDataGridViewTextBoxColumn.Name = "testAutorizationIdDataGridViewTextBoxColumn";
            this.testAutorizationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // testAutorizationBindingSource
            // 
            this.testAutorizationBindingSource.DataMember = "TestAutorization";
            this.testAutorizationBindingSource.DataSource = this.testBdDataSet;
            // 
            // testBdDataSet
            // 
            this.testBdDataSet.DataSetName = "TestBdDataSet";
            this.testBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testAutorizationTableAdapter
            // 
            this.testAutorizationTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenuDeleteButton1
            // 
            this.MainMenuDeleteButton1.Location = new System.Drawing.Point(6, 159);
            this.MainMenuDeleteButton1.Name = "MainMenuDeleteButton1";
            this.MainMenuDeleteButton1.Size = new System.Drawing.Size(75, 23);
            this.MainMenuDeleteButton1.TabIndex = 1;
            this.MainMenuDeleteButton1.Text = "Удалить";
            this.MainMenuDeleteButton1.UseVisualStyleBackColor = true;
            this.MainMenuDeleteButton1.Click += new System.EventHandler(this.MainMenuDeleteButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // testTable2BindingSource
            // 
            this.testTable2BindingSource.DataMember = "TestTable2";
            this.testTable2BindingSource.DataSource = this.testBdDataSet;
            // 
            // testTable2TableAdapter
            // 
            this.testTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testId2DataGridViewTextBoxColumn,
            this.testAutorizationIdDataGridViewTextBoxColumn1,
            this.testDataDataGridViewTextBoxColumn,
            this.testData2DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.testTable2BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(379, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // testTable2BindingSource1
            // 
            this.testTable2BindingSource1.DataMember = "TestTable2";
            this.testTable2BindingSource1.DataSource = this.testBdDataSet;
            // 
            // testId2DataGridViewTextBoxColumn
            // 
            this.testId2DataGridViewTextBoxColumn.DataPropertyName = "TestId2";
            this.testId2DataGridViewTextBoxColumn.HeaderText = "TestId2";
            this.testId2DataGridViewTextBoxColumn.Name = "testId2DataGridViewTextBoxColumn";
            this.testId2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testAutorizationIdDataGridViewTextBoxColumn1
            // 
            this.testAutorizationIdDataGridViewTextBoxColumn1.DataPropertyName = "TestAutorizationId";
            this.testAutorizationIdDataGridViewTextBoxColumn1.HeaderText = "TestAutorizationId";
            this.testAutorizationIdDataGridViewTextBoxColumn1.Name = "testAutorizationIdDataGridViewTextBoxColumn1";
            // 
            // testDataDataGridViewTextBoxColumn
            // 
            this.testDataDataGridViewTextBoxColumn.DataPropertyName = "TestData";
            this.testDataDataGridViewTextBoxColumn.HeaderText = "TestData";
            this.testDataDataGridViewTextBoxColumn.Name = "testDataDataGridViewTextBoxColumn";
            // 
            // testData2DataGridViewTextBoxColumn
            // 
            this.testData2DataGridViewTextBoxColumn.DataPropertyName = "TestData2";
            this.testData2DataGridViewTextBoxColumn.HeaderText = "TestData2";
            this.testData2DataGridViewTextBoxColumn.Name = "testData2DataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testId1DataGridViewTextBoxColumn,
            this.testDataDataGridViewTextBoxColumn1,
            this.testData2DataGridViewTextBoxColumn1,
            this.testTable2IdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.testTable1BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(349, 150);
            this.dataGridView3.TabIndex = 5;
            // 
            // testTable1BindingSource
            // 
            this.testTable1BindingSource.DataMember = "TestTable1";
            this.testTable1BindingSource.DataSource = this.testBdDataSet;
            // 
            // testTable1TableAdapter
            // 
            this.testTable1TableAdapter.ClearBeforeFill = true;
            // 
            // testId1DataGridViewTextBoxColumn
            // 
            this.testId1DataGridViewTextBoxColumn.DataPropertyName = "TestId1";
            this.testId1DataGridViewTextBoxColumn.HeaderText = "TestId1";
            this.testId1DataGridViewTextBoxColumn.Name = "testId1DataGridViewTextBoxColumn";
            this.testId1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDataDataGridViewTextBoxColumn1
            // 
            this.testDataDataGridViewTextBoxColumn1.DataPropertyName = "TestData";
            this.testDataDataGridViewTextBoxColumn1.HeaderText = "TestData";
            this.testDataDataGridViewTextBoxColumn1.Name = "testDataDataGridViewTextBoxColumn1";
            // 
            // testData2DataGridViewTextBoxColumn1
            // 
            this.testData2DataGridViewTextBoxColumn1.DataPropertyName = "TestData2";
            this.testData2DataGridViewTextBoxColumn1.HeaderText = "TestData2";
            this.testData2DataGridViewTextBoxColumn1.Name = "testData2DataGridViewTextBoxColumn1";
            // 
            // testTable2IdDataGridViewTextBoxColumn
            // 
            this.testTable2IdDataGridViewTextBoxColumn.DataPropertyName = "TestTable2Id";
            this.testTable2IdDataGridViewTextBoxColumn.HeaderText = "TestTable2Id";
            this.testTable2IdDataGridViewTextBoxColumn.Name = "testTable2IdDataGridViewTextBoxColumn";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(168, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(87, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testId1DataGridViewTextBoxColumn1,
            this.testDataDataGridViewTextBoxColumn2,
            this.testData2DataGridViewTextBoxColumn2,
            this.testTable2IdDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.testTable1BindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(58, 54);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(432, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // testId1DataGridViewTextBoxColumn1
            // 
            this.testId1DataGridViewTextBoxColumn1.DataPropertyName = "TestId1";
            this.testId1DataGridViewTextBoxColumn1.HeaderText = "TestId1";
            this.testId1DataGridViewTextBoxColumn1.Name = "testId1DataGridViewTextBoxColumn1";
            this.testId1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // testDataDataGridViewTextBoxColumn2
            // 
            this.testDataDataGridViewTextBoxColumn2.DataPropertyName = "TestData";
            this.testDataDataGridViewTextBoxColumn2.HeaderText = "TestData";
            this.testDataDataGridViewTextBoxColumn2.Name = "testDataDataGridViewTextBoxColumn2";
            // 
            // testData2DataGridViewTextBoxColumn2
            // 
            this.testData2DataGridViewTextBoxColumn2.DataPropertyName = "TestData2";
            this.testData2DataGridViewTextBoxColumn2.HeaderText = "TestData2";
            this.testData2DataGridViewTextBoxColumn2.Name = "testData2DataGridViewTextBoxColumn2";
            // 
            // testTable2IdDataGridViewTextBoxColumn1
            // 
            this.testTable2IdDataGridViewTextBoxColumn1.DataPropertyName = "TestTable2Id";
            this.testTable2IdDataGridViewTextBoxColumn1.HeaderText = "TestTable2Id";
            this.testTable2IdDataGridViewTextBoxColumn1.Name = "testTable2IdDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testAutorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable1BindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestBdDataSet testBdDataSet;
        private System.Windows.Forms.BindingSource testAutorizationBindingSource;
        private TestBdDataSetTableAdapters.TestAutorizationTableAdapter testAutorizationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn testAutorizationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button MainMenuDeleteButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource testTable2BindingSource;
        private TestBdDataSetTableAdapters.TestTable2TableAdapter testTable2TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testAutorizationIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testData2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testTable2BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource testTable1BindingSource;
        private TestBdDataSetTableAdapters.TestTable1TableAdapter testTable1TableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testData2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTable2IdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn testData2DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTable2IdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

