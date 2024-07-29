namespace OnlineBookParser
{
    partial class BookInfoFinder
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
            findBkBtn = new Button();
            bkTtl = new TextBox();
            titleLbl = new Label();
            authorLbl = new Label();
            isbn13Lbl = new Label();
            publishedLbl = new Label();
            titleTag = new Label();
            authorTag = new Label();
            isbn13Tag = new Label();
            publishedTag = new Label();
            headerTag = new Label();
            SuspendLayout();
            // 
            // findBkBtn
            // 
            findBkBtn.Location = new Point(313, 173);
            findBkBtn.Name = "findBkBtn";
            findBkBtn.Size = new Size(119, 45);
            findBkBtn.TabIndex = 0;
            findBkBtn.Text = "Find Book";
            findBkBtn.UseVisualStyleBackColor = true;
            findBkBtn.Click += findBkBtn_Click;
            // 
            // bkTtl
            // 
            bkTtl.Location = new Point(162, 128);
            bkTtl.Name = "bkTtl";
            bkTtl.Size = new Size(471, 27);
            bkTtl.TabIndex = 1;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(273, 247);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(0, 20);
            titleLbl.TabIndex = 2;
            // 
            // authorLbl
            // 
            authorLbl.AutoSize = true;
            authorLbl.Location = new Point(273, 279);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(0, 20);
            authorLbl.TabIndex = 3;
            // 
            // isbn13Lbl
            // 
            isbn13Lbl.AutoSize = true;
            isbn13Lbl.Location = new Point(273, 308);
            isbn13Lbl.Name = "isbn13Lbl";
            isbn13Lbl.Size = new Size(0, 20);
            isbn13Lbl.TabIndex = 4;
            // 
            // publishedLbl
            // 
            publishedLbl.AutoSize = true;
            publishedLbl.Location = new Point(273, 337);
            publishedLbl.Name = "publishedLbl";
            publishedLbl.Size = new Size(0, 20);
            publishedLbl.TabIndex = 5;
            // 
            // titleTag
            // 
            titleTag.AutoSize = true;
            titleTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            titleTag.Location = new Point(226, 247);
            titleTag.Name = "titleTag";
            titleTag.Size = new Size(44, 20);
            titleTag.TabIndex = 6;
            titleTag.Text = "Title:";
            // 
            // authorTag
            // 
            authorTag.AutoSize = true;
            authorTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authorTag.Location = new Point(210, 279);
            authorTag.Name = "authorTag";
            authorTag.Size = new Size(64, 20);
            authorTag.TabIndex = 7;
            authorTag.Text = "Author:";
            // 
            // isbn13Tag
            // 
            isbn13Tag.AutoSize = true;
            isbn13Tag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            isbn13Tag.Location = new Point(207, 308);
            isbn13Tag.Name = "isbn13Tag";
            isbn13Tag.Size = new Size(66, 20);
            isbn13Tag.TabIndex = 8;
            isbn13Tag.Text = "ISBN13:";
            // 
            // publishedTag
            // 
            publishedTag.AutoSize = true;
            publishedTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            publishedTag.Location = new Point(191, 337);
            publishedTag.Name = "publishedTag";
            publishedTag.Size = new Size(81, 20);
            publishedTag.TabIndex = 10;
            publishedTag.Text = "Published:";
            // 
            // headerTag
            // 
            headerTag.AutoSize = true;
            headerTag.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            headerTag.Location = new Point(249, 65);
            headerTag.Name = "headerTag";
            headerTag.Size = new Size(254, 31);
            headerTag.TabIndex = 11;
            headerTag.Text = "Enter the Full Book Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(headerTag);
            Controls.Add(publishedTag);
            Controls.Add(isbn13Tag);
            Controls.Add(authorTag);
            Controls.Add(titleTag);
            Controls.Add(publishedLbl);
            Controls.Add(isbn13Lbl);
            Controls.Add(authorLbl);
            Controls.Add(bkTtl);
            Controls.Add(titleLbl);
            Controls.Add(findBkBtn);
            Name = "BookInfoFinder";
            Text = "Book Information Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button findBkBtn;
        private TextBox bkTtl;
        private Label titleLbl;
        private Label authorLbl;
        private Label isbn13Lbl;
        private Label publishedLbl;
        private Label titleTag;
        private Label authorTag;
        private Label isbn13Tag;
        private Label publishedTag;
        private Label headerTag;
    }
}
