using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_products
{
    public partial class NewProductForm : Form
    {
        public string product_name;
        public string manufacturer_name;
        public string price;

        public NewProductForm()
        {
            InitializeComponent();
            new_product_add_button.Click += add_new_product_click;
            cancel_button.Click += cancel_click;
        }

        private void add_new_product_click(object sender, EventArgs e) 
        { 
            product_name = product_name_text_box.Text;
            manufacturer_name = manufacturer_name_text_box.Text;
            price = price_text_box.Text;
        }
        private void cancel_click(object sender, EventArgs e) { 
            this.Close();
        }

    }
}
