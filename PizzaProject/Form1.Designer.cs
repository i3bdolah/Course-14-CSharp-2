namespace PizzaProject
{
    partial class Form1
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
            this.GbSize = new System.Windows.Forms.GroupBox();
            this.RbLarge = new System.Windows.Forms.RadioButton();
            this.RbMedium = new System.Windows.Forms.RadioButton();
            this.RbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbToppings = new System.Windows.Forms.GroupBox();
            this.CbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.CbOlives = new System.Windows.Forms.CheckBox();
            this.CbOnions = new System.Windows.Forms.CheckBox();
            this.CbTomatoes = new System.Windows.Forms.CheckBox();
            this.CbMushrooms = new System.Windows.Forms.CheckBox();
            this.CbExtraCheese = new System.Windows.Forms.CheckBox();
            this.GbCrust = new System.Windows.Forms.GroupBox();
            this.RbThick = new System.Windows.Forms.RadioButton();
            this.RbThin = new System.Windows.Forms.RadioButton();
            this.GbWhereToEat = new System.Windows.Forms.GroupBox();
            this.RbTakeAway = new System.Windows.Forms.RadioButton();
            this.RbTakeIn = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.LblTitleSize = new System.Windows.Forms.Label();
            this.LblTitleToppings = new System.Windows.Forms.Label();
            this.LblTitleCrust = new System.Windows.Forms.Label();
            this.LblTitleWhereToEat = new System.Windows.Forms.Label();
            this.LblTitleTotal = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblWhereToEat = new System.Windows.Forms.Label();
            this.LblCrust = new System.Windows.Forms.Label();
            this.LblToppings = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.GbSummary = new System.Windows.Forms.GroupBox();
            this.LblDollar = new System.Windows.Forms.Label();
            this.GbSize.SuspendLayout();
            this.GbToppings.SuspendLayout();
            this.GbCrust.SuspendLayout();
            this.GbWhereToEat.SuspendLayout();
            this.GbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSize
            // 
            this.GbSize.Controls.Add(this.RbLarge);
            this.GbSize.Controls.Add(this.RbMedium);
            this.GbSize.Controls.Add(this.RbSmall);
            this.GbSize.Location = new System.Drawing.Point(25, 58);
            this.GbSize.Name = "GbSize";
            this.GbSize.Size = new System.Drawing.Size(152, 167);
            this.GbSize.TabIndex = 0;
            this.GbSize.TabStop = false;
            this.GbSize.Text = "Size";
            this.GbSize.EnabledChanged += new System.EventHandler(this.GbSize_EnabledChanged);
            // 
            // RbLarge
            // 
            this.RbLarge.AutoSize = true;
            this.RbLarge.Location = new System.Drawing.Point(34, 110);
            this.RbLarge.Name = "RbLarge";
            this.RbLarge.Size = new System.Drawing.Size(52, 17);
            this.RbLarge.TabIndex = 5;
            this.RbLarge.TabStop = true;
            this.RbLarge.Tag = "50";
            this.RbLarge.Text = "Large";
            this.RbLarge.UseVisualStyleBackColor = true;
            this.RbLarge.CheckedChanged += new System.EventHandler(this.RbLarge_CheckedChanged);
            // 
            // RbMedium
            // 
            this.RbMedium.AutoSize = true;
            this.RbMedium.Location = new System.Drawing.Point(34, 75);
            this.RbMedium.Name = "RbMedium";
            this.RbMedium.Size = new System.Drawing.Size(62, 17);
            this.RbMedium.TabIndex = 4;
            this.RbMedium.TabStop = true;
            this.RbMedium.Tag = "40";
            this.RbMedium.Text = "Medium";
            this.RbMedium.UseVisualStyleBackColor = true;
            this.RbMedium.CheckedChanged += new System.EventHandler(this.RbMedium_CheckedChanged);
            // 
            // RbSmall
            // 
            this.RbSmall.AutoSize = true;
            this.RbSmall.Location = new System.Drawing.Point(34, 40);
            this.RbSmall.Name = "RbSmall";
            this.RbSmall.Size = new System.Drawing.Size(50, 17);
            this.RbSmall.TabIndex = 3;
            this.RbSmall.TabStop = true;
            this.RbSmall.Tag = "30";
            this.RbSmall.Text = "Small";
            this.RbSmall.UseVisualStyleBackColor = true;
            this.RbSmall.CheckedChanged += new System.EventHandler(this.RbSmall_CheckedChanged);
            // 
            // GbToppings
            // 
            this.GbToppings.Controls.Add(this.CbGreenPeppers);
            this.GbToppings.Controls.Add(this.CbOlives);
            this.GbToppings.Controls.Add(this.CbOnions);
            this.GbToppings.Controls.Add(this.CbTomatoes);
            this.GbToppings.Controls.Add(this.CbMushrooms);
            this.GbToppings.Controls.Add(this.CbExtraCheese);
            this.GbToppings.Location = new System.Drawing.Point(343, 58);
            this.GbToppings.Name = "GbToppings";
            this.GbToppings.Size = new System.Drawing.Size(244, 167);
            this.GbToppings.TabIndex = 1;
            this.GbToppings.TabStop = false;
            this.GbToppings.Text = "Toppings";
            // 
            // CbGreenPeppers
            // 
            this.CbGreenPeppers.AutoSize = true;
            this.CbGreenPeppers.Location = new System.Drawing.Point(141, 110);
            this.CbGreenPeppers.Name = "CbGreenPeppers";
            this.CbGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.CbGreenPeppers.TabIndex = 5;
            this.CbGreenPeppers.Tag = "5";
            this.CbGreenPeppers.Text = "Green Peppers";
            this.CbGreenPeppers.UseVisualStyleBackColor = true;
            this.CbGreenPeppers.CheckedChanged += new System.EventHandler(this.CbGreenPeppers_CheckedChanged);
            // 
            // CbOlives
            // 
            this.CbOlives.AutoSize = true;
            this.CbOlives.Location = new System.Drawing.Point(141, 75);
            this.CbOlives.Name = "CbOlives";
            this.CbOlives.Size = new System.Drawing.Size(55, 17);
            this.CbOlives.TabIndex = 4;
            this.CbOlives.Tag = "5";
            this.CbOlives.Text = "Olives";
            this.CbOlives.UseVisualStyleBackColor = true;
            this.CbOlives.CheckedChanged += new System.EventHandler(this.CbOlives_CheckedChanged);
            // 
            // CbOnions
            // 
            this.CbOnions.AutoSize = true;
            this.CbOnions.Location = new System.Drawing.Point(141, 40);
            this.CbOnions.Name = "CbOnions";
            this.CbOnions.Size = new System.Drawing.Size(59, 17);
            this.CbOnions.TabIndex = 3;
            this.CbOnions.Tag = "5";
            this.CbOnions.Text = "Onions";
            this.CbOnions.UseVisualStyleBackColor = true;
            this.CbOnions.CheckedChanged += new System.EventHandler(this.CbOnions_CheckedChanged);
            // 
            // CbTomatoes
            // 
            this.CbTomatoes.AutoSize = true;
            this.CbTomatoes.Location = new System.Drawing.Point(18, 110);
            this.CbTomatoes.Name = "CbTomatoes";
            this.CbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.CbTomatoes.TabIndex = 2;
            this.CbTomatoes.Tag = "5";
            this.CbTomatoes.Text = "Tomatoes";
            this.CbTomatoes.UseVisualStyleBackColor = true;
            this.CbTomatoes.CheckedChanged += new System.EventHandler(this.CbTomatoes_CheckedChanged);
            // 
            // CbMushrooms
            // 
            this.CbMushrooms.AutoSize = true;
            this.CbMushrooms.Location = new System.Drawing.Point(18, 75);
            this.CbMushrooms.Name = "CbMushrooms";
            this.CbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.CbMushrooms.TabIndex = 1;
            this.CbMushrooms.Tag = "5";
            this.CbMushrooms.Text = "Mushrooms";
            this.CbMushrooms.UseVisualStyleBackColor = true;
            this.CbMushrooms.CheckedChanged += new System.EventHandler(this.CbMushrooms_CheckedChanged);
            // 
            // CbExtraCheese
            // 
            this.CbExtraCheese.AutoSize = true;
            this.CbExtraCheese.Location = new System.Drawing.Point(18, 40);
            this.CbExtraCheese.Name = "CbExtraCheese";
            this.CbExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.CbExtraCheese.TabIndex = 0;
            this.CbExtraCheese.Tag = "5";
            this.CbExtraCheese.Text = "Extra Cheese";
            this.CbExtraCheese.UseVisualStyleBackColor = true;
            this.CbExtraCheese.CheckedChanged += new System.EventHandler(this.CbExtraCheese_CheckedChanged);
            // 
            // GbCrust
            // 
            this.GbCrust.Controls.Add(this.RbThick);
            this.GbCrust.Controls.Add(this.RbThin);
            this.GbCrust.Location = new System.Drawing.Point(25, 248);
            this.GbCrust.Name = "GbCrust";
            this.GbCrust.Size = new System.Drawing.Size(152, 167);
            this.GbCrust.TabIndex = 1;
            this.GbCrust.TabStop = false;
            this.GbCrust.Text = "Crust";
            // 
            // RbThick
            // 
            this.RbThick.AutoSize = true;
            this.RbThick.Location = new System.Drawing.Point(34, 93);
            this.RbThick.Name = "RbThick";
            this.RbThick.Size = new System.Drawing.Size(52, 17);
            this.RbThick.TabIndex = 4;
            this.RbThick.TabStop = true;
            this.RbThick.Tag = "20";
            this.RbThick.Text = "Thick";
            this.RbThick.UseVisualStyleBackColor = true;
            this.RbThick.CheckedChanged += new System.EventHandler(this.RbThick_CheckedChanged);
            // 
            // RbThin
            // 
            this.RbThin.AutoSize = true;
            this.RbThin.Location = new System.Drawing.Point(34, 58);
            this.RbThin.Name = "RbThin";
            this.RbThin.Size = new System.Drawing.Size(46, 17);
            this.RbThin.TabIndex = 3;
            this.RbThin.TabStop = true;
            this.RbThin.Tag = "10";
            this.RbThin.Text = "Thin";
            this.RbThin.UseVisualStyleBackColor = true;
            this.RbThin.CheckedChanged += new System.EventHandler(this.RbThin_CheckedChanged);
            // 
            // GbWhereToEat
            // 
            this.GbWhereToEat.Controls.Add(this.RbTakeAway);
            this.GbWhereToEat.Controls.Add(this.RbTakeIn);
            this.GbWhereToEat.Location = new System.Drawing.Point(343, 248);
            this.GbWhereToEat.Name = "GbWhereToEat";
            this.GbWhereToEat.Size = new System.Drawing.Size(244, 111);
            this.GbWhereToEat.TabIndex = 2;
            this.GbWhereToEat.TabStop = false;
            this.GbWhereToEat.Text = "Where To Eat";
            // 
            // RbTakeAway
            // 
            this.RbTakeAway.AutoSize = true;
            this.RbTakeAway.Location = new System.Drawing.Point(141, 49);
            this.RbTakeAway.Name = "RbTakeAway";
            this.RbTakeAway.Size = new System.Drawing.Size(79, 17);
            this.RbTakeAway.TabIndex = 4;
            this.RbTakeAway.TabStop = true;
            this.RbTakeAway.Text = "Take Away";
            this.RbTakeAway.UseVisualStyleBackColor = true;
            this.RbTakeAway.CheckedChanged += new System.EventHandler(this.RbTakeAway_CheckedChanged);
            // 
            // RbTakeIn
            // 
            this.RbTakeIn.AutoSize = true;
            this.RbTakeIn.Location = new System.Drawing.Point(18, 49);
            this.RbTakeIn.Name = "RbTakeIn";
            this.RbTakeIn.Size = new System.Drawing.Size(62, 17);
            this.RbTakeIn.TabIndex = 3;
            this.RbTakeIn.TabStop = true;
            this.RbTakeIn.Text = "Take In";
            this.RbTakeIn.UseVisualStyleBackColor = true;
            this.RbTakeIn.CheckedChanged += new System.EventHandler(this.RbTakeIn_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(343, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(484, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // LblTitleSize
            // 
            this.LblTitleSize.AutoSize = true;
            this.LblTitleSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleSize.Location = new System.Drawing.Point(19, 44);
            this.LblTitleSize.Name = "LblTitleSize";
            this.LblTitleSize.Size = new System.Drawing.Size(43, 13);
            this.LblTitleSize.TabIndex = 0;
            this.LblTitleSize.Text = "Size : ";
            // 
            // LblTitleToppings
            // 
            this.LblTitleToppings.AutoSize = true;
            this.LblTitleToppings.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitleToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleToppings.Location = new System.Drawing.Point(19, 89);
            this.LblTitleToppings.Name = "LblTitleToppings";
            this.LblTitleToppings.Size = new System.Drawing.Size(71, 13);
            this.LblTitleToppings.TabIndex = 1;
            this.LblTitleToppings.Text = "Toppings : ";
            // 
            // LblTitleCrust
            // 
            this.LblTitleCrust.AutoSize = true;
            this.LblTitleCrust.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitleCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleCrust.Location = new System.Drawing.Point(19, 148);
            this.LblTitleCrust.Name = "LblTitleCrust";
            this.LblTitleCrust.Size = new System.Drawing.Size(48, 13);
            this.LblTitleCrust.TabIndex = 2;
            this.LblTitleCrust.Text = "Crust : ";
            // 
            // LblTitleWhereToEat
            // 
            this.LblTitleWhereToEat.AutoSize = true;
            this.LblTitleWhereToEat.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitleWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleWhereToEat.Location = new System.Drawing.Point(19, 200);
            this.LblTitleWhereToEat.Name = "LblTitleWhereToEat";
            this.LblTitleWhereToEat.Size = new System.Drawing.Size(98, 13);
            this.LblTitleWhereToEat.TabIndex = 3;
            this.LblTitleWhereToEat.Text = "Where To Eat : ";
            // 
            // LblTitleTotal
            // 
            this.LblTitleTotal.AutoSize = true;
            this.LblTitleTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleTotal.Location = new System.Drawing.Point(19, 252);
            this.LblTitleTotal.Name = "LblTitleTotal";
            this.LblTitleTotal.Size = new System.Drawing.Size(81, 13);
            this.LblTitleTotal.TabIndex = 4;
            this.LblTitleTotal.Text = "Total Price : ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Green;
            this.LblTotal.Location = new System.Drawing.Point(108, 300);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(25, 26);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "0";
            // 
            // LblWhereToEat
            // 
            this.LblWhereToEat.AutoSize = true;
            this.LblWhereToEat.Location = new System.Drawing.Point(19, 224);
            this.LblWhereToEat.Name = "LblWhereToEat";
            this.LblWhereToEat.Size = new System.Drawing.Size(28, 13);
            this.LblWhereToEat.TabIndex = 6;
            this.LblWhereToEat.Text = "       ";
            // 
            // LblCrust
            // 
            this.LblCrust.AutoSize = true;
            this.LblCrust.Location = new System.Drawing.Point(19, 173);
            this.LblCrust.Name = "LblCrust";
            this.LblCrust.Size = new System.Drawing.Size(28, 13);
            this.LblCrust.TabIndex = 7;
            this.LblCrust.Text = "       ";
            // 
            // LblToppings
            // 
            this.LblToppings.AutoSize = true;
            this.LblToppings.Location = new System.Drawing.Point(19, 110);
            this.LblToppings.MaximumSize = new System.Drawing.Size(200, 0);
            this.LblToppings.Name = "LblToppings";
            this.LblToppings.Size = new System.Drawing.Size(28, 13);
            this.LblToppings.TabIndex = 8;
            this.LblToppings.Text = "       ";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(19, 65);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(28, 13);
            this.LblSize.TabIndex = 9;
            this.LblSize.Text = "       ";
            // 
            // GbSummary
            // 
            this.GbSummary.Controls.Add(this.LblDollar);
            this.GbSummary.Controls.Add(this.LblSize);
            this.GbSummary.Controls.Add(this.LblToppings);
            this.GbSummary.Controls.Add(this.LblCrust);
            this.GbSummary.Controls.Add(this.LblWhereToEat);
            this.GbSummary.Controls.Add(this.LblTotal);
            this.GbSummary.Controls.Add(this.LblTitleTotal);
            this.GbSummary.Controls.Add(this.LblTitleWhereToEat);
            this.GbSummary.Controls.Add(this.LblTitleCrust);
            this.GbSummary.Controls.Add(this.LblTitleToppings);
            this.GbSummary.Controls.Add(this.LblTitleSize);
            this.GbSummary.Location = new System.Drawing.Point(722, 58);
            this.GbSummary.Name = "GbSummary";
            this.GbSummary.Size = new System.Drawing.Size(230, 357);
            this.GbSummary.TabIndex = 1;
            this.GbSummary.TabStop = false;
            this.GbSummary.Text = "Summary";
            // 
            // LblDollar
            // 
            this.LblDollar.AutoSize = true;
            this.LblDollar.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDollar.ForeColor = System.Drawing.Color.Green;
            this.LblDollar.Location = new System.Drawing.Point(83, 300);
            this.LblDollar.Name = "LblDollar";
            this.LblDollar.Size = new System.Drawing.Size(25, 26);
            this.LblDollar.TabIndex = 10;
            this.LblDollar.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 513);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.GbWhereToEat);
            this.Controls.Add(this.GbCrust);
            this.Controls.Add(this.GbSummary);
            this.Controls.Add(this.GbToppings);
            this.Controls.Add(this.GbSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbSize.ResumeLayout(false);
            this.GbSize.PerformLayout();
            this.GbToppings.ResumeLayout(false);
            this.GbToppings.PerformLayout();
            this.GbCrust.ResumeLayout(false);
            this.GbCrust.PerformLayout();
            this.GbWhereToEat.ResumeLayout(false);
            this.GbWhereToEat.PerformLayout();
            this.GbSummary.ResumeLayout(false);
            this.GbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GbToppings;
        private System.Windows.Forms.GroupBox GbCrust;
        private System.Windows.Forms.GroupBox GbWhereToEat;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton RbLarge;
        private System.Windows.Forms.RadioButton RbMedium;
        private System.Windows.Forms.RadioButton RbSmall;
        private System.Windows.Forms.CheckBox CbGreenPeppers;
        private System.Windows.Forms.CheckBox CbOlives;
        private System.Windows.Forms.CheckBox CbOnions;
        private System.Windows.Forms.CheckBox CbTomatoes;
        private System.Windows.Forms.CheckBox CbMushrooms;
        private System.Windows.Forms.CheckBox CbExtraCheese;
        private System.Windows.Forms.RadioButton RbThick;
        private System.Windows.Forms.RadioButton RbThin;
        private System.Windows.Forms.RadioButton RbTakeAway;
        private System.Windows.Forms.RadioButton RbTakeIn;
        private System.Windows.Forms.Label LblTitleSize;
        private System.Windows.Forms.Label LblTitleToppings;
        private System.Windows.Forms.Label LblTitleCrust;
        private System.Windows.Forms.Label LblTitleWhereToEat;
        private System.Windows.Forms.Label LblTitleTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblWhereToEat;
        private System.Windows.Forms.Label LblCrust;
        private System.Windows.Forms.Label LblToppings;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.GroupBox GbSummary;
        private System.Windows.Forms.Label LblDollar;
    }
}

