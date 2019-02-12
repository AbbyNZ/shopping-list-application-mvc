namespace Assignment1B
{
    partial class ReadOnlyView
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.cmbFilterDisplay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Location = new System.Drawing.Point(12, 12);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(392, 357);
            this.pnlView.TabIndex = 1;
            // 
            // cmbFilterDisplay
            // 
            this.cmbFilterDisplay.FormattingEnabled = true;
            this.cmbFilterDisplay.Items.AddRange(new object[] {
            "Select display.....",
            "All Items",
            "Produce only",
            "Meat/Fish only",
            "Personal Care only"});
            this.cmbFilterDisplay.Location = new System.Drawing.Point(87, 386);
            this.cmbFilterDisplay.Name = "cmbFilterDisplay";
            this.cmbFilterDisplay.Size = new System.Drawing.Size(238, 21);
            this.cmbFilterDisplay.TabIndex = 2;
            this.cmbFilterDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDisplay_SelectedIndexChanged);
            // 
            // ReadOnlyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 424);
            this.Controls.Add(this.cmbFilterDisplay);
            this.Controls.Add(this.pnlView);
            this.Name = "ReadOnlyView";
            this.Text = "ReadOnlyView";
            this.Load += new System.EventHandler(this.ReadOnlyView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ComboBox cmbFilterDisplay;
    }
}