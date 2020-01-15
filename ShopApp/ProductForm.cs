using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class ProductForm : Form
    {
        ShopDB dB = new ShopDB();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            string productname = txtprdct.Text;
            string prodctPrice = txtprdcprice.Text;
            string prodctdes = richtxtdescrpt.Text;

            Product product = new Product();

            product.ProductName = productname;
            product.Price =Convert.ToDouble(prodctPrice);
            product.Description = prodctdes;
            dB.Products.Add(product);
            if (txtprdcprice.Text!="" && txtprdct.Text!= "" && richtxtdescrpt.Text!="")
            {
                MessageBox.Show("FILL");
            }
            dB.SaveChanges();
            MessageBox.Show("Added product");

            





        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dB.Products.Select(pr => { pr.ProductName,})
        }
    }
}
