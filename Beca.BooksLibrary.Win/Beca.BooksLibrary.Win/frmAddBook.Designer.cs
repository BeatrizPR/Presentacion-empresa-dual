namespace Beca.BooksLibrary.Win
{
    partial class frmAddBook
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(139, 174);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(27, 25);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(30, 13);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Tittle";
            // 
            // txtTittle
            // 
            this.txtTittle.Location = new System.Drawing.Point(103, 22);
            this.txtTittle.MaxLength = 500;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(349, 20);
            this.txtTittle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(103, 64);
            this.txtAuthor.MaxLength = 500;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(349, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(103, 101);
            this.txtPages.MaxLength = 9999;
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 4;
            this.txtPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPages_KeyPress);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(27, 67);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(27, 104);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "Pages";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnCancel;
    }
}