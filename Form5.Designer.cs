using System;

namespace MyFirstWinFormsProject
{
    partial class FrmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbTotalprice = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRealPriceNum = new System.Windows.Forms.Label();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbW = new System.Windows.Forms.Label();
            this.lbWhrToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(12, 87);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(210, 129);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(24, 92);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(57, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(24, 57);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(24, 22);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(57, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThickCrust);
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(21, 256);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(201, 135);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(15, 84);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(89, 20);
            this.rbThickCrust.TabIndex = 5;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(15, 37);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(84, 20);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(274, 340);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(359, 72);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(221, 26);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(77, 20);
            this.rbTakeOut.TabIndex = 7;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(19, 26);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(58, 20);
            this.rbEatIn.TabIndex = 6;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbTomatoes);
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.cbExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(317, 87);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(283, 201);
            this.gbToppings.TabIndex = 10;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomatoes.Location = new System.Drawing.Point(8, 142);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.cbTomatoes.TabIndex = 15;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGreenPeppers.Location = new System.Drawing.Point(126, 142);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.cbGreenPeppers.TabIndex = 14;
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(126, 36);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(54, 17);
            this.cbOnion.TabIndex = 13;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(8, 89);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.cbMushrooms.TabIndex = 12;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(126, 89);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 11;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraChees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbExtraChees.Location = new System.Drawing.Point(8, 36);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(82, 17);
            this.cbExtraChees.TabIndex = 10;
            this.cbExtraChees.Text = "ExtraChees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Location = new System.Drawing.Point(273, 470);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 36);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(443, 470);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbTotalprice
            // 
            this.lbTotalprice.AutoSize = true;
            this.lbTotalprice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalprice.Location = new System.Drawing.Point(675, 372);
            this.lbTotalprice.Name = "lbTotalprice";
            this.lbTotalprice.Size = new System.Drawing.Size(104, 19);
            this.lbTotalprice.TabIndex = 13;
            this.lbTotalprice.Text = "Total Price:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Green;
            this.lbPrice.Location = new System.Drawing.Point(731, 403);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 55);
            this.lbPrice.TabIndex = 14;
            this.lbPrice.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // lbRealPriceNum
            // 
            this.lbRealPriceNum.AutoSize = true;
            this.lbRealPriceNum.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealPriceNum.ForeColor = System.Drawing.Color.Green;
            this.lbRealPriceNum.Location = new System.Drawing.Point(770, 403);
            this.lbRealPriceNum.Name = "lbRealPriceNum";
            this.lbRealPriceNum.Size = new System.Drawing.Size(48, 55);
            this.lbRealPriceNum.TabIndex = 16;
            this.lbRealPriceNum.Text = "0";
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderSummary.Location = new System.Drawing.Point(675, 87);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(123, 19);
            this.lbOrderSummary.TabIndex = 17;
            this.lbOrderSummary.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Size:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(743, 127);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(39, 16);
            this.lbSize.TabIndex = 19;
            this.lbSize.Text = "Small";
            this.lbSize.Click += new System.EventHandler(this.lbSize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Toppings";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(713, 203);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(11, 16);
            this.lbToppings.TabIndex = 21;
            this.lbToppings.Text = ".";
            this.lbToppings.Click += new System.EventHandler(this.lbToppings_Click);
            // 
            // lbW
            // 
            this.lbW.AutoSize = true;
            this.lbW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbW.Location = new System.Drawing.Point(675, 256);
            this.lbW.Name = "lbW";
            this.lbW.Size = new System.Drawing.Size(126, 19);
            this.lbW.TabIndex = 22;
            this.lbW.Text = "WhereTo Eat :";
            // 
            // lbWhrToEat
            // 
            this.lbWhrToEat.AutoSize = true;
            this.lbWhrToEat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhrToEat.Location = new System.Drawing.Point(731, 293);
            this.lbWhrToEat.Name = "lbWhrToEat";
            this.lbWhrToEat.Size = new System.Drawing.Size(11, 16);
            this.lbWhrToEat.TabIndex = 23;
            this.lbWhrToEat.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Crust:";
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(747, 328);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(11, 16);
            this.lbCrust.TabIndex = 25;
            this.lbCrust.Text = ".";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 546);
            this.Controls.Add(this.lbCrust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbWhrToEat);
            this.Controls.Add(this.lbW);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOrderSummary);
            this.Controls.Add(this.lbRealPriceNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTotalprice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lbSize_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbToppings_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbTotalprice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRealPriceNum;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbW;
        private System.Windows.Forms.Label lbWhrToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCrust;
    }
}