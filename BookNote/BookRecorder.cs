using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookNote
{
    public partial class BookRecorder : Form
    {

        private string btitle = "";
        private string summary = "";
        private string rate = "";

        public BookRecorder()
        {
            InitializeComponent();
            monthCalendar.Visible = false;
            

        }

        
        private void Show_Calender(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
            
        }
       
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar.Visible = true;
            dateTxt.Text = this.monthCalendar.SelectionStart.ToString();

        }

        private void BookTitleTxt_TextChanged(object sender, EventArgs e)
        {
            btitle = this.bookTitleTxt.Text;
        }

        private void SummaryTxt_TextChanged(object sender, EventArgs e)
        {
            summary = this.summaryTxt.Text;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            summaryTxt.Clear();
            bookTitleTxt.Clear();
            dateTxt.Clear();
           
            DeleteAll();
        }
        private void DeleteAll()
        {
            summary = "";
            btitle = "";
            rate = "";
        }

        private void Star1_Click(object sender, EventArgs e)
        {
            rate = star1.Text = "★";
            star2.Text = "☆";
            star3.Text = "☆";
            star4.Text = "☆";
            star5.Text = "☆";
        }

        private void Star2_Click(object sender, EventArgs e)
        {
            star1.Text = "★";
            star2.Text = "★";
            star3.Text = "☆";
            star4.Text = "☆";
            star5.Text = "☆";

            rate = star1.Text + star2.Text;
        }

        private void Star3_Click(object sender, EventArgs e)
        {
            star1.Text = "★";
            star2.Text = "★";
            star3.Text = "★";
            star4.Text = "☆";
            star5.Text = "☆";

            rate = star1.Text + star2.Text + star3.Text;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Text = "★";
            star2.Text = "★";
            star3.Text = "★";
            star4.Text = "★";
            star5.Text = "☆";

            rate = star1.Text + star2.Text + star3.Text + star4.Text;
        }

        private void Star5_Click(object sender, EventArgs e)
        {
            star1.Text = "★";
            star2.Text = "★";
            star3.Text = "★";
            star4.Text = "★";
            star5.Text = "★";

            rate = star1.Text + star2.Text + star3.Text + star4.Text + star5.Text;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
