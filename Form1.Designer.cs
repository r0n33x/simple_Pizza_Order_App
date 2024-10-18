namespace MakeYourPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.ThinCrust = new System.Windows.Forms.RadioButton();
            this.ThinkCrust = new System.Windows.Forms.RadioButton();
            this.ToppingsGrpBx = new System.Windows.Forms.GroupBox();
            this.ExtraChees = new System.Windows.Forms.CheckBox();
            this.GreenPepers = new System.Windows.Forms.CheckBox();
            this.Union = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.Mushrooms = new System.Windows.Forms.CheckBox();
            this.Olives = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeGrpBx = new System.Windows.Forms.GroupBox();
            this.SmallSize = new System.Windows.Forms.RadioButton();
            this.MidumSize = new System.Windows.Forms.RadioButton();
            this.LargSize = new System.Windows.Forms.RadioButton();
            this.TakeOut = new System.Windows.Forms.RadioButton();
            this.WhereGrpBx = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderSummaryGrpBx = new System.Windows.Forms.GroupBox();
            this.lablWhrToEat = new System.Windows.Forms.Label();
            this.lablCrust = new System.Windows.Forms.Label();
            this.lablSize = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxToppings = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrustTypeGrpBx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EatIn = new System.Windows.Forms.RadioButton();
            this.ToppingsGrpBx.SuspendLayout();
            this.SizeGrpBx.SuspendLayout();
            this.WhereGrpBx.SuspendLayout();
            this.OrderSummaryGrpBx.SuspendLayout();
            this.CrustTypeGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(372, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make And Oreder Your Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThinCrust
            // 
            this.ThinCrust.AutoSize = true;
            this.ThinCrust.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThinCrust.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ThinCrust.Location = new System.Drawing.Point(29, 52);
            this.ThinCrust.Name = "ThinCrust";
            this.ThinCrust.Size = new System.Drawing.Size(173, 32);
            this.ThinCrust.TabIndex = 7;
            this.ThinCrust.TabStop = true;
            this.ThinCrust.Text = "Thin Crust";
            this.ThinCrust.UseVisualStyleBackColor = true;
            this.ThinCrust.CheckedChanged += new System.EventHandler(this.ThinCrust_CheckedChanged);
            // 
            // ThinkCrust
            // 
            this.ThinkCrust.AutoSize = true;
            this.ThinkCrust.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThinkCrust.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ThinkCrust.Location = new System.Drawing.Point(29, 99);
            this.ThinkCrust.Name = "ThinkCrust";
            this.ThinkCrust.Size = new System.Drawing.Size(187, 32);
            this.ThinkCrust.TabIndex = 6;
            this.ThinkCrust.TabStop = true;
            this.ThinkCrust.Text = "Think Crust";
            this.ThinkCrust.UseVisualStyleBackColor = true;
            this.ThinkCrust.CheckedChanged += new System.EventHandler(this.ThinkCrust_CheckedChanged);
            // 
            // ToppingsGrpBx
            // 
            this.ToppingsGrpBx.Controls.Add(this.ExtraChees);
            this.ToppingsGrpBx.Controls.Add(this.GreenPepers);
            this.ToppingsGrpBx.Controls.Add(this.Union);
            this.ToppingsGrpBx.Controls.Add(this.Tomatoes);
            this.ToppingsGrpBx.Controls.Add(this.Mushrooms);
            this.ToppingsGrpBx.Controls.Add(this.Olives);
            this.ToppingsGrpBx.Controls.Add(this.label4);
            this.ToppingsGrpBx.Location = new System.Drawing.Point(517, 128);
            this.ToppingsGrpBx.Name = "ToppingsGrpBx";
            this.ToppingsGrpBx.Size = new System.Drawing.Size(405, 204);
            this.ToppingsGrpBx.TabIndex = 12;
            this.ToppingsGrpBx.TabStop = false;
            this.ToppingsGrpBx.Enter += new System.EventHandler(this.ToppingsGrpBx_Enter);
            // 
            // ExtraChees
            // 
            this.ExtraChees.AutoSize = true;
            this.ExtraChees.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraChees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExtraChees.Location = new System.Drawing.Point(25, 52);
            this.ExtraChees.Name = "ExtraChees";
            this.ExtraChees.Size = new System.Drawing.Size(153, 25);
            this.ExtraChees.TabIndex = 8;
            this.ExtraChees.Text = "Extra Chees";
            this.ExtraChees.UseVisualStyleBackColor = true;
            this.ExtraChees.CheckedChanged += new System.EventHandler(this.ExtraChees_CheckedChanged);
            // 
            // GreenPepers
            // 
            this.GreenPepers.AutoSize = true;
            this.GreenPepers.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenPepers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GreenPepers.Location = new System.Drawing.Point(217, 147);
            this.GreenPepers.Name = "GreenPepers";
            this.GreenPepers.Size = new System.Drawing.Size(164, 25);
            this.GreenPepers.TabIndex = 7;
            this.GreenPepers.Text = "Green Pepers";
            this.GreenPepers.UseVisualStyleBackColor = true;
            this.GreenPepers.CheckedChanged += new System.EventHandler(this.GreenPepers_CheckedChanged);
            // 
            // Union
            // 
            this.Union.AutoSize = true;
            this.Union.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Union.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Union.Location = new System.Drawing.Point(217, 52);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(87, 25);
            this.Union.TabIndex = 6;
            this.Union.Text = "Union";
            this.Union.UseVisualStyleBackColor = true;
            this.Union.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Tomatoes
            // 
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomatoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tomatoes.Location = new System.Drawing.Point(25, 147);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(120, 25);
            this.Tomatoes.TabIndex = 5;
            this.Tomatoes.Text = "Tomatoes";
            this.Tomatoes.UseVisualStyleBackColor = true;
            this.Tomatoes.CheckedChanged += new System.EventHandler(this.Tomatoes_CheckedChanged);
            // 
            // Mushrooms
            // 
            this.Mushrooms.AutoSize = true;
            this.Mushrooms.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mushrooms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mushrooms.Location = new System.Drawing.Point(25, 99);
            this.Mushrooms.Name = "Mushrooms";
            this.Mushrooms.Size = new System.Drawing.Size(131, 25);
            this.Mushrooms.TabIndex = 4;
            this.Mushrooms.Text = "Mushrooms";
            this.Mushrooms.UseVisualStyleBackColor = true;
            this.Mushrooms.CheckedChanged += new System.EventHandler(this.Mushrooms_CheckedChanged);
            // 
            // Olives
            // 
            this.Olives.AutoSize = true;
            this.Olives.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olives.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Olives.Location = new System.Drawing.Point(217, 99);
            this.Olives.Name = "Olives";
            this.Olives.Size = new System.Drawing.Size(98, 25);
            this.Olives.TabIndex = 3;
            this.Olives.Text = "Olives";
            this.Olives.UseVisualStyleBackColor = true;
            this.Olives.CheckedChanged += new System.EventHandler(this.Olives_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SizeGrpBx
            // 
            this.SizeGrpBx.Controls.Add(this.label2);
            this.SizeGrpBx.Location = new System.Drawing.Point(38, 128);
            this.SizeGrpBx.Name = "SizeGrpBx";
            this.SizeGrpBx.Size = new System.Drawing.Size(154, 204);
            this.SizeGrpBx.TabIndex = 5;
            this.SizeGrpBx.TabStop = false;
            this.SizeGrpBx.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SmallSize
            // 
            this.SmallSize.AutoSize = true;
            this.SmallSize.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SmallSize.Location = new System.Drawing.Point(63, 180);
            this.SmallSize.Name = "SmallSize";
            this.SmallSize.Size = new System.Drawing.Size(103, 32);
            this.SmallSize.TabIndex = 2;
            this.SmallSize.TabStop = true;
            this.SmallSize.Text = "Small";
            this.SmallSize.UseVisualStyleBackColor = true;
            this.SmallSize.CheckedChanged += new System.EventHandler(this.SmallSize_CheckedChanged);
            // 
            // MidumSize
            // 
            this.MidumSize.AutoSize = true;
            this.MidumSize.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidumSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MidumSize.Location = new System.Drawing.Point(63, 227);
            this.MidumSize.Name = "MidumSize";
            this.MidumSize.Size = new System.Drawing.Size(103, 32);
            this.MidumSize.TabIndex = 3;
            this.MidumSize.TabStop = true;
            this.MidumSize.Text = "Midum";
            this.MidumSize.UseVisualStyleBackColor = true;
            this.MidumSize.CheckedChanged += new System.EventHandler(this.MidumSize_CheckedChanged);
            // 
            // LargSize
            // 
            this.LargSize.AutoSize = true;
            this.LargSize.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LargSize.Location = new System.Drawing.Point(63, 275);
            this.LargSize.Name = "LargSize";
            this.LargSize.Size = new System.Drawing.Size(89, 32);
            this.LargSize.TabIndex = 4;
            this.LargSize.TabStop = true;
            this.LargSize.Text = "Larg";
            this.LargSize.UseVisualStyleBackColor = true;
            this.LargSize.CheckedChanged += new System.EventHandler(this.LargSize_CheckedChanged);
            // 
            // TakeOut
            // 
            this.TakeOut.AutoSize = true;
            this.TakeOut.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TakeOut.Location = new System.Drawing.Point(34, 52);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(145, 32);
            this.TakeOut.TabIndex = 13;
            this.TakeOut.TabStop = true;
            this.TakeOut.Text = "Take Out";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.CheckedChanged += new System.EventHandler(this.TakeOut_CheckedChanged);
            // 
            // WhereGrpBx
            // 
            this.WhereGrpBx.Controls.Add(this.EatIn);
            this.WhereGrpBx.Controls.Add(this.label5);
            this.WhereGrpBx.Controls.Add(this.TakeOut);
            this.WhereGrpBx.Location = new System.Drawing.Point(953, 128);
            this.WhereGrpBx.Name = "WhereGrpBx";
            this.WhereGrpBx.Size = new System.Drawing.Size(255, 161);
            this.WhereGrpBx.TabIndex = 16;
            this.WhereGrpBx.TabStop = false;
            this.WhereGrpBx.Enter += new System.EventHandler(this.WhereGrpBx_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(20, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Where To Eat";
            // 
            // OrderSummaryGrpBx
            // 
            this.OrderSummaryGrpBx.Controls.Add(this.lablWhrToEat);
            this.OrderSummaryGrpBx.Controls.Add(this.lablCrust);
            this.OrderSummaryGrpBx.Controls.Add(this.lablSize);
            this.OrderSummaryGrpBx.Controls.Add(this.labPrice);
            this.OrderSummaryGrpBx.Controls.Add(this.label11);
            this.OrderSummaryGrpBx.Controls.Add(this.label10);
            this.OrderSummaryGrpBx.Controls.Add(this.txtBxToppings);
            this.OrderSummaryGrpBx.Controls.Add(this.label9);
            this.OrderSummaryGrpBx.Controls.Add(this.label8);
            this.OrderSummaryGrpBx.Controls.Add(this.label7);
            this.OrderSummaryGrpBx.Controls.Add(this.label6);
            this.OrderSummaryGrpBx.Location = new System.Drawing.Point(38, 358);
            this.OrderSummaryGrpBx.Name = "OrderSummaryGrpBx";
            this.OrderSummaryGrpBx.Size = new System.Drawing.Size(1170, 204);
            this.OrderSummaryGrpBx.TabIndex = 16;
            this.OrderSummaryGrpBx.TabStop = false;
            // 
            // lablWhrToEat
            // 
            this.lablWhrToEat.AutoSize = true;
            this.lablWhrToEat.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablWhrToEat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lablWhrToEat.Location = new System.Drawing.Point(970, 59);
            this.lablWhrToEat.Name = "lablWhrToEat";
            this.lablWhrToEat.Size = new System.Drawing.Size(124, 25);
            this.lablWhrToEat.TabIndex = 14;
            this.lablWhrToEat.Text = "Take Out";
            this.lablWhrToEat.Click += new System.EventHandler(this.lablWhrToEat_Click);
            // 
            // lablCrust
            // 
            this.lablCrust.AutoSize = true;
            this.lablCrust.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablCrust.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lablCrust.Location = new System.Drawing.Point(179, 135);
            this.lablCrust.Name = "lablCrust";
            this.lablCrust.Size = new System.Drawing.Size(68, 25);
            this.lablCrust.TabIndex = 13;
            this.lablCrust.Text = "Thin";
            this.lablCrust.Click += new System.EventHandler(this.lablCrust_Click);
            // 
            // lablSize
            // 
            this.lablSize.AutoSize = true;
            this.lablSize.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lablSize.Location = new System.Drawing.Point(91, 59);
            this.lablSize.Name = "lablSize";
            this.lablSize.Size = new System.Drawing.Size(82, 25);
            this.lablSize.TabIndex = 12;
            this.lablSize.Text = "Small";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.Color.Lime;
            this.labPrice.Location = new System.Drawing.Point(910, 131);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(47, 35);
            this.labPrice.TabIndex = 11;
            this.labPrice.Text = "$0";
            this.labPrice.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(804, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Price : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(779, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "Where To Eat :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBxToppings
            // 
            this.txtBxToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtBxToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxToppings.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxToppings.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBxToppings.Location = new System.Drawing.Point(438, 63);
            this.txtBxToppings.Multiline = true;
            this.txtBxToppings.Name = "txtBxToppings";
            this.txtBxToppings.Size = new System.Drawing.Size(311, 103);
            this.txtBxToppings.TabIndex = 7;
            this.txtBxToppings.Text = "NO TOPPINGS Added";
            this.txtBxToppings.TextChanged += new System.EventHandler(this.TxtBxToppings_EnabledChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(295, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Toppings : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Crust Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Size : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(19, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(23, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crust Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CrustTypeGrpBx
            // 
            this.CrustTypeGrpBx.Controls.Add(this.label3);
            this.CrustTypeGrpBx.Controls.Add(this.ThinCrust);
            this.CrustTypeGrpBx.Controls.Add(this.ThinkCrust);
            this.CrustTypeGrpBx.Location = new System.Drawing.Point(233, 128);
            this.CrustTypeGrpBx.Name = "CrustTypeGrpBx";
            this.CrustTypeGrpBx.Size = new System.Drawing.Size(249, 161);
            this.CrustTypeGrpBx.TabIndex = 17;
            this.CrustTypeGrpBx.TabStop = false;
            this.CrustTypeGrpBx.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1096, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Order Pizza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(964, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 54);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EatIn
            // 
            this.EatIn.AutoSize = true;
            this.EatIn.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EatIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EatIn.Location = new System.Drawing.Point(34, 99);
            this.EatIn.Name = "EatIn";
            this.EatIn.Size = new System.Drawing.Size(117, 32);
            this.EatIn.TabIndex = 14;
            this.EatIn.TabStop = true;
            this.EatIn.Text = "Eat In";
            this.EatIn.UseVisualStyleBackColor = true;
            this.EatIn.CheckedChanged += new System.EventHandler(this.EatIn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1242, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderSummaryGrpBx);
            this.Controls.Add(this.WhereGrpBx);
            this.Controls.Add(this.ToppingsGrpBx);
            this.Controls.Add(this.LargSize);
            this.Controls.Add(this.MidumSize);
            this.Controls.Add(this.SmallSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeGrpBx);
            this.Controls.Add(this.CrustTypeGrpBx);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToppingsGrpBx.ResumeLayout(false);
            this.ToppingsGrpBx.PerformLayout();
            this.SizeGrpBx.ResumeLayout(false);
            this.SizeGrpBx.PerformLayout();
            this.WhereGrpBx.ResumeLayout(false);
            this.WhereGrpBx.PerformLayout();
            this.OrderSummaryGrpBx.ResumeLayout(false);
            this.OrderSummaryGrpBx.PerformLayout();
            this.CrustTypeGrpBx.ResumeLayout(false);
            this.CrustTypeGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ThinCrust;
        private System.Windows.Forms.RadioButton ThinkCrust;
        private System.Windows.Forms.GroupBox ToppingsGrpBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SizeGrpBx;
        private System.Windows.Forms.RadioButton SmallSize;
        private System.Windows.Forms.RadioButton MidumSize;
        private System.Windows.Forms.RadioButton LargSize;
        private System.Windows.Forms.RadioButton TakeOut;
        private System.Windows.Forms.GroupBox WhereGrpBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox OrderSummaryGrpBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox CrustTypeGrpBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox GreenPepers;
        private System.Windows.Forms.CheckBox Union;
        private System.Windows.Forms.CheckBox Tomatoes;
        private System.Windows.Forms.CheckBox Mushrooms;
        private System.Windows.Forms.CheckBox Olives;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label lablSize;
        private System.Windows.Forms.Label lablCrust;
        private System.Windows.Forms.Label lablWhrToEat;
        private System.Windows.Forms.CheckBox ExtraChees;
        private System.Windows.Forms.RadioButton EatIn;
    }
}

