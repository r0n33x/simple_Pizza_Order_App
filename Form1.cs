using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeYourPizza
{
    public partial class Form1 : Form
    {   
        
        int Price = 0;
        Queue <String > _Toppings = new Queue <String > ();
        public Form1()
        {
            InitializeComponent();

            SmallSize.Checked = true;
            ThinCrust.Checked = true;
            TakeOut.Checked = true;
            Price = 10;
            labPrice.Text = "$" + Price.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
                txtBxToppings.Text += "Extra Chees,";
            if (Union.Checked == true)
            {
                txtBxToppings.Text += "Union,";
                Price++;
            }
            else if (Union.Checked == false)
                Price--;
            if (Mushrooms.Checked == true)
                txtBxToppings.Text += "Mushroom,";
            if (Olives.Checked == true)
                txtBxToppings.Text += "Olives,";
            if (GreenPepers.Checked == true)
                txtBxToppings.Text += "Green Pepers,";
            if (Tomatoes.Checked == true)
                txtBxToppings.Text += "Tomatoes";
        }

        private void SmallSize_CheckedChanged(object sender, EventArgs e)
        {
            if (SmallSize.Checked != true)
                Price -= 5;

            else if (SmallSize.Checked != false)
            {
                Price += 5;
                labPrice.Text = "$" + Price.ToString();
                lablSize.Text = "Small";
            }


        }

        private void MidumSize_CheckedChanged(object sender, EventArgs e)
        {
            if (MidumSize.Checked != true)
                Price -= 10;

            else if (MidumSize.Checked != false)
            {
                Price += 10;
                labPrice.Text = "$" + Price.ToString();
                lablSize.Text = "Midum";
            }
        }

        private void LargSize_CheckedChanged(object sender, EventArgs e)
        {
            if (LargSize.Checked != true)
                Price -= 15;

            else if (LargSize.Checked != false)
            {
                Price += 15;
                labPrice.Text = "$" + Price.ToString();
                lablSize.Text = "Larg";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (ThinCrust.Checked != true)
                Price -= 10;

            else if (ThinCrust.Checked != false)
            {
                Price += 10;
                labPrice.Text = "$" + Price.ToString();
                lablCrust.Text = "Thin";
            }
        }

        private void ThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (ThinkCrust.Checked != true)
                Price -= 15;

            else if (ThinkCrust.Checked != false)
            {
                Price += 15;
                labPrice.Text = "$" + Price.ToString();
                lablCrust.Text = "Think";
            }
        }

        private void WhereGrpBx_Enter(object sender, EventArgs e)
        {

        }

        private void TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (TakeOut.Checked != true)
                Price -= 0;

            else if (TakeOut.Checked != false)
            {
                Price += 0;
                labPrice.Text = "$" + Price.ToString();
                lablWhrToEat.Text = "Take Out";
            }
        }

        private void lablWhrToEat_Click(object sender, EventArgs e)
        {

        }

        private void lablCrust_Click(object sender, EventArgs e)
        {

        }


        private void ToppingsGrpBx_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtBxToppings_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        static void GetToppings (Queue<String> q , ref TextBox Box)
        {
          
        }

        private void Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
                txtBxToppings.Text += "Extra Chees,";
            if (Union.Checked == true)
                txtBxToppings.Text += "Union,";
            if (Mushrooms.Checked == true)
            {
                txtBxToppings.Text += "Mushroom,";
                Price += 2;
            }
            else if (Mushrooms.Checked == false)
                Price -= 2;
            if (Olives.Checked == true)
                txtBxToppings.Text += "Olives,";
            if (GreenPepers.Checked == true)
                txtBxToppings.Text += "Green Pepers,";
            if (Tomatoes.Checked == true)
                txtBxToppings.Text += "Tomatoes";
            labPrice.Text = "$" + Price.ToString();

        }

        private void Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
                txtBxToppings.Text += "Extra Chees,";
            if (Union.Checked == true)
                txtBxToppings.Text += "Union,";
            if (Mushrooms.Checked == true)
                txtBxToppings.Text += "Mushroom,";
            if (Olives.Checked == true)
                txtBxToppings.Text += "Olives,";
            if (GreenPepers.Checked == true)
                txtBxToppings.Text += "Green Pepers,";
            if (Tomatoes.Checked == true)
            {
                txtBxToppings.Text += "Tomatoes";
                Price ++;
            }
            else if (Tomatoes.Checked == false)
                Price --;
            labPrice.Text = "$" + Price.ToString();

        }

        private void GreenPepers_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
                txtBxToppings.Text += "Extra Chees,";
            if (Union.Checked == true)
                txtBxToppings.Text += "Union,";
            if (Mushrooms.Checked == true)
                txtBxToppings.Text += "Mushroom,";
            if (Olives.Checked == true)
                txtBxToppings.Text += "Olives,";
            if (GreenPepers.Checked == true)
            {
                txtBxToppings.Text += "Green Pepers,";
                Price++;
            }
            else if (GreenPepers.Checked == false)
                Price--;
            if (Tomatoes.Checked == true)
                txtBxToppings.Text += "Tomatoes";
        }

        private void Olives_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
                txtBxToppings.Text += "Extra Chees,";
            if (Union.Checked == true)
                txtBxToppings.Text += "Union,";
            if (Mushrooms.Checked == true)
                txtBxToppings.Text += "Mushroom,";
            if (Olives.Checked == true)
            {
                txtBxToppings.Text += "Olives,";
                Price += 2;
            }
            else if (Olives.Checked == false)
                Price -= 2;
            if (GreenPepers.Checked == true)
                txtBxToppings.Text += "Green Pepers,";
            if (Tomatoes.Checked == true)
                txtBxToppings.Text += "Tomatoes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to order :-)", "Checking", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SmallSize.Enabled = MidumSize.Enabled = LargSize.Enabled  = false;
                ExtraChees.Enabled = Union.Enabled = Mushrooms.Enabled = Olives.Enabled = GreenPepers.Enabled = Tomatoes.Enabled = false;
                TakeOut.Enabled = EatIn.Enabled = false;
                ThinCrust.Enabled = ThinkCrust.Enabled = false ;

            }
        }

        private void ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            txtBxToppings.Clear();
            if (ExtraChees.Checked == true)
            {
                txtBxToppings.Text += "Extra Chees,";
                Price += 5;
            }
            else if (ExtraChees.Checked == false)
                Price -= 5;
            if (Union.Checked == true)
                txtBxToppings.Text += "Union,";
            if (Mushrooms.Checked == true)
                txtBxToppings.Text += "Mushroom,";
            if (Olives.Checked == true)
                txtBxToppings.Text += "Olives,";
            if (GreenPepers.Checked == true)
                txtBxToppings.Text += "Green Pepers,";
            if (Tomatoes.Checked == true)
                txtBxToppings.Text += "Tomatoes";
            labPrice.Text = "$" + Price.ToString();

        }

        private void EatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (EatIn.Checked != true)
                Price -= 5;

            else if (EatIn.Checked != false)
            {
                Price += 5;
                labPrice.Text = "$" + Price.ToString();
                lablWhrToEat.Text = "Eat In";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //InitializeComponent();

            SmallSize.Checked = true;
            ThinCrust.Checked = true;
            TakeOut.Checked = true;
            ExtraChees.Checked = Union.Checked = Mushrooms.Checked = Olives.Checked = GreenPepers.Checked = Tomatoes.Checked = false;
            Price = 10;
            labPrice.Text = "$" + Price.ToString();
            txtBxToppings.Clear();
            txtBxToppings.Text = "No Toppings Added";
        }
    }
}
