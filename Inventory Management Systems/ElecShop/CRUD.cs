using ElecShop.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecShop
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductList pl = new ProductList();
            ProductDataAccess ud = new ProductDataAccess();
            pl.ProductId = txtID.Text;
            pl.Name = txtName.Text;
            pl.Price = txtPrice.Text;
            pl.Company = txtCompany.Text;
            pl.Details =txtDetails.Text;
            int count = ud.AddProduct(pl);


            if (count == 1)
            {
                MessageBox.Show("Product Has Been Added");
                txtID.Text="";
                txtName.Text = "";
                txtPrice.Text = "";
                txtCompany.Text = "";
                txtDetails.Text = "";
            }

            else
            { MessageBox.Show("Product Has Not Been Added"); }



        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Visible = true;
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            OptionView PV = new OptionView();

            PV.Visible = true;
            this.Visible = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            ProductList pl = new ProductList();
            ProductDataAccess ud = new ProductDataAccess();
            int ProductId = int.Parse(textBox2.Text);
      
            int count = ud.DeleteProduct(ProductId);


            if (count == 1) 
            {
                MessageBox.Show("Product Has Been Deleted");
            }

            else
            { MessageBox.Show("Product Has Not Been Deleted"); }



        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }

    }

