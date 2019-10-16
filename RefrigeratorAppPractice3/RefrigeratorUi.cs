using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        Refigerator refigerator=new Refigerator();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refigerator.maxweight = Convert.ToDouble(maxWeightTakeTextBox.Text);

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                refigerator.noOfItems = Convert.ToDouble(itemTextBox.Text);
                refigerator.unitOfWeight = Convert.ToDouble(weightTextBox.Text);


            double currentWeight = refigerator.GetCurrentWeight();
            double remainingWeight = refigerator.GetRemainingWeight();
                if (currentWeight < refigerator.maxweight)
                {
                    currentWeightTextBox.Text = currentWeight.ToString();
                    remainingWeightTextBox.Text = remainingWeight.ToString();
                }
                else
                {
                    MessageBox.Show("Your given weight can't be entered because it will be overflowen");
                }
               

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
