using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SaipalStore
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        //Method to clear the data.
        public void dataClear() 
        {
            //Clears the textboxes and labels that contain data. 
            txtName.Clear(); 
            txtQuantity.Clear(); 
            txtRate.Clear();
            lblAmount.Text = "";
            lblDiscountPer.Text = "";
            lblFinalTotal.Text = "";
        }

        //Method to add data into the datagridview
        public void addData()
        {
            //To catch possible errors while running the program
            try
            {
                //Create a new table to store data.
                DataTable dt = new DataTable();

                //Associate the table as the datagridview's datasource.
                dt = (DataTable)dgProduct.DataSource;

                //Create strings to store the entered data.
                string productName = txtName.Text;
                string productQuantity = txtQuantity.Text;
                string productRate = txtRate.Text;

                //Perform calculations and store them as double in a new variable.
                double total = Convert.ToDouble(productRate) * Convert.ToDouble(productQuantity);

                //Convert the total obtained after the calculations into a string.
                string productTotal = total.ToString();

                //Add the data into the datagridview as an array.
                string[] row = { productName, productQuantity, productRate, productTotal };
                dgProduct.Rows.Add(row);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Method to calculate the total amount.
        public double calculateTotal()
        {
            //Declare necessary variables.
            double total = 0;

            //Iterate through each rows in the datagridview.
            foreach (DataGridViewRow row in dgProduct.Rows)
            {
                //Add the productTotal column's content into total.
                total += Convert.ToDouble(row.Cells[3].Value);
            }
            return total;
        }
        //Method to calculate the discount percentage and the final amount.
        public double calculateFinal()
        {
            //Declare necessary variables.
            double total = calculateTotal(), discount = 2, final;

            //Add conditions for each discount percentage.
            if (total >= 50000)
            {
                discount = 15;
            }
            else if (total >= 20000)
            {
                discount = 10;
            }
            else if (total >= 10000)
            {
                discount = 8;
            }
            else if (total >= 1000)
            {
                discount = 5;
            }

            //Display the discount percentage.
            lblDiscountPer.Text = discount.ToString()+"%";
            
            //Calculate the final price and return it.
            final = total - discount / 100 * total;
            return final;
        }

        //Event when minimize button is clicked.
        private void btnMin_Click(object sender, EventArgs e) 
        {
            //Minimize the form.
            this.WindowState = FormWindowState.Minimized; 
        }

        //Event when close button is clicked.
        private void btnClose_Click(object sender, EventArgs e) 
        {
            //Close the form.
            Close();
        }

        //Event when add button is clicked.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Call method to add data.
            addData(); 

            //Clear the data fields.
            dataClear();
            
        }

        //Event when clear button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clean the data fields.
            dataClear();

            //Clear the data contained in the rows.
            dgProduct.Rows.Clear();
        }

        //When calculate total button is clicked.
        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Call the methods and display the prices.
            lblAmount.Text = "Rs. " +calculateTotal().ToString();
            lblFinalTotal.Text = "Rs. " + calculateFinal().ToString();
        }

        private void homePage_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
