namespace ink
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            airflowDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lossesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pipelenghtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            airFlowBindingSource = new BindingSource(components);
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameairDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airFlowBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 447);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DeepSkyBlue;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "AirFlow";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(561, 266);
            button4.Name = "button4";
            button4.Size = new Size(222, 28);
            button4.TabIndex = 16;
            button4.Text = "Удаление массива";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(673, 166);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 15;
            label6.Text = "pipe_lenght";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(671, 189);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 27);
            textBox6.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, airflowDataGridViewTextBoxColumn, lossesDataGridViewTextBoxColumn, pipelenghtDataGridViewTextBoxColumn });
            dataGridView1.DataSource = airFlowBindingSource;
            dataGridView1.Location = new Point(-4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(546, 411);
            dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // airflowDataGridViewTextBoxColumn
            // 
            airflowDataGridViewTextBoxColumn.DataPropertyName = "air_flow";
            airflowDataGridViewTextBoxColumn.HeaderText = "air_flow";
            airflowDataGridViewTextBoxColumn.MinimumWidth = 6;
            airflowDataGridViewTextBoxColumn.Name = "airflowDataGridViewTextBoxColumn";
            airflowDataGridViewTextBoxColumn.Width = 125;
            // 
            // lossesDataGridViewTextBoxColumn
            // 
            lossesDataGridViewTextBoxColumn.DataPropertyName = "losses";
            lossesDataGridViewTextBoxColumn.HeaderText = "losses";
            lossesDataGridViewTextBoxColumn.MinimumWidth = 6;
            lossesDataGridViewTextBoxColumn.Name = "lossesDataGridViewTextBoxColumn";
            lossesDataGridViewTextBoxColumn.Width = 125;
            // 
            // pipelenghtDataGridViewTextBoxColumn
            // 
            pipelenghtDataGridViewTextBoxColumn.DataPropertyName = "pipe_lenght";
            pipelenghtDataGridViewTextBoxColumn.HeaderText = "pipe_lenght";
            pipelenghtDataGridViewTextBoxColumn.MinimumWidth = 6;
            pipelenghtDataGridViewTextBoxColumn.Name = "pipelenghtDataGridViewTextBoxColumn";
            pipelenghtDataGridViewTextBoxColumn.Width = 125;
            // 
            // airFlowBindingSource
            // 
            airFlowBindingSource.DataSource = typeof(AirFlow);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(673, 113);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "losses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(671, 60);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "air_flow";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(673, 3);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 10;
            label3.Text = "id";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(673, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(673, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(115, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(671, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 27);
            textBox3.TabIndex = 7;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(561, 232);
            button8.Name = "button8";
            button8.Size = new Size(222, 28);
            button8.TabIndex = 6;
            button8.Text = "Добавление массива";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(548, 113);
            button7.Name = "button7";
            button7.Size = new Size(117, 29);
            button7.TabIndex = 5;
            button7.Text = "Удаление";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(548, 170);
            button6.Name = "button6";
            button6.Size = new Size(117, 29);
            button6.TabIndex = 4;
            button6.Text = "Обновление";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(548, 60);
            button5.Name = "button5";
            button5.Size = new Size(117, 29);
            button5.TabIndex = 3;
            button5.Text = "Добавление";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(551, 372);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Вывод";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(611, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(561, 313);
            button1.Name = "button1";
            button1.Size = new Size(227, 53);
            button1.TabIndex = 0;
            button1.Text = "Рассчет V подаваемого воздуха в час";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DeepSkyBlue;
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Volume";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameairDataGridViewTextBoxColumn, volumeDataGridViewTextBoxColumn });
            dataGridView2.DataSource = volumeBindingSource;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(430, 418);
            dataGridView2.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            idDataGridViewTextBoxColumn1.HeaderText = "id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameairDataGridViewTextBoxColumn
            // 
            nameairDataGridViewTextBoxColumn.DataPropertyName = "name_air";
            nameairDataGridViewTextBoxColumn.HeaderText = "name_air";
            nameairDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameairDataGridViewTextBoxColumn.Name = "nameairDataGridViewTextBoxColumn";
            nameairDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeBindingSource
            // 
            volumeBindingSource.DataSource = typeof(Volume);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(497, 306);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Вывод";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(497, 113);
            button3.Name = "button3";
            button3.Size = new Size(247, 43);
            button3.TabIndex = 1;
            button3.Text = "Сортировка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(497, 191);
            button2.Name = "button2";
            button2.Size = new Size(247, 71);
            button2.TabIndex = 0;
            button2.Text = "Рассчет времени  заполнения";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)airFlowBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn airflowDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lossesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pipelenghtDataGridViewTextBoxColumn;
        private BindingSource airFlowBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameairDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private BindingSource volumeBindingSource;
        private TextBox textBox6;
        private Label label6;
        private Button button4;
    }
}