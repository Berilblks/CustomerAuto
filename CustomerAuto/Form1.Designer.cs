namespace CustomerAuto
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAdress = new TextBox();
            textBoxLoan = new TextBox();
            textBoxIncome = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxCustomerID = new TextBox();
            buttonClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 398);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1093, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonClear);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxAdress);
            panel2.Controls.Add(textBoxLoan);
            panel2.Controls.Add(textBoxIncome);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(textBoxSurname);
            panel2.Controls.Add(textBoxCustomerID);
            panel2.Location = new Point(26, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 246);
            panel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(458, 64);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 42);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 185);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Adress :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 152);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 10;
            label5.Text = "Suitable Loan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 119);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 9;
            label4.Text = "Montly Income :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 86);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Surname :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 6;
            label1.Text = "Customer ID :";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(193, 178);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(231, 27);
            textBoxAdress.TabIndex = 5;
            // 
            // textBoxLoan
            // 
            textBoxLoan.Enabled = false;
            textBoxLoan.Location = new Point(193, 145);
            textBoxLoan.Name = "textBoxLoan";
            textBoxLoan.Size = new Size(231, 27);
            textBoxLoan.TabIndex = 4;
            // 
            // textBoxIncome
            // 
            textBoxIncome.Location = new Point(193, 112);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(231, 27);
            textBoxIncome.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(193, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(231, 27);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(193, 79);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(231, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Enabled = false;
            textBoxCustomerID.Location = new Point(193, 13);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(231, 27);
            textBoxCustomerID.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(458, 119);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(119, 42);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 722);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxIncome;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxCustomerID;
        private TextBox textBoxAdress;
        private TextBox textBoxLoan;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Button buttonAdd;
        private Button buttonClear;
    }
}
