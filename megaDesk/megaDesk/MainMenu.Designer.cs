namespace megaDesk
{
    partial class MainMenu
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
            this.exit = new System.Windows.Forms.Button();
            this.addquote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(129, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // addquote
            // 
            this.addquote.Location = new System.Drawing.Point(78, 12);
            this.addquote.Name = "addquote";
            this.addquote.Size = new System.Drawing.Size(176, 58);
            this.addquote.TabIndex = 1;
            this.addquote.Text = "Add Quote";
            this.addquote.UseVisualStyleBackColor = true;
            this.addquote.Click += new System.EventHandler(this.addquote_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.Location = new System.Drawing.Point(78, 138);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(176, 58);
            this.viewQuote.TabIndex = 2;
            this.viewQuote.Text = "View Quote";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.Location = new System.Drawing.Point(78, 258);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(176, 58);
            this.searchQuote.TabIndex = 3;
            this.searchQuote.Text = "Search Quote";
            this.searchQuote.UseVisualStyleBackColor = true;
            this.searchQuote.Click += new System.EventHandler(this.searchQuote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.addquote);
            this.Controls.Add(this.exit);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addquote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuote;
    }
}

