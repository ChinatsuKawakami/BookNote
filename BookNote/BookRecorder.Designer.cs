namespace BookNote
{
    partial class BookRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRecorder));
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookTitleTxt = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(35, 53);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(61, 13);
            this.bookTitle.TabIndex = 0;
            this.bookTitle.Text = "Book Title :";
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.Location = new System.Drawing.Point(115, 50);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(149, 20);
            this.bookTitleTxt.TabIndex = 1;
            this.bookTitleTxt.TextChanged += new System.EventHandler(this.BookTitleTxt_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(38, 105);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date :";
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(115, 105);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(149, 20);
            this.dateTxt.TabIndex = 3;
            this.dateTxt.Click += new System.EventHandler(this.Show_Calender);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(350, 50);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(50, 13);
            this.summaryLabel.TabIndex = 4;
            this.summaryLabel.Text = "Summary";
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(353, 77);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(185, 131);
            this.summaryTxt.TabIndex = 5;
            this.summaryTxt.TextChanged += new System.EventHandler(this.SummaryTxt_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(353, 236);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(463, 236);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(82, 153);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 8;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RATE :";
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star1.Location = new System.Drawing.Point(398, 280);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(32, 31);
            this.star1.TabIndex = 10;
            this.star1.Text = "☆";
            this.star1.Click += new System.EventHandler(this.Star1_Click);
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star2.Location = new System.Drawing.Point(436, 280);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(32, 31);
            this.star2.TabIndex = 11;
            this.star2.Text = "☆";
            this.star2.Click += new System.EventHandler(this.Star2_Click);
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star3.Location = new System.Drawing.Point(474, 280);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(32, 31);
            this.star3.TabIndex = 12;
            this.star3.Text = "☆";
            this.star3.Click += new System.EventHandler(this.Star3_Click);
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star4.Location = new System.Drawing.Point(512, 280);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(32, 31);
            this.star4.TabIndex = 13;
            this.star4.Text = "☆";
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star5.Location = new System.Drawing.Point(550, 280);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(32, 31);
            this.star5.TabIndex = 14;
            this.star5.Text = "☆";
            this.star5.Click += new System.EventHandler(this.Star5_Click);
            // 
            // BookRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(677, 359);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.summaryTxt);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.bookTitleTxt);
            this.Controls.Add(this.bookTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookRecorder";
            this.Opacity = 0.9D;
            this.Text = "BookRecorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.TextBox bookTitleTxt;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star5;
    }
}

