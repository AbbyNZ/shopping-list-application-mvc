namespace Assignment1B
{
    partial class TextView
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
            this.components = new System.ComponentModel.Container();
            this.pnlView = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.rbFruits = new System.Windows.Forms.RadioButton();
            this.rbVege = new System.Windows.Forms.RadioButton();
            this.lblMeatFish = new System.Windows.Forms.Label();
            this.rbChicken = new System.Windows.Forms.RadioButton();
            this.rbBeef = new System.Windows.Forms.RadioButton();
            this.rbPork = new System.Windows.Forms.RadioButton();
            this.rbFish = new System.Windows.Forms.RadioButton();
            this.lblCondiments = new System.Windows.Forms.Label();
            this.rbShampoo = new System.Windows.Forms.RadioButton();
            this.rbSoap = new System.Windows.Forms.RadioButton();
            this.rbHand = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlTextUpdate = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUpdateColour = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlView.SuspendLayout();
            this.pnlTextUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Controls.Add(this.listBox1);
            this.pnlView.Location = new System.Drawing.Point(12, 12);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(392, 379);
            this.pnlView.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 342);
            this.listBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(411, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 22);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(515, 340);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(84, 22);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify Item";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(414, 27);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(86, 16);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "PRODUCE:";
            // 
            // rbFruits
            // 
            this.rbFruits.AutoSize = true;
            this.rbFruits.Location = new System.Drawing.Point(411, 47);
            this.rbFruits.Name = "rbFruits";
            this.rbFruits.Size = new System.Drawing.Size(50, 17);
            this.rbFruits.TabIndex = 6;
            this.rbFruits.TabStop = true;
            this.rbFruits.Text = "Fruits";
            this.rbFruits.UseVisualStyleBackColor = true;
            // 
            // rbVege
            // 
            this.rbVege.AutoSize = true;
            this.rbVege.Location = new System.Drawing.Point(411, 71);
            this.rbVege.Name = "rbVege";
            this.rbVege.Size = new System.Drawing.Size(78, 17);
            this.rbVege.TabIndex = 7;
            this.rbVege.TabStop = true;
            this.rbVege.Text = "Vegetables";
            this.rbVege.UseVisualStyleBackColor = true;
            // 
            // lblMeatFish
            // 
            this.lblMeatFish.AutoSize = true;
            this.lblMeatFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeatFish.Location = new System.Drawing.Point(414, 114);
            this.lblMeatFish.Name = "lblMeatFish";
            this.lblMeatFish.Size = new System.Drawing.Size(93, 16);
            this.lblMeatFish.TabIndex = 8;
            this.lblMeatFish.Text = "MEAT/FISH:";
            // 
            // rbChicken
            // 
            this.rbChicken.AutoSize = true;
            this.rbChicken.Location = new System.Drawing.Point(411, 133);
            this.rbChicken.Name = "rbChicken";
            this.rbChicken.Size = new System.Drawing.Size(64, 17);
            this.rbChicken.TabIndex = 9;
            this.rbChicken.TabStop = true;
            this.rbChicken.Text = "Chicken";
            this.rbChicken.UseVisualStyleBackColor = true;
            // 
            // rbBeef
            // 
            this.rbBeef.AutoSize = true;
            this.rbBeef.Location = new System.Drawing.Point(411, 156);
            this.rbBeef.Name = "rbBeef";
            this.rbBeef.Size = new System.Drawing.Size(47, 17);
            this.rbBeef.TabIndex = 10;
            this.rbBeef.TabStop = true;
            this.rbBeef.Text = "Beef";
            this.rbBeef.UseVisualStyleBackColor = true;
            // 
            // rbPork
            // 
            this.rbPork.AutoSize = true;
            this.rbPork.Location = new System.Drawing.Point(411, 179);
            this.rbPork.Name = "rbPork";
            this.rbPork.Size = new System.Drawing.Size(47, 17);
            this.rbPork.TabIndex = 11;
            this.rbPork.TabStop = true;
            this.rbPork.Text = "Pork";
            this.rbPork.UseVisualStyleBackColor = true;
            // 
            // rbFish
            // 
            this.rbFish.AutoSize = true;
            this.rbFish.Location = new System.Drawing.Point(411, 202);
            this.rbFish.Name = "rbFish";
            this.rbFish.Size = new System.Drawing.Size(44, 17);
            this.rbFish.TabIndex = 12;
            this.rbFish.TabStop = true;
            this.rbFish.Text = "Fish";
            this.rbFish.UseVisualStyleBackColor = true;
            // 
            // lblCondiments
            // 
            this.lblCondiments.AutoSize = true;
            this.lblCondiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondiments.Location = new System.Drawing.Point(414, 235);
            this.lblCondiments.Name = "lblCondiments";
            this.lblCondiments.Size = new System.Drawing.Size(138, 16);
            this.lblCondiments.TabIndex = 13;
            this.lblCondiments.Text = "PERSONAL CARE:";
            // 
            // rbShampoo
            // 
            this.rbShampoo.AutoSize = true;
            this.rbShampoo.Location = new System.Drawing.Point(411, 254);
            this.rbShampoo.Name = "rbShampoo";
            this.rbShampoo.Size = new System.Drawing.Size(128, 17);
            this.rbShampoo.TabIndex = 14;
            this.rbShampoo.TabStop = true;
            this.rbShampoo.Text = "Shampoo/Conditioner";
            this.rbShampoo.UseVisualStyleBackColor = true;
            // 
            // rbSoap
            // 
            this.rbSoap.AutoSize = true;
            this.rbSoap.Location = new System.Drawing.Point(411, 277);
            this.rbSoap.Name = "rbSoap";
            this.rbSoap.Size = new System.Drawing.Size(50, 17);
            this.rbSoap.TabIndex = 15;
            this.rbSoap.TabStop = true;
            this.rbSoap.Text = "Soap";
            this.rbSoap.UseVisualStyleBackColor = true;
            // 
            // rbHand
            // 
            this.rbHand.AutoSize = true;
            this.rbHand.Location = new System.Drawing.Point(411, 301);
            this.rbHand.Name = "rbHand";
            this.rbHand.Size = new System.Drawing.Size(79, 17);
            this.rbHand.TabIndex = 16;
            this.rbHand.TabStop = true;
            this.rbHand.Text = "Hand Soap";
            this.rbHand.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTextUpdate
            // 
            this.pnlTextUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTextUpdate.Controls.Add(this.btnCancel);
            this.pnlTextUpdate.Controls.Add(this.lblUpdateColour);
            this.pnlTextUpdate.Controls.Add(this.panel3);
            this.pnlTextUpdate.Controls.Add(this.lblColour);
            this.pnlTextUpdate.Controls.Add(this.btnUpdate);
            this.pnlTextUpdate.Location = new System.Drawing.Point(495, 3);
            this.pnlTextUpdate.Name = "pnlTextUpdate";
            this.pnlTextUpdate.Size = new System.Drawing.Size(176, 127);
            this.pnlTextUpdate.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(4, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUpdateColour
            // 
            this.lblUpdateColour.BackColor = System.Drawing.Color.Lime;
            this.lblUpdateColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdateColour.Location = new System.Drawing.Point(129, 71);
            this.lblUpdateColour.Name = "lblUpdateColour";
            this.lblUpdateColour.Size = new System.Drawing.Size(24, 24);
            this.lblUpdateColour.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.lblSelectColor);
            this.panel3.Location = new System.Drawing.Point(17, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 64);
            this.panel3.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Gray;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(56, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 24);
            this.label20.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(104, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 24);
            this.label21.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Purple;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(80, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 24);
            this.label22.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Maroon;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(32, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 24);
            this.label23.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Red;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(8, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 24);
            this.label24.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Magenta;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Location = new System.Drawing.Point(104, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 24);
            this.label25.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Blue;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Location = new System.Drawing.Point(80, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 24);
            this.label26.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Aqua;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Location = new System.Drawing.Point(56, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(24, 24);
            this.label27.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Lime;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.Location = new System.Drawing.Point(32, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 24);
            this.label28.TabIndex = 1;
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.BackColor = System.Drawing.Color.Yellow;
            this.lblSelectColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectColor.Location = new System.Drawing.Point(8, 8);
            this.lblSelectColor.Name = "lblSelectColor";
            this.lblSelectColor.Size = new System.Drawing.Size(24, 24);
            this.lblSelectColor.TabIndex = 0;
            this.lblSelectColor.Click += new System.EventHandler(this.lblSelectColor_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(55, 71);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(53, 16);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "Colour";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(90, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 403);
            this.Controls.Add(this.pnlTextUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbHand);
            this.Controls.Add(this.rbSoap);
            this.Controls.Add(this.rbShampoo);
            this.Controls.Add(this.lblCondiments);
            this.Controls.Add(this.rbFish);
            this.Controls.Add(this.rbPork);
            this.Controls.Add(this.rbBeef);
            this.Controls.Add(this.rbChicken);
            this.Controls.Add(this.lblMeatFish);
            this.Controls.Add(this.rbVege);
            this.Controls.Add(this.rbFruits);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlView);
            this.Name = "TextView";
            this.Text = "TextView";
            this.Load += new System.EventHandler(this.TextView_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlTextUpdate.ResumeLayout(false);
            this.pnlTextUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.RadioButton rbFruits;
        private System.Windows.Forms.RadioButton rbVege;
        private System.Windows.Forms.Label lblMeatFish;
        private System.Windows.Forms.RadioButton rbChicken;
        private System.Windows.Forms.RadioButton rbBeef;
        private System.Windows.Forms.RadioButton rbPork;
        private System.Windows.Forms.RadioButton rbFish;
        private System.Windows.Forms.Label lblCondiments;
        private System.Windows.Forms.RadioButton rbShampoo;
        private System.Windows.Forms.RadioButton rbSoap;
        private System.Windows.Forms.RadioButton rbHand;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlTextUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUpdateColour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblSelectColor;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button btnUpdate;
    }
}