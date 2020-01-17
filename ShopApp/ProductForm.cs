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
            string amount = txtAmount.Text;
            string size = cmbboxSize.Text;
            string category = cmbboxCategory.Text;
            string[] emp = { productname , prodctPrice ,prodctdes,amount,size,category};
            if (mainExtensions.IsEmpty(emp,string.Empty)) {


                int catId = dB.Categories.First(ct => ct.Name == category).Id;
                int SizeId = dB.ProductSizes.First(ct => ct.Size== size).Id;

                Product product = new Product();


                product.ProductName = productname;
                product.Price = Convert.ToDouble(prodctPrice);
                product.Description = prodctdes;
                product.Amounts = Convert.ToInt32(amount);
                product.CategoryId  = catId;
                product.SizeId = SizeId;

                dB.Products.Add(product);
                dB.SaveChanges();
                MessageBox.Show("Added product","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }


        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            cmbboxCategory.Items.Add("Selected...");
            cmbboxCategory.SelectedIndex = 0;
            //dataGridView1.DataSource = dB.Products.Select(pr => { pr.ProductName,})
            cmbboxCategory.Items.AddRange(dB.Categories.Select(ct => ct.Name).ToArray());
            cmbboxSize.Items.AddRange(dB.ProductSizes.Select(ct => ct.Size).ToArray());
            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbboxCategory.Items.Remove("Selected...");
        }
    }
}
