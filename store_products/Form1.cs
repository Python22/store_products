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
    public partial class Form1 : Form
    {
        public List<Product> all_products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            add_button.Click += add_product;
            delete_button.Click += delete_product;
            edit_button.Click += edit_product;
            clear_button.Click += clear_products;
            save_button.Click += save_data;
            load_button.Click += load_data;

            all_products.Add(new Product("i5-13500", "Intel", 15000));
            all_products.Add(new Product("i3-13300", "Intel", 10000));
            all_products.Add(new Product("i7-13700", "Intel", 22000));
            update_product_display_list();
        }

        private void update_product_display_list()
        {
            all_products_list_box.DataSource = all_products;
            
        }

        private void add_product(object sender, EventArgs e) 
        {
            using (NewProductForm new_product_form = new NewProductForm())
            {
                if (new_product_form.ShowDialog() == DialogResult.OK)
                {
                    all_products.Add(new Product(
                        new_product_form.product_name,
                        new_product_form.manufacturer_name,
                        Convert.ToDouble(new_product_form.price)
                        )
                    );
                    update_product_display_list();
                }
            }
        }
        private void delete_product(object sender, EventArgs e) { }
        private void edit_product(object sender, EventArgs e) { }
        private void clear_products(object sender, EventArgs e) { }
        private void save_data(object sender, EventArgs e) { }
        private void load_data(object sender, EventArgs e) { }
    }

    public class Product
    {
        public string name;
        public string manufacturer;
        public double price;

        public Product() 
        {
            this.name = "No name";
            this.manufacturer = "No data";
            this.price = 0.0;
        }

        public Product(string name, string manufacturer, double price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public override string ToString() 
        {
            return $"{this.name}; {this.manufacturer}; {this.price}";
        }
    }
}
