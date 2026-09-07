namespace Laboratory_Activity_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblFood = new Label();
            lblQtyFood = new Label();
            nudBurger = new NumericUpDown();
            lblDrinks = new Label();
            lblQtyDrinks = new Label();
            nudSoftDrink = new NumericUpDown();
            rdoDineIn = new RadioButton();
            rdoTakeout = new RadioButton();
            rdoDelivery = new RadioButton();
            lblOrderType = new Label();
            chkBurger = new CheckBox();
            chkChickenSandwich = new CheckBox();
            chkSpaghetti = new CheckBox();
            chkFrenchFries = new CheckBox();
            nudChickenSandwich = new NumericUpDown();
            nudSpaghetti = new NumericUpDown();
            nudFrenchFries = new NumericUpDown();
            chkSoftDrink = new CheckBox();
            chkIcedTea = new CheckBox();
            nudIceTea = new NumericUpDown();
            chkCoffee = new CheckBox();
            chkBottledWater = new CheckBox();
            nudCoffee = new NumericUpDown();
            nudBottledWater = new NumericUpDown();
            lbl85 = new Label();
            lbl75 = new Label();
            lbl95 = new Label();
            lbl50 = new Label();
            lblpriceFood = new Label();
            lblpriceDrinks = new Label();
            lbl35 = new Label();
            lbl40 = new Label();
            lbl45 = new Label();
            lbl25 = new Label();
            chkSenior = new CheckBox();
            txtPayment = new TextBox();
            labePayment = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblOrderSummarys = new Label();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTakeout = new Label();
            lblDelivery = new Label();
            lblTotal = new Label();
            lblChange = new Label();
            lblReceipt = new Label();
            rtbReceipt = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoftDrink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChickenSandwich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaghetti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrenchFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIceTea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBottledWater).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 37);
            label1.TabIndex = 0;
            label1.Text = "Café Ordering and Billing System";
            label1.Click += label1_Click;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFood.Location = new Point(12, 60);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(60, 21);
            lblFood.TabIndex = 2;
            lblFood.Text = "FOOD :";
            lblFood.Click += label2_Click;
            // 
            // lblQtyFood
            // 
            lblQtyFood.AutoSize = true;
            lblQtyFood.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtyFood.Location = new Point(229, 58);
            lblQtyFood.Name = "lblQtyFood";
            lblQtyFood.Size = new Size(74, 19);
            lblQtyFood.TabIndex = 4;
            lblQtyFood.Text = " Quantity :";
            lblQtyFood.Click += label3_Click;
            // 
            // nudBurger
            // 
            nudBurger.Location = new Point(239, 87);
            nudBurger.Name = "nudBurger";
            nudBurger.Size = new Size(42, 23);
            nudBurger.TabIndex = 6;
            nudBurger.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrinks.Location = new Point(393, 60);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(65, 21);
            lblDrinks.TabIndex = 9;
            lblDrinks.Text = "DRINKS";
            lblDrinks.Click += lblDrinks_Click;
            // 
            // lblQtyDrinks
            // 
            lblQtyDrinks.AutoSize = true;
            lblQtyDrinks.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblQtyDrinks.Location = new Point(588, 58);
            lblQtyDrinks.Name = "lblQtyDrinks";
            lblQtyDrinks.Size = new Size(86, 19);
            lblQtyDrinks.TabIndex = 11;
            lblQtyDrinks.Text = "Quantity :    ";
            lblQtyDrinks.Click += lblQtyDrinks_Click;
            // 
            // nudSoftDrink
            // 
            nudSoftDrink.Location = new Point(604, 96);
            nudSoftDrink.Name = "nudSoftDrink";
            nudSoftDrink.Size = new Size(42, 23);
            nudSoftDrink.TabIndex = 12;
            nudSoftDrink.ValueChanged += nudSoftDrink_ValueChanged;
            // 
            // rdoDineIn
            // 
            rdoDineIn.AutoSize = true;
            rdoDineIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdoDineIn.Location = new Point(11, 250);
            rdoDineIn.Name = "rdoDineIn";
            rdoDineIn.Size = new Size(82, 24);
            rdoDineIn.TabIndex = 13;
            rdoDineIn.TabStop = true;
            rdoDineIn.Text = "Dine-in ";
            rdoDineIn.UseVisualStyleBackColor = true;
            rdoDineIn.CheckedChanged += rdoDineIn_CheckedChanged;
            // 
            // rdoTakeout
            // 
            rdoTakeout.AutoSize = true;
            rdoTakeout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdoTakeout.Location = new Point(99, 250);
            rdoTakeout.Name = "rdoTakeout";
            rdoTakeout.Size = new Size(87, 24);
            rdoTakeout.TabIndex = 14;
            rdoTakeout.TabStop = true;
            rdoTakeout.Text = "Takeout ";
            rdoTakeout.UseVisualStyleBackColor = true;
            rdoTakeout.CheckedChanged += rdoTakeout_CheckedChanged;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdoDelivery.Location = new Point(196, 251);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(85, 24);
            rdoDelivery.TabIndex = 15;
            rdoDelivery.TabStop = true;
            rdoDelivery.Text = "Delivery";
            rdoDelivery.UseVisualStyleBackColor = true;
            rdoDelivery.CheckedChanged += rdoDelivery_CheckedChanged;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderType.Location = new Point(11, 214);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(106, 21);
            lblOrderType.TabIndex = 16;
            lblOrderType.Text = "ORDER TYPE :";
            lblOrderType.Click += lblOrderType_Click;
            // 
            // chkBurger
            // 
            chkBurger.AutoSize = true;
            chkBurger.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chkBurger.Location = new Point(11, 84);
            chkBurger.Name = "chkBurger";
            chkBurger.Size = new Size(76, 24);
            chkBurger.TabIndex = 17;
            chkBurger.Text = "Burger";
            chkBurger.UseVisualStyleBackColor = true;
            chkBurger.CheckedChanged += chkBurger_CheckedChanged;
            // 
            // chkChickenSandwich
            // 
            chkChickenSandwich.AutoSize = true;
            chkChickenSandwich.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chkChickenSandwich.Location = new Point(11, 113);
            chkChickenSandwich.Name = "chkChickenSandwich";
            chkChickenSandwich.Size = new Size(152, 24);
            chkChickenSandwich.TabIndex = 18;
            chkChickenSandwich.Text = "Chicken Sandwich";
            chkChickenSandwich.UseVisualStyleBackColor = true;
            chkChickenSandwich.CheckedChanged += chkChickenSandwich_CheckedChanged;
            // 
            // chkSpaghetti
            // 
            chkSpaghetti.AutoSize = true;
            chkSpaghetti.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chkSpaghetti.Location = new Point(11, 142);
            chkSpaghetti.Name = "chkSpaghetti";
            chkSpaghetti.Size = new Size(95, 24);
            chkSpaghetti.TabIndex = 19;
            chkSpaghetti.Text = "Spaghetti";
            chkSpaghetti.UseVisualStyleBackColor = true;
            chkSpaghetti.CheckedChanged += chkSpaghetti_CheckedChanged;
            // 
            // chkFrenchFries
            // 
            chkFrenchFries.AutoSize = true;
            chkFrenchFries.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkFrenchFries.Location = new Point(11, 172);
            chkFrenchFries.Name = "chkFrenchFries";
            chkFrenchFries.Size = new Size(112, 24);
            chkFrenchFries.TabIndex = 20;
            chkFrenchFries.Text = "French Fries";
            chkFrenchFries.UseVisualStyleBackColor = true;
            chkFrenchFries.CheckedChanged += chkFrenchFries_CheckedChanged;
            // 
            // nudChickenSandwich
            // 
            nudChickenSandwich.Location = new Point(239, 116);
            nudChickenSandwich.Name = "nudChickenSandwich";
            nudChickenSandwich.Size = new Size(42, 23);
            nudChickenSandwich.TabIndex = 21;
            nudChickenSandwich.ValueChanged += nudChickenSandwich_ValueChanged;
            // 
            // nudSpaghetti
            // 
            nudSpaghetti.Location = new Point(239, 145);
            nudSpaghetti.Name = "nudSpaghetti";
            nudSpaghetti.Size = new Size(42, 23);
            nudSpaghetti.TabIndex = 22;
            nudSpaghetti.ValueChanged += nudSpaghetti_ValueChanged;
            // 
            // nudFrenchFries
            // 
            nudFrenchFries.Location = new Point(239, 175);
            nudFrenchFries.Name = "nudFrenchFries";
            nudFrenchFries.Size = new Size(42, 23);
            nudFrenchFries.TabIndex = 23;
            nudFrenchFries.ValueChanged += nudFrenchFries_ValueChanged;
            // 
            // chkSoftDrink
            // 
            chkSoftDrink.AutoSize = true;
            chkSoftDrink.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkSoftDrink.Location = new Point(393, 96);
            chkSoftDrink.Name = "chkSoftDrink";
            chkSoftDrink.Size = new Size(99, 24);
            chkSoftDrink.TabIndex = 24;
            chkSoftDrink.Text = "Soft Drink";
            chkSoftDrink.UseVisualStyleBackColor = true;
            chkSoftDrink.CheckedChanged += chkSoftDrink_CheckedChanged;
            // 
            // chkIcedTea
            // 
            chkIcedTea.AutoSize = true;
            chkIcedTea.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkIcedTea.Location = new Point(393, 126);
            chkIcedTea.Name = "chkIcedTea";
            chkIcedTea.Size = new Size(85, 24);
            chkIcedTea.TabIndex = 25;
            chkIcedTea.Text = "Iced Tea";
            chkIcedTea.UseVisualStyleBackColor = true;
            chkIcedTea.CheckedChanged += chkIcedTea_CheckedChanged;
            // 
            // nudIceTea
            // 
            nudIceTea.Location = new Point(604, 129);
            nudIceTea.Name = "nudIceTea";
            nudIceTea.Size = new Size(42, 23);
            nudIceTea.TabIndex = 26;
            nudIceTea.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // chkCoffee
            // 
            chkCoffee.AutoSize = true;
            chkCoffee.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkCoffee.Location = new Point(393, 159);
            chkCoffee.Name = "chkCoffee";
            chkCoffee.Size = new Size(74, 24);
            chkCoffee.TabIndex = 27;
            chkCoffee.Text = "Coffee";
            chkCoffee.UseVisualStyleBackColor = true;
            chkCoffee.CheckedChanged += chkCoffee_CheckedChanged;
            // 
            // chkBottledWater
            // 
            chkBottledWater.AutoSize = true;
            chkBottledWater.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkBottledWater.Location = new Point(393, 186);
            chkBottledWater.Name = "chkBottledWater";
            chkBottledWater.Size = new Size(126, 24);
            chkBottledWater.TabIndex = 28;
            chkBottledWater.Text = "Bottled Water";
            chkBottledWater.UseVisualStyleBackColor = true;
            chkBottledWater.CheckedChanged += chkBottledWater_CheckedChanged;
            // 
            // nudCoffee
            // 
            nudCoffee.Location = new Point(604, 159);
            nudCoffee.Name = "nudCoffee";
            nudCoffee.Size = new Size(42, 23);
            nudCoffee.TabIndex = 29;
            nudCoffee.ValueChanged += nudCoffee_ValueChanged;
            // 
            // nudBottledWater
            // 
            nudBottledWater.Location = new Point(604, 186);
            nudBottledWater.Name = "nudBottledWater";
            nudBottledWater.Size = new Size(42, 23);
            nudBottledWater.TabIndex = 30;
            nudBottledWater.ValueChanged += nudBottledWater_ValueChanged;
            // 
            // lbl85
            // 
            lbl85.AutoSize = true;
            lbl85.Location = new Point(174, 89);
            lbl85.Name = "lbl85";
            lbl85.Size = new Size(26, 15);
            lbl85.TabIndex = 31;
            lbl85.Text = "₱85";
            lbl85.Click += lbl85_Click;
            // 
            // lbl75
            // 
            lbl75.AutoSize = true;
            lbl75.Location = new Point(174, 118);
            lbl75.Name = "lbl75";
            lbl75.Size = new Size(26, 15);
            lbl75.TabIndex = 32;
            lbl75.Text = "₱75";
            lbl75.Click += lbl75_Click;
            // 
            // lbl95
            // 
            lbl95.AutoSize = true;
            lbl95.Location = new Point(174, 145);
            lbl95.Name = "lbl95";
            lbl95.Size = new Size(26, 15);
            lbl95.TabIndex = 33;
            lbl95.Text = "₱95";
            lbl95.Click += lbl95_Click;
            // 
            // lbl50
            // 
            lbl50.AutoSize = true;
            lbl50.Location = new Point(174, 177);
            lbl50.Name = "lbl50";
            lbl50.Size = new Size(26, 15);
            lbl50.TabIndex = 34;
            lbl50.Text = "₱50";
            lbl50.Click += lbl50_Click;
            // 
            // lblpriceFood
            // 
            lblpriceFood.AutoSize = true;
            lblpriceFood.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblpriceFood.Location = new Point(152, 61);
            lblpriceFood.Name = "lblpriceFood";
            lblpriceFood.Size = new Size(48, 20);
            lblpriceFood.TabIndex = 35;
            lblpriceFood.Text = "Price :";
            lblpriceFood.Click += label11_Click;
            // 
            // lblpriceDrinks
            // 
            lblpriceDrinks.AutoSize = true;
            lblpriceDrinks.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblpriceDrinks.Location = new Point(521, 60);
            lblpriceDrinks.Name = "lblpriceDrinks";
            lblpriceDrinks.Size = new Size(48, 20);
            lblpriceDrinks.TabIndex = 36;
            lblpriceDrinks.Text = "Price :";
            lblpriceDrinks.Click += lblpriceDrinks_Click;
            // 
            // lbl35
            // 
            lbl35.AutoSize = true;
            lbl35.Location = new Point(543, 95);
            lbl35.Name = "lbl35";
            lbl35.Size = new Size(26, 15);
            lbl35.TabIndex = 37;
            lbl35.Text = "₱35";
            lbl35.Click += label13_Click;
            // 
            // lbl40
            // 
            lbl40.AutoSize = true;
            lbl40.Location = new Point(543, 124);
            lbl40.Name = "lbl40";
            lbl40.Size = new Size(26, 15);
            lbl40.TabIndex = 38;
            lbl40.Text = "₱40";
            lbl40.Click += lbl40_Click;
            // 
            // lbl45
            // 
            lbl45.AutoSize = true;
            lbl45.Location = new Point(543, 159);
            lbl45.Name = "lbl45";
            lbl45.Size = new Size(26, 15);
            lbl45.TabIndex = 39;
            lbl45.Text = "₱45";
            // 
            // lbl25
            // 
            lbl25.AutoSize = true;
            lbl25.Location = new Point(543, 194);
            lbl25.Name = "lbl25";
            lbl25.Size = new Size(26, 15);
            lbl25.TabIndex = 40;
            lbl25.Text = "₱25";
            // 
            // chkSenior
            // 
            chkSenior.AutoSize = true;
            chkSenior.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkSenior.Location = new Point(322, 252);
            chkSenior.Name = "chkSenior";
            chkSenior.Size = new Size(123, 24);
            chkSenior.TabIndex = 41;
            chkSenior.Text = "Senior Citizen";
            chkSenior.UseVisualStyleBackColor = true;
            chkSenior.CheckedChanged += chkSenior_CheckedChanged;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(90, 306);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(118, 23);
            txtPayment.TabIndex = 43;
            txtPayment.Text = " ₱";
            txtPayment.TextChanged += txtPayment_TextChanged;
            // 
            // labePayment
            // 
            labePayment.AutoSize = true;
            labePayment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labePayment.Location = new Point(5, 305);
            labePayment.Name = "labePayment";
            labePayment.Size = new Size(79, 20);
            labePayment.TabIndex = 44;
            labePayment.Text = "Payment :";
            labePayment.Click += labePayment_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(12, 379);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(81, 32);
            btnCalculate.TabIndex = 45;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(125, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 46;
            btnClear.Text = " CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(239, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 32);
            btnExit.TabIndex = 47;
            btnExit.Text = " EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblOrderSummarys
            // 
            lblOrderSummarys.AutoSize = true;
            lblOrderSummarys.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderSummarys.Location = new Point(11, 466);
            lblOrderSummarys.Name = "lblOrderSummarys";
            lblOrderSummarys.Size = new Size(146, 21);
            lblOrderSummarys.TabIndex = 48;
            lblOrderSummarys.Text = "ORDER SUMMARY ";
            lblOrderSummarys.Click += label19_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(12, 502);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 20);
            lblSubtotal.TabIndex = 49;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.Click += label20_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiscount.Location = new Point(12, 532);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(75, 20);
            lblDiscount.TabIndex = 50;
            lblDiscount.Text = "Discount:";
            lblDiscount.Click += label21_Click;
            // 
            // lblTakeout
            // 
            lblTakeout.AutoSize = true;
            lblTakeout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTakeout.Location = new Point(12, 561);
            lblTakeout.Name = "lblTakeout";
            lblTakeout.Size = new Size(126, 20);
            lblTakeout.TabIndex = 51;
            lblTakeout.Text = "Takeout Charge: ";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDelivery.Location = new Point(12, 591);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(124, 20);
            lblDelivery.TabIndex = 52;
            lblDelivery.Text = "Delivery Charge:";
            lblDelivery.Click += label23_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(14, 625);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 20);
            lblTotal.TabIndex = 53;
            lblTotal.Text = "TOTAL:";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChange.Location = new Point(11, 654);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(65, 20);
            lblChange.TabIndex = 54;
            lblChange.Text = "Change:";
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReceipt.Location = new Point(11, 718);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(61, 21);
            lblReceipt.TabIndex = 55;
            lblReceipt.Text = "Receipt";
            // 
            // rtbReceipt
            // 
            rtbReceipt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rtbReceipt.Location = new Point(12, 742);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.Size = new Size(670, 83);
            rtbReceipt.TabIndex = 56;
            rtbReceipt.Text = "Café Ordering Bill";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 845);
            Controls.Add(rtbReceipt);
            Controls.Add(lblReceipt);
            Controls.Add(lblChange);
            Controls.Add(lblTotal);
            Controls.Add(lblDelivery);
            Controls.Add(lblTakeout);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotal);
            Controls.Add(lblOrderSummarys);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(labePayment);
            Controls.Add(txtPayment);
            Controls.Add(chkSenior);
            Controls.Add(lbl25);
            Controls.Add(lbl45);
            Controls.Add(lbl40);
            Controls.Add(lbl35);
            Controls.Add(lblpriceDrinks);
            Controls.Add(lblpriceFood);
            Controls.Add(lbl50);
            Controls.Add(lbl95);
            Controls.Add(lbl75);
            Controls.Add(lbl85);
            Controls.Add(nudBottledWater);
            Controls.Add(nudCoffee);
            Controls.Add(chkBottledWater);
            Controls.Add(chkCoffee);
            Controls.Add(nudIceTea);
            Controls.Add(chkIcedTea);
            Controls.Add(chkSoftDrink);
            Controls.Add(nudFrenchFries);
            Controls.Add(nudSpaghetti);
            Controls.Add(nudChickenSandwich);
            Controls.Add(chkFrenchFries);
            Controls.Add(chkSpaghetti);
            Controls.Add(chkChickenSandwich);
            Controls.Add(chkBurger);
            Controls.Add(lblOrderType);
            Controls.Add(rdoDelivery);
            Controls.Add(rdoTakeout);
            Controls.Add(rdoDineIn);
            Controls.Add(nudSoftDrink);
            Controls.Add(lblQtyDrinks);
            Controls.Add(lblDrinks);
            Controls.Add(nudBurger);
            Controls.Add(lblQtyFood);
            Controls.Add(lblFood);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoftDrink).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChickenSandwich).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpaghetti).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrenchFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIceTea).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBottledWater).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFood;
        private TextBox txtFoodQty;
        private Label lblQtyFood;
        private NumericUpDown nudBurger;
        private Label lblDrinks;
        private Label lblQtyDrinks;
        private NumericUpDown nudSoftDrink;
        private RadioButton rdoDineIn;
        private RadioButton rdoTakeout;
        private RadioButton rdoDelivery;
        private Label lblOrderType;
        private CheckBox chkBurger;
        private CheckBox chkChickenSandwich;
        private CheckBox chkSpaghetti;
        private CheckBox chkFrenchFries;
        private NumericUpDown nudChickenSandwich;
        private NumericUpDown nudSpaghetti;
        private NumericUpDown nudFrenchFries;
        private CheckBox chkSoftDrink;
        private CheckBox chkIcedTea;
        private NumericUpDown nudIceTea;
        private CheckBox chkCoffee;
        private CheckBox chkBottledWater;
        private NumericUpDown nudCoffee;
        private NumericUpDown nudBottledWater;
        private Label lbl85;
        private Label lbl75;
        private Label lbl95;
        private Label lbl50;
        private Label lblpriceFood;
        private Label lblpriceDrinks;
        private Label lbl35;
        private Label lbl40;
        private Label lbl45;
        private Label lbl25;
        private CheckBox chkSenior;
        private Label label17;
        private TextBox txtPayment;
        private Label labePayment;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblOrderSummarys;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblTakeout;
        private Label lblDelivery;
        private Label lblTotal;
        private Label lblChange;
        private Label lblReceipt;
        private RichTextBox rtbReceipt;
    }
}
