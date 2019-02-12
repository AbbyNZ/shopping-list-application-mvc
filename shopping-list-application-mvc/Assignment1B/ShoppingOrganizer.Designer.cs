namespace Assignment1B
{
    partial class ShoppingOrganizer
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
            this.btnTextView = new System.Windows.Forms.Button();
            this.btnGraphicView = new System.Windows.Forms.Button();
            this.btnReadView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTextView
            // 
            this.btnTextView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextView.Location = new System.Drawing.Point(30, 41);
            this.btnTextView.Name = "btnTextView";
            this.btnTextView.Size = new System.Drawing.Size(220, 61);
            this.btnTextView.TabIndex = 0;
            this.btnTextView.Text = "TEXT VIEW";
            this.btnTextView.UseVisualStyleBackColor = true;
            this.btnTextView.Click += new System.EventHandler(this.btnTextView_Click);
            // 
            // btnGraphicView
            // 
            this.btnGraphicView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphicView.Location = new System.Drawing.Point(30, 112);
            this.btnGraphicView.Name = "btnGraphicView";
            this.btnGraphicView.Size = new System.Drawing.Size(220, 60);
            this.btnGraphicView.TabIndex = 1;
            this.btnGraphicView.Text = "GRAPHIC VIEW";
            this.btnGraphicView.UseVisualStyleBackColor = true;
            this.btnGraphicView.Click += new System.EventHandler(this.btnGraphicView_Click);
            // 
            // btnReadView
            // 
            this.btnReadView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadView.Location = new System.Drawing.Point(30, 189);
            this.btnReadView.Name = "btnReadView";
            this.btnReadView.Size = new System.Drawing.Size(220, 60);
            this.btnReadView.TabIndex = 2;
            this.btnReadView.Text = "READ ONLY VIEW";
            this.btnReadView.UseVisualStyleBackColor = true;
            this.btnReadView.Click += new System.EventHandler(this.btnReadView_Click);
            // 
            // ShoppingOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReadView);
            this.Controls.Add(this.btnGraphicView);
            this.Controls.Add(this.btnTextView);
            this.Name = "ShoppingOrganizer";
            this.Text = "Shopping Organizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTextView;
        private System.Windows.Forms.Button btnGraphicView;
        private System.Windows.Forms.Button btnReadView;
    }
}

