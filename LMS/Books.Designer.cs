
namespace LMS
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.Addbooks = new System.Windows.Forms.Button();
            this.deletebooks = new System.Windows.Forms.Button();
            this.publishers = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbooks
            // 
            this.Addbooks.BackColor = System.Drawing.Color.Fuchsia;
            this.Addbooks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbooks.Location = new System.Drawing.Point(375, 23);
            this.Addbooks.Name = "Addbooks";
            this.Addbooks.Size = new System.Drawing.Size(139, 48);
            this.Addbooks.TabIndex = 0;
            this.Addbooks.Text = "Add Books";
            this.Addbooks.UseVisualStyleBackColor = false;
            this.Addbooks.Click += new System.EventHandler(this.Addbooks_Click);
            // 
            // deletebooks
            // 
            this.deletebooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deletebooks.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebooks.Location = new System.Drawing.Point(375, 96);
            this.deletebooks.Name = "deletebooks";
            this.deletebooks.Size = new System.Drawing.Size(139, 48);
            this.deletebooks.TabIndex = 1;
            this.deletebooks.Text = "Delete Books";
            this.deletebooks.UseVisualStyleBackColor = false;
            this.deletebooks.Click += new System.EventHandler(this.deletebooks_Click);
            // 
            // publishers
            // 
            this.publishers.BackColor = System.Drawing.Color.Yellow;
            this.publishers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishers.Location = new System.Drawing.Point(375, 170);
            this.publishers.Name = "publishers";
            this.publishers.Size = new System.Drawing.Size(139, 48);
            this.publishers.TabIndex = 2;
            this.publishers.Text = "Add Publishers";
            this.publishers.UseVisualStyleBackColor = false;
            this.publishers.Click += new System.EventHandler(this.publishers_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gray;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(375, 249);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 48);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 329);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.publishers);
            this.Controls.Add(this.deletebooks);
            this.Controls.Add(this.Addbooks);
            this.Name = "Books";
            this.Text = "Books";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Addbooks;
        private System.Windows.Forms.Button deletebooks;
        private System.Windows.Forms.Button publishers;
        private System.Windows.Forms.Button Exit;
    }
}