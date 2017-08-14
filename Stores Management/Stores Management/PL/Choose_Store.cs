using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Stores_Management.PL
{
    public partial class Choose_Store : Form
    {
        BL.Data_Store bl;
        DataTable DataTable;
        CurrencyManager CM1,CM2;
        string name_old;
        bool new_btn_clk_str = false, edit_btn_clk_str = false, edit_btn_clk_pro = false, new_btn_clk_pro = false;
        public Choose_Store()
        {
            InitializeComponent();
            bl = new BL.Data_Store();
            DataTable = new DataTable();
            DataTable = bl.select_All();
            this.dataGridView1.DataSource = DataTable;
            combo_store_names.DataSource = DataTable;
            combo_store_names.DisplayMember = "Name";
            txt_store_name.DataBindings.Add("Text", DataTable, "Name");
            txt_store_phone.DataBindings.Add("Text", DataTable, "Phone");
            txt_store_address.DataBindings.Add("Text", DataTable, "Adress");
            txt_manager_name.DataBindings.Add("Text", DataTable, "Manager");
        }
        private void newStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Choose_Store_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            edit_btn_clk_str = true;
            txt_manager_name.ReadOnly = false;
            txt_store_address.ReadOnly = false;
            txt_store_name.ReadOnly = false;
            txt_store_phone.ReadOnly = false;
            btn_open_store.Enabled = false;
            btn_new_store.Enabled = false;
            btn_edite_store.Enabled = false;
            btn_save_store.Enabled = true;
            btn_delete_store.Enabled = false;
            btn_new_product.Enabled = false;
            btn_edite_product.Enabled = false;
            btn_save_product.Enabled = false;
            btn_delete_product.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BL.Delete bl = new BL.Delete();
            bl.delete_store(combo_store_names.Text);
            MessageBox.Show("Deleted Sucsse .. !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BL.Data_Store Bl = new BL.Data_Store();
            DataTable = Bl.select_All();
            this.dataGridView1.DataSource = DataTable;
            combo_store_names.DataSource = DataTable;
            combo_store_names.DisplayMember = "Name";
            combo_store_names.SelectedIndex = 0;
            txt_store_name.Text = "";
            txt_store_phone.Text = "";
            txt_store_address.Text ="";
            txt_manager_name.Text = "";
            txt_store_name.DataBindings.Clear();
            txt_store_phone.DataBindings.Clear();
            txt_store_address.DataBindings.Clear();
            txt_manager_name.DataBindings.Clear();
            txt_store_name.DataBindings.Add("Text", DataTable, "Name");
            txt_store_phone.DataBindings.Add("Text", DataTable, "Phone");
            txt_store_address.DataBindings.Add("Text", DataTable, "Adress");
            txt_manager_name.DataBindings.Add("Text", DataTable, "Manager");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_open_store_Click(object sender, EventArgs e)
        {
            BL.data_products bl = new BL.data_products();
            DataTable = new DataTable();
            DataTable = bl.select_by_store(combo_store_names.Text);
            this.dataGridView2.DataSource = DataTable;
            combo_product_names.DataSource = DataTable;
            combo_product_names.DisplayMember = "ID";
            txt_product_id.Text = "";
            txt_product_name.Text = "";
            txt_product_price.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            txt_product_id.DataBindings.Clear();
            txt_product_name.DataBindings.Clear();
            txt_product_store_name.DataBindings.Clear();
            txt_product_price.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
            txt_product_id.DataBindings.Add("Text", DataTable, "ID");
            txt_product_name.DataBindings.Add("Text", DataTable, "Name");
            txt_product_store_name.DataBindings.Add("Text", DataTable, "Store");
            txt_product_price.DataBindings.Add("Text", DataTable, "Price");
            dateTimePicker1.DataBindings.Add("Value", DataTable, "Production");
            dateTimePicker2.DataBindings.Add("Value", DataTable, "Expiration");
            btn_new_product.Enabled = true;
            btn_edite_product.Enabled = true;
            btn_delete_product.Enabled = true;
            txt_product_store_name.Text = combo_store_names.Text;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_store_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_open_store.Enabled = true;
            btn_new_store.Enabled = true;
            btn_edite_store.Enabled = true;
            btn_save_store.Enabled = false;
            btn_delete_store.Enabled = true;
            btn_new_product.Enabled = true;
            btn_edite_product.Enabled = true;
            btn_save_product.Enabled = false;
            btn_delete_product.Enabled = true;
            if (new_btn_clk_pro == true)
            {
                new_btn_clk_pro = false;
                BL.Add bl = new BL.Add();
                bl.Add_products(txt_product_id.Text, txt_product_name.Text, name_old, txt_product_price.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                MessageBox.Show("Added Sucsse .. !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BL.data_products Bl = new BL.data_products();
                DataTable = Bl.select_by_store(name_old);
                this.dataGridView2.DataSource = DataTable;
                combo_product_names.DataSource = DataTable;
                combo_product_names.DisplayMember = "ID";
                txt_product_id.Text = "";
                txt_product_name.Text = "";
                txt_product_price.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                txt_product_id.DataBindings.Clear();
                txt_product_name.DataBindings.Clear();
                txt_product_price.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                dateTimePicker2.DataBindings.Clear();
                txt_product_id.DataBindings.Add("Text", DataTable, "ID");
                txt_product_name.DataBindings.Add("Text", DataTable, "Name");
                txt_product_price.DataBindings.Add("Text", DataTable, "Price");
                dateTimePicker1.DataBindings.Add("Text", DataTable, "Production");
                dateTimePicker2.DataBindings.Add("Text", DataTable, "Expiration");
                
            }
            else if (edit_btn_clk_pro == true)
            {
                edit_btn_clk_pro = false;
                BL.Update bl = new BL.Update();
                bl.products_update(txt_product_id.Text, txt_product_name.Text, txt_product_price.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), name_old);
                MessageBox.Show("Edited Sucsse .. !", "Edite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BL.data_products Bl = new BL.data_products();
                DataTable = Bl.select_by_store(txt_product_store_name.Text);
                this.dataGridView2.DataSource = DataTable;
                combo_product_names.DataSource = DataTable;
                combo_product_names.DisplayMember = "ID";
                txt_product_id.Text = "";
                txt_product_name.Text = "";
                txt_product_price.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                txt_product_id.DataBindings.Clear();
                txt_product_name.DataBindings.Clear();
                txt_product_price.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                dateTimePicker2.DataBindings.Clear();
                txt_product_id.DataBindings.Add("Text", DataTable, "ID");
                txt_product_name.DataBindings.Add("Text", DataTable, "Name");
                txt_product_price.DataBindings.Add("Text", DataTable, "Price");
                dateTimePicker1.DataBindings.Add("Text", DataTable, "Production");
                dateTimePicker2.DataBindings.Add("Text", DataTable, "Expiration");
            }
            txt_product_id.ReadOnly = true;
            txt_product_name.ReadOnly = true;
            txt_product_store_name.ReadOnly = true;
            txt_product_price.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btn_new_store_Click(object sender, EventArgs e)
        {
            new_btn_clk_str = true;
            txt_manager_name.ReadOnly = false;
            txt_store_address.ReadOnly = false;
            txt_store_name.ReadOnly = false;
            txt_store_phone.ReadOnly = false;
            txt_manager_name.Text = "";
            txt_store_address.Text = "";
            txt_store_name.Text = "";
            txt_store_phone.Text = "";
            btn_open_store.Enabled = false;
            btn_new_store.Enabled = false;
            btn_edite_store.Enabled = false;
            btn_save_store.Enabled =true;
            btn_delete_store.Enabled = false;
            btn_new_product.Enabled = false;
            btn_edite_product.Enabled = false;
            btn_save_product.Enabled = false;
            btn_delete_product.Enabled = false;
        }

        private void combo_product_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_manager_name.ReadOnly = true;
            txt_store_address.ReadOnly = true;
            txt_store_name.ReadOnly = true;
            txt_store_phone.ReadOnly = true;
            btn_open_store.Enabled = true;
            btn_new_store.Enabled = true;
            btn_edite_store.Enabled = true;
            btn_save_store.Enabled = false;
            btn_delete_store.Enabled = true;
            btn_new_product.Enabled = false;
            btn_edite_product.Enabled = false;
            btn_save_product.Enabled = false;
            btn_delete_product.Enabled = false;
            if (new_btn_clk_str == true)
            {
                new_btn_clk_str = false;
                BL.Add bl = new BL.Add();
                bl.Add_stors(txt_store_name.Text, txt_store_address.Text, txt_manager_name.Text, txt_store_phone.Text);
                MessageBox.Show("Added Sucsse .. !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BL.Data_Store Bl = new BL.Data_Store();
                DataTable = Bl.select_All();
                this.dataGridView1.DataSource = DataTable;
                combo_store_names.DataSource = DataTable;
                combo_store_names.DisplayMember = "Name";
                combo_store_names.SelectedIndex = 0;
                txt_store_name.Text = "";
                txt_store_phone.Text = "";
                txt_store_address.Text = "";
                txt_manager_name.Text = "";
                txt_store_name.DataBindings.Clear();
                txt_store_phone.DataBindings.Clear();
                txt_store_address.DataBindings.Clear();
                txt_manager_name.DataBindings.Clear();
                txt_store_name.DataBindings.Add("Text", DataTable, "Name");
                txt_store_phone.DataBindings.Add("Text", DataTable, "Phone");
                txt_store_address.DataBindings.Add("Text", DataTable, "Adress");
                txt_manager_name.DataBindings.Add("Text", DataTable, "Manager");
            }
            else if (edit_btn_clk_str == true)
            {
                edit_btn_clk_str = false;
                BL.Update bl=new BL.Update();
                bl.update_stores(txt_store_name.Text, txt_store_address.Text, txt_manager_name.Text, txt_store_phone.Text, combo_store_names.Text);
                MessageBox.Show("Edited Sucsse .. !", "Edite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BL.Data_Store Bl = new BL.Data_Store();
                DataTable = Bl.select_All();
                this.dataGridView1.DataSource = DataTable;
                combo_store_names.DataSource = DataTable;
                combo_store_names.DisplayMember = "Name";
                combo_store_names.SelectedIndex = 0;
                txt_store_name.Text = "";
                txt_store_phone.Text = "";
                txt_store_address.Text = "";
                txt_manager_name.Text = "";
                txt_store_name.DataBindings.Clear();
                txt_store_phone.DataBindings.Clear();
                txt_store_address.DataBindings.Clear();
                txt_manager_name.DataBindings.Clear();
                txt_store_name.DataBindings.Add("Text", DataTable, "Name");
                txt_store_phone.DataBindings.Add("Text", DataTable, "Phone");
                txt_store_address.DataBindings.Add("Text", DataTable, "Adress");
                txt_manager_name.DataBindings.Add("Text", DataTable, "Manager");
            }
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            BL.Delete bl = new BL.Delete();
            bl.delete_product(combo_product_names.Text);
            MessageBox.Show("Deleted Sucsse .. !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BL.data_products Bl = new BL.data_products();
            DataTable = new DataTable();
            DataTable = Bl.select_by_store(combo_store_names.Text);
            this.dataGridView2.DataSource = DataTable;
            combo_product_names.DataSource = DataTable;
            combo_product_names.DisplayMember = "ID";
            txt_product_id.DataBindings.Clear();
            txt_product_id.DataBindings.Add("Text", DataTable, "ID");
            txt_product_name.DataBindings.Clear();
            txt_product_name.DataBindings.Add("Text", DataTable, "Name");
            txt_product_store_name.DataBindings.Clear();
            txt_product_store_name.DataBindings.Add("Text", DataTable, "Store");
            txt_product_price.DataBindings.Clear();
            txt_product_price.DataBindings.Add("Text", DataTable, "Price");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Value", DataTable, "Production");
            dateTimePicker2.DataBindings.Clear();
            dateTimePicker2.DataBindings.Add("Value", DataTable, "Expiration");
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            new_btn_clk_pro = true;
            name_old = txt_product_store_name.Text;
            btn_open_store.Enabled = false;
            btn_new_store.Enabled = false;
            btn_edite_store.Enabled = false;
            btn_save_store.Enabled = false;
            btn_delete_store.Enabled = false;
            btn_new_product.Enabled = false;
            btn_edite_product.Enabled = false;
            btn_save_product.Enabled = true;
            btn_delete_product.Enabled = false;
            txt_product_id.Text = "";
            txt_product_name.Text = "";
            txt_product_price.Text = "";
            txt_product_id.ReadOnly = false;
            txt_product_name.ReadOnly = false;
            txt_product_price.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void btn_edite_product_Click(object sender, EventArgs e)
        {
            name_old = txt_product_name.Text;
            edit_btn_clk_pro = true;
            txt_product_id.ReadOnly = false;
            txt_product_name.ReadOnly = false;
            txt_product_store_name.ReadOnly = true;
            txt_product_price.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            btn_open_store.Enabled = false;
            btn_new_store.Enabled = false;
            btn_edite_store.Enabled = false;
            btn_save_store.Enabled = false;
            btn_delete_store.Enabled = false;
            btn_new_product.Enabled = false;
            btn_edite_product.Enabled = false;
            btn_save_product.Enabled = true;
            btn_delete_product.Enabled = false;
        }

    }
}
