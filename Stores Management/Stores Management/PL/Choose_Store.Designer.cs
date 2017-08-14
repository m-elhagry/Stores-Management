namespace Stores_Management.PL
{
    partial class Choose_Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_open_store = new System.Windows.Forms.Button();
            this.btn_new_store = new System.Windows.Forms.Button();
            this.combo_store_names = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save_store = new System.Windows.Forms.Button();
            this.btn_delete_store = new System.Windows.Forms.Button();
            this.btn_edite_store = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_save_product = new System.Windows.Forms.Button();
            this.btn_delete_product = new System.Windows.Forms.Button();
            this.btn_new_product = new System.Windows.Forms.Button();
            this.btn_edite_product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_product_names = new System.Windows.Forms.ComboBox();
            this.txt_store_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_manager_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_store_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_store_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_product_store_name = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open_store
            // 
            this.btn_open_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open_store.Location = new System.Drawing.Point(10, 20);
            this.btn_open_store.Name = "btn_open_store";
            this.btn_open_store.Size = new System.Drawing.Size(109, 23);
            this.btn_open_store.TabIndex = 0;
            this.btn_open_store.Text = "Open Products";
            this.btn_open_store.UseVisualStyleBackColor = true;
            this.btn_open_store.Click += new System.EventHandler(this.btn_open_store_Click);
            // 
            // btn_new_store
            // 
            this.btn_new_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_store.Location = new System.Drawing.Point(125, 20);
            this.btn_new_store.Name = "btn_new_store";
            this.btn_new_store.Size = new System.Drawing.Size(68, 23);
            this.btn_new_store.TabIndex = 1;
            this.btn_new_store.Text = "New";
            this.btn_new_store.UseVisualStyleBackColor = true;
            this.btn_new_store.Click += new System.EventHandler(this.btn_new_store_Click);
            // 
            // combo_store_names
            // 
            this.combo_store_names.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_store_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_store_names.FormattingEnabled = true;
            this.combo_store_names.Location = new System.Drawing.Point(83, 17);
            this.combo_store_names.Name = "combo_store_names";
            this.combo_store_names.Size = new System.Drawing.Size(171, 21);
            this.combo_store_names.TabIndex = 4;
            this.combo_store_names.SelectedIndexChanged += new System.EventHandler(this.combo_store_names_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 144);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 23);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(429, 256);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_save_store);
            this.groupBox1.Controls.Add(this.btn_delete_store);
            this.groupBox1.Controls.Add(this.btn_new_store);
            this.groupBox1.Controls.Add(this.btn_open_store);
            this.groupBox1.Controls.Add(this.btn_edite_store);
            this.groupBox1.Location = new System.Drawing.Point(260, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Options";
            // 
            // btn_save_store
            // 
            this.btn_save_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_store.Enabled = false;
            this.btn_save_store.Location = new System.Drawing.Point(277, 20);
            this.btn_save_store.Name = "btn_save_store";
            this.btn_save_store.Size = new System.Drawing.Size(72, 23);
            this.btn_save_store.TabIndex = 6;
            this.btn_save_store.Text = "Save";
            this.btn_save_store.UseVisualStyleBackColor = true;
            this.btn_save_store.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete_store
            // 
            this.btn_delete_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_store.Location = new System.Drawing.Point(355, 19);
            this.btn_delete_store.Name = "btn_delete_store";
            this.btn_delete_store.Size = new System.Drawing.Size(68, 23);
            this.btn_delete_store.TabIndex = 4;
            this.btn_delete_store.Text = "Delete";
            this.btn_delete_store.UseVisualStyleBackColor = true;
            this.btn_delete_store.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_edite_store
            // 
            this.btn_edite_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edite_store.Location = new System.Drawing.Point(199, 20);
            this.btn_edite_store.Name = "btn_edite_store";
            this.btn_edite_store.Size = new System.Drawing.Size(72, 23);
            this.btn_edite_store.TabIndex = 5;
            this.btn_edite_store.Text = "Edite";
            this.btn_edite_store.UseVisualStyleBackColor = true;
            this.btn_edite_store.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_save_product);
            this.groupBox2.Controls.Add(this.btn_delete_product);
            this.groupBox2.Controls.Add(this.btn_new_product);
            this.groupBox2.Controls.Add(this.btn_edite_product);
            this.groupBox2.Location = new System.Drawing.Point(260, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Options";
            // 
            // btn_save_product
            // 
            this.btn_save_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_product.Enabled = false;
            this.btn_save_product.Location = new System.Drawing.Point(162, 20);
            this.btn_save_product.Name = "btn_save_product";
            this.btn_save_product.Size = new System.Drawing.Size(72, 23);
            this.btn_save_product.TabIndex = 9;
            this.btn_save_product.Text = "Save";
            this.btn_save_product.UseVisualStyleBackColor = true;
            this.btn_save_product.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_product.Enabled = false;
            this.btn_delete_product.Location = new System.Drawing.Point(240, 20);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(68, 23);
            this.btn_delete_product.TabIndex = 7;
            this.btn_delete_product.Text = "Delete";
            this.btn_delete_product.UseVisualStyleBackColor = true;
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // btn_new_product
            // 
            this.btn_new_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_product.Enabled = false;
            this.btn_new_product.Location = new System.Drawing.Point(10, 20);
            this.btn_new_product.Name = "btn_new_product";
            this.btn_new_product.Size = new System.Drawing.Size(68, 23);
            this.btn_new_product.TabIndex = 6;
            this.btn_new_product.Text = "New";
            this.btn_new_product.UseVisualStyleBackColor = true;
            this.btn_new_product.Click += new System.EventHandler(this.btn_new_product_Click);
            // 
            // btn_edite_product
            // 
            this.btn_edite_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edite_product.Enabled = false;
            this.btn_edite_product.Location = new System.Drawing.Point(84, 20);
            this.btn_edite_product.Name = "btn_edite_product";
            this.btn_edite_product.Size = new System.Drawing.Size(72, 23);
            this.btn_edite_product.TabIndex = 8;
            this.btn_edite_product.Text = "Edite";
            this.btn_edite_product.UseVisualStyleBackColor = true;
            this.btn_edite_product.Click += new System.EventHandler(this.btn_edite_product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Store Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product ID :";
            // 
            // combo_product_names
            // 
            this.combo_product_names.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_product_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_product_names.FormattingEnabled = true;
            this.combo_product_names.Location = new System.Drawing.Point(83, 23);
            this.combo_product_names.Name = "combo_product_names";
            this.combo_product_names.Size = new System.Drawing.Size(171, 21);
            this.combo_product_names.TabIndex = 10;
            this.combo_product_names.SelectedIndexChanged += new System.EventHandler(this.combo_product_names_SelectedIndexChanged);
            // 
            // txt_store_name
            // 
            this.txt_store_name.Location = new System.Drawing.Point(92, 28);
            this.txt_store_name.Name = "txt_store_name";
            this.txt_store_name.ReadOnly = true;
            this.txt_store_name.Size = new System.Drawing.Size(133, 20);
            this.txt_store_name.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Store Name :";
            // 
            // txt_manager_name
            // 
            this.txt_manager_name.Location = new System.Drawing.Point(92, 63);
            this.txt_manager_name.Name = "txt_manager_name";
            this.txt_manager_name.ReadOnly = true;
            this.txt_manager_name.Size = new System.Drawing.Size(133, 20);
            this.txt_manager_name.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Manager Name :";
            // 
            // txt_store_phone
            // 
            this.txt_store_phone.Location = new System.Drawing.Point(92, 133);
            this.txt_store_phone.Name = "txt_store_phone";
            this.txt_store_phone.ReadOnly = true;
            this.txt_store_phone.Size = new System.Drawing.Size(133, 20);
            this.txt_store_phone.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Store Phone :";
            // 
            // txt_store_address
            // 
            this.txt_store_address.Location = new System.Drawing.Point(92, 97);
            this.txt_store_address.Name = "txt_store_address";
            this.txt_store_address.ReadOnly = true;
            this.txt_store_address.Size = new System.Drawing.Size(133, 20);
            this.txt_store_address.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "StoreAddress :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_store_phone);
            this.groupBox3.Controls.Add(this.txt_store_name);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_store_address);
            this.groupBox3.Controls.Add(this.txt_manager_name);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 170);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Store Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_product_price);
            this.groupBox4.Controls.Add(this.txt_product_id);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_product_store_name);
            this.groupBox4.Controls.Add(this.txt_product_name);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(8, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 280);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Info";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Production :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Expiration :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product ID :";
            // 
            // txt_product_price
            // 
            this.txt_product_price.Location = new System.Drawing.Point(92, 137);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.ReadOnly = true;
            this.txt_product_price.Size = new System.Drawing.Size(133, 20);
            this.txt_product_price.TabIndex = 21;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Location = new System.Drawing.Point(92, 32);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.ReadOnly = true;
            this.txt_product_id.Size = new System.Drawing.Size(133, 20);
            this.txt_product_id.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Product Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Product Name :";
            // 
            // txt_product_store_name
            // 
            this.txt_product_store_name.Location = new System.Drawing.Point(92, 101);
            this.txt_product_store_name.Name = "txt_product_store_name";
            this.txt_product_store_name.ReadOnly = true;
            this.txt_product_store_name.Size = new System.Drawing.Size(133, 20);
            this.txt_product_store_name.TabIndex = 19;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(92, 67);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.ReadOnly = true;
            this.txt_product_name.Size = new System.Drawing.Size(133, 20);
            this.txt_product_name.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Store Name :";
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(606, 305);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(77, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.combo_store_names);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(701, 224);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stores";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Controls.Add(this.exit);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.combo_product_names);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(12, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(701, 347);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Products";
            // 
            // Choose_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(726, 601);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 640);
            this.MinimumSize = new System.Drawing.Size(742, 640);
            this.Name = "Choose_Store";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Management";
            this.Load += new System.EventHandler(this.Choose_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open_store;
        private System.Windows.Forms.Button btn_new_store;
        private System.Windows.Forms.ComboBox combo_store_names;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_store;
        private System.Windows.Forms.Button btn_edite_store;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_product_names;
        private System.Windows.Forms.TextBox txt_store_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete_product;
        private System.Windows.Forms.Button btn_new_product;
        private System.Windows.Forms.Button btn_edite_product;
        private System.Windows.Forms.TextBox txt_manager_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_store_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_store_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_product_store_name;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_save_store;
        private System.Windows.Forms.Button btn_save_product;

    }
}