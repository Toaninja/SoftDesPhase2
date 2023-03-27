namespace SoftDesPhase2
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
            this.homeButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.fpButton = new System.Windows.Forms.Button();
            this.swuButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeButton.Location = new System.Drawing.Point(54, 28);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.Location = new System.Drawing.Point(147, 28);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // fpButton
            // 
            this.fpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fpButton.Location = new System.Drawing.Point(240, 28);
            this.fpButton.Name = "fpButton";
            this.fpButton.Size = new System.Drawing.Size(98, 23);
            this.fpButton.TabIndex = 2;
            this.fpButton.Text = "Fresh Produce";
            this.fpButton.UseVisualStyleBackColor = true;
            // 
            // swuButton
            // 
            this.swuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.swuButton.Location = new System.Drawing.Point(355, 28);
            this.swuButton.Name = "swuButton";
            this.swuButton.Size = new System.Drawing.Size(81, 23);
            this.swuButton.TabIndex = 3;
            this.swuButton.Text = "Sell With Us";
            this.swuButton.UseVisualStyleBackColor = true;
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartButton.ForeColor = System.Drawing.Color.Black;
            this.cartButton.Location = new System.Drawing.Point(821, 19);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 41);
            this.cartButton.TabIndex = 4;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(920, 28);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(68, 23);
            this.searchTextbox.TabIndex = 5;
            this.searchTextbox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(994, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1090, 559);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.swuButton);
            this.Controls.Add(this.fpButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.homeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button homeButton;
        private Button browseButton;
        private Button fpButton;
        private Button swuButton;
        private Button cartButton;
        private TextBox searchTextbox;
        private Button searchButton;
    }
}