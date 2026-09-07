using System.Windows.Forms;

namespace Laboratory_Activity_4
{
    public partial class Form1 : Form
    {
        // ==============================
        // MENU PRICES
        // ==============================

        decimal burgerPrice = 85m;
        decimal chickenSandwichPrice = 75m;
        decimal spaghettiPrice = 95m;
        decimal frenchFriesPrice = 50m;

        decimal softDrinkPrice = 35m;
        decimal icedTeaPrice = 40m;
        decimal coffeePrice = 45m;
        decimal bottledWaterPrice = 25m;


        // ==============================
        // TOTAL VARIABLES
        // ==============================

        decimal subtotal = 0m;
        decimal discount = 0m;
        decimal takeoutCharge = 0m;
        decimal deliveryCharge = 0m;
        decimal total = 0m;
        decimal payment = 0m;
        decimal change = 0m;


        public Form1()
        {
            InitializeComponent();
        }


        // ==============================
        // FORM LOAD
        // ==============================

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoDineIn.Checked = true;

            // Quantities start at 0
            numericUpDown1.Value = 0;
            nudChickenSandwich.Value = 0;
            nudSpaghetti.Value = 0;
            nudFrenchFries.Value = 0;

            nudSoftDrink.Value = 0;
            numericUpDown2.Value = 0;
            nudCoffee.Value = 0;
            nudBottledWater.Value = 0;

            ClearSummary();
        }


        // ==============================
        // CALCULATE
        // ==============================

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal foodTotal = 0m;
            decimal drinkTotal = 0m;


            // ==========================================
            // CHECK IF FOOD IS SELECTED
            // ==========================================

            if (!chkBurger.Checked &&
                !chkChickenSandwich.Checked &&
                !chkSpaghetti.Checked &&
                !chkFrenchFries.Checked)
            {
                MessageBox.Show(
                    "Please select at least one food item.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            // ==========================================
            // CHECK IF DRINK IS SELECTED
            // ==========================================

            if (!chkSoftDrink.Checked &&
                !chkIcedTea.Checked &&
                !chkCoffee.Checked &&
                !chkBottledWater.Checked)
            {
                MessageBox.Show(
                    "Please select at least one drink item.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            // ==========================================
            // FOOD
            // ==========================================

            if (chkBurger.Checked)
            {
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show(
                        "Burger quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                foodTotal += burgerPrice * numericUpDown1.Value;
            }


            if (chkChickenSandwich.Checked)
            {
                if (nudChickenSandwich.Value <= 0)
                {
                    MessageBox.Show(
                        "Chicken Sandwich quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                foodTotal +=
                    chickenSandwichPrice * nudChickenSandwich.Value;
            }


            if (chkSpaghetti.Checked)
            {
                if (nudSpaghetti.Value <= 0)
                {
                    MessageBox.Show(
                        "Spaghetti quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                foodTotal +=
                    spaghettiPrice * nudSpaghetti.Value;
            }


            if (chkFrenchFries.Checked)
            {
                if (nudFrenchFries.Value <= 0)
                {
                    MessageBox.Show(
                        "French Fries quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                foodTotal +=
                    frenchFriesPrice * nudFrenchFries.Value;
            }


            // ==========================================
            // DRINKS
            // ==========================================

            if (chkSoftDrink.Checked)
            {
                if (nudSoftDrink.Value <= 0)
                {
                    MessageBox.Show(
                        "Soft Drink quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                drinkTotal +=
                    softDrinkPrice * nudSoftDrink.Value;
            }


            if (chkIcedTea.Checked)
            {
                if (numericUpDown2.Value <= 0)
                {
                    MessageBox.Show(
                        "Iced Tea quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
                drinkTotal +=
                    icedTeaPrice * numericUpDown2.Value;
            }


            if (chkCoffee.Checked)
            {
                if (nudCoffee.Value <= 0)
                {
                    MessageBox.Show(
                        "Coffee quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                drinkTotal +=
                    coffeePrice * nudCoffee.Value;
            }


            if (chkBottledWater.Checked)
            {
                if (nudBottledWater.Value <= 0)
                {
                    MessageBox.Show(
                        "Bottled Water quantity must be greater than zero.",
                        "Quantity Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                drinkTotal +=
                    bottledWaterPrice * nudBottledWater.Value;
            }


            // ==========================================
            // SUBTOTAL
            // ==========================================

            subtotal = foodTotal + drinkTotal;


            // ==========================================
            // DISCOUNT
            // ==========================================

            discount = 0m;

            // 10% discount if subtotal is ₱500 or more
            if (subtotal >= 500m)
            {
                discount += subtotal * 0.10m;
            }

            // Additional 20% Senior Citizen Discount
            if (chkSenior.Checked)
            {
                discount += subtotal * 0.20m;
            }


            // ==========================================
            // ORDER TYPE
            // ==========================================

            takeoutCharge = 0m;
            deliveryCharge = 0m;


            if (rdoDineIn.Checked)
            {
                // No additional charge
                takeoutCharge = 0m;
                deliveryCharge = 0m;
            }
            else if (rdoTakeout.Checked)
            {
                // Takeout = ₱20
                takeoutCharge = 20m;
            }
            else if (rdoDelivery.Checked)
            {
                // ₱1,000 or more = FREE DELIVERY
                if (subtotal >= 1000m)
                {
                    deliveryCharge = 0m;
                }
                else
                {
                    deliveryCharge = 50m;
                }
            }


            // ==========================================
            // FINAL TOTAL
            // ==========================================

            total = subtotal
                  - discount
                  + takeoutCharge
                  + deliveryCharge;


            // ==========================================
            // PAYMENT VALIDATION
            // ==========================================

            if (txtPayment.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter payment.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPayment.Focus();

                return;
            }


            // Check if payment contains letters
            if (!decimal.TryParse(txtPayment.Text, out payment))
            {
                MessageBox.Show(
                    "Payment must contain numbers only.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPayment.Focus();

                return;
            }


            // Payment must be positive
            if (payment <= 0)
            {
                MessageBox.Show(
                    "Payment must be greater than zero.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            // ==========================================
            // INSUFFICIENT PAYMENT
            // ==========================================

            if (payment < total)
            {
                lblSubtotal.Text =
                    "₱" + subtotal.ToString("N2");

                lblDiscount.Text =
                    "₱" + discount.ToString("N2");

                lblTakeout.Text =
                    "₱" + takeoutCharge.ToString("N2");

                lblDelivery.Text =
                    "₱" + deliveryCharge.ToString("N2");

                lblTotal.Text =
                    "₱" + total.ToString("N2");

                lblChange.Text = "₱0.00";


                MessageBox.Show(
                    "Insufficient payment.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            // ==========================================
            // CHANGE
            // ==========================================

            change = payment - total;


            // ==========================================
            // DISPLAY SUMMARY
            // ==========================================

            lblSubtotal.Text =
                "₱" + subtotal.ToString("N2");

            lblDiscount.Text =
                "₱" + discount.ToString("N2");

            lblTakeout.Text =
                "₱" + takeoutCharge.ToString("N2");

            lblDelivery.Text =
                "₱" + deliveryCharge.ToString("N2");

            lblTotal.Text =
                "₱" + total.ToString("N2");

            lblChange.Text =
                "₱" + change.ToString("N2");


            // ==========================================
            // RECEIPT
            // ==========================================

            GenerateReceipt();
        }


        // ==============================
        // RECEIPT
        // ==============================

        private void GenerateReceipt()
        {
            richTextBox1.Clear();

            richTextBox1.AppendText(
                "========================================\n");

            richTextBox1.AppendText(
                "              ABC CAFÉ\n");

            richTextBox1.AppendText(
                "========================================\n");


            // ==========================================
            // FOOD ITEMS
            // ==========================================

            if (chkBurger.Checked)
            {
                richTextBox1.AppendText(
                "Burger           " +
                    numericUpDown1.Value +
                " x ₱85.00     ₱" +
                    (burgerPrice * numericUpDown1.Value).ToString("N2") +
                    "\n");
            }


            if (chkChickenSandwich.Checked)
            {
                richTextBox1.AppendText(
                    "Chicken Sandwich  " +
                    nudChickenSandwich.Value +
                    " x ₱75.00     ₱" +
                    (chickenSandwichPrice *
                    nudChickenSandwich.Value).ToString("N2") +
                    "\n");
            }


            if (chkSpaghetti.Checked)
            {
                richTextBox1.AppendText(
                    "Spaghetti         " +
                    nudSpaghetti.Value +
                    " x ₱95.00     ₱" +
                    (spaghettiPrice *
                    nudSpaghetti.Value).ToString("N2") +
                    "\n");
            }


            if (chkFrenchFries.Checked)
            {
                richTextBox1.AppendText(
                    "French Fries      " +
                    nudFrenchFries.Value +
                    " x ₱50.00     ₱" +
                    (frenchFriesPrice *
                    nudFrenchFries.Value).ToString("N2") +
                    "\n");
            }


            // ==========================================
            // DRINK ITEMS
            // ==========================================

            if (chkSoftDrink.Checked)
            {
                richTextBox1.AppendText(
                    "Soft Drink        " +
                    nudSoftDrink.Value +
                    " x ₱35.00     ₱" +
                    (softDrinkPrice *
                    nudSoftDrink.Value).ToString("N2") +
                    "\n");
            }


            if (chkIcedTea.Checked)
            {
                richTextBox1.AppendText(
                    "Iced Tea          " +
                    numericUpDown2.Value +
                    " x ₱40.00     ₱" +
                (icedTeaPrice *
                    numericUpDown2.Value).ToString("N2") +
                    "\n");
            }


            if (chkCoffee.Checked)
            {
                richTextBox1.AppendText(
                    "Coffee            " +
                    nudCoffee.Value +
                    " x ₱45.00     ₱" +
                    (coffeePrice *
                    nudCoffee.Value).ToString("N2") +
                    "\n");
            }


            if (chkBottledWater.Checked)
            {
                richTextBox1.AppendText(
                    "Bottled Water     " +
                    nudBottledWater.Value +
                    " x ₱25.00     ₱" +
                    (bottledWaterPrice *
                    nudBottledWater.Value).ToString("N2") +
                    "\n");
            }


            // ==========================================
            // ORDER TYPE
            // ==========================================

            richTextBox1.AppendText(
                "----------------------------------------\n");

            richTextBox1.AppendText("Order Type: ");

            if (rdoDineIn.Checked)
            {
                richTextBox1.AppendText("Dine-in\n");
            }
            else if (rdoTakeout.Checked)
            {
                richTextBox1.AppendText("Takeout\n");
            }
            else if (rdoDelivery.Checked)
            {
                richTextBox1.AppendText("Delivery\n");
            }


            if (chkSenior.Checked)
            {
                richTextBox1.AppendText(
                    "Senior Citizen: YES\n");
            }


            // ==========================================
            // SUMMARY
            // ==========================================

            richTextBox1.AppendText(
                "----------------------------------------\n");

            richTextBox1.AppendText(
                "Subtotal:             ₱" +
                subtotal.ToString("N2") +
            "\n");

            richTextBox1.AppendText(
                "Discount:             ₱" +
                discount.ToString("N2") +
            "\n");

            richTextBox1.AppendText(
                "Takeout Charge:       ₱" +
                takeoutCharge.ToString("N2") +
                "\n");

            richTextBox1.AppendText(
                "Delivery Charge:      ₱" +
                deliveryCharge.ToString("N2") +
                "\n");

            richTextBox1.AppendText(
                "----------------------------------------\n");

            richTextBox1.AppendText(
                "TOTAL:                ₱" +
                total.ToString("N2") +
                "\n");

            richTextBox1.AppendText(
                "Payment:              ₱" +
                payment.ToString("N2") +
                "\n");

            richTextBox1.AppendText(
                "Change:               ₱" +
                change.ToString("N2") +
                "\n");

            richTextBox1.AppendText(
                "========================================\n");

            richTextBox1.AppendText(
                "              THANK YOU!\n");

            richTextBox1.AppendText(
                "========================================\n");
        }


        // ==============================
        // CLEAR BUTTON
        // ==============================

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Uncheck foods
            chkBurger.Checked = false;
            chkChickenSandwich.Checked = false;
            chkSpaghetti.Checked = false;
            chkFrenchFries.Checked = false;

            // Uncheck drinks
            chkSoftDrink.Checked = false;
            chkIcedTea.Checked = false;
            chkCoffee.Checked = false;
            chkBottledWater.Checked = false;

            // Uncheck senior
            chkSenior.Checked = false;

            // Dine-in default
            rdoDineIn.Checked = true;

            // Reset quantities
            numericUpDown1.Value = 0;
            nudChickenSandwich.Value = 0;
            nudSpaghetti.Value = 0;
            nudFrenchFries.Value = 0;

            nudSoftDrink.Value = 0;
            numericUpDown2.Value = 0;
            nudCoffee.Value = 0;
            nudBottledWater.Value = 0;

            // Clear payment
            txtPayment.Clear();

            // Clear receipt
            richTextBox1.Clear();

            // Clear totals
            ClearSummary();
        }


        // ==============================
        // CLEAR SUMMARY
        // ==============================

        private void ClearSummary()
        {
            lblSubtotal.Text = "₱0.00";
            lblDiscount.Text = "₱0.00";
            lblTakeout.Text = "₱0.00";
            lblDelivery.Text = "₱0.00";
            lblTotal.Text = "₱0.00";
            lblChange.Text = "₱0.00";
        }


        // ==============================
        // EXIT BUTTON
        // ==============================

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // ==============================
        // EMPTY EVENTS
        // ==============================

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void label21_Click(object sender, EventArgs e) { }

        private void label20_Click(object sender, EventArgs e) { }

        private void label23_Click(object sender, EventArgs e) { }

        private void chkBurger_CheckedChanged(object sender, EventArgs e) { }

        private void lblTotal_Click(object sender, EventArgs e) { }

        private void chkChickenSandwich_CheckedChanged(object sender, EventArgs e) { }

        private void chkSpaghetti_CheckedChanged(object sender, EventArgs e) { }

        private void chkFrenchFries_CheckedChanged(object sender, EventArgs e) { }

        private void chkSoftDrink_CheckedChanged(object sender, EventArgs e) { }

        private void chkIcedTea_CheckedChanged(object sender, EventArgs e) { }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e) { }

        private void chkBottledWater_CheckedChanged(object sender, EventArgs e) { }

        private void lblDrinks_Click(object sender, EventArgs e) { }

        private void lblpriceDrinks_Click(object sender, EventArgs e) { }

        private void lblQtyDrinks_Click(object sender, EventArgs e) { }

        private void nudSoftDrink_ValueChanged(object sender, EventArgs e) { }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e) { }

        private void nudCoffee_ValueChanged(object sender, EventArgs e) { }

        private void nudBottledWater_ValueChanged(object sender, EventArgs e) { }

        private void label13_Click(object sender, EventArgs e) { }

        private void lblOrderType_Click(object sender, EventArgs e) { }

        private void rdoDineIn_CheckedChanged(object sender, EventArgs e) { }

        private void rdoTakeout_CheckedChanged(object sender, EventArgs e) { }

        private void rdoDelivery_CheckedChanged(object sender, EventArgs e) { }

        private void chkSenior_CheckedChanged(object sender, EventArgs e) { }

        private void labePayment_Click(object sender, EventArgs e) { }

        private void txtPayment_TextChanged(object sender, EventArgs e) { }

        private void label19_Click(object sender, EventArgs e) { }

        private void lbl85_Click(object sender, EventArgs e) { }

        private void lbl75_Click(object sender, EventArgs e) { }

        private void lbl95_Click(object sender, EventArgs e) { }

        private void lbl50_Click(object sender, EventArgs e) { }

        private void lbl40_Click(object sender, EventArgs e) { }

        private void nudChickenSandwich_ValueChanged(object sender, EventArgs e) { }

        private void nudSpaghetti_ValueChanged(object sender, EventArgs e) { }

        private void nudFrenchFries_ValueChanged(object sender, EventArgs e) { }
    }
}
