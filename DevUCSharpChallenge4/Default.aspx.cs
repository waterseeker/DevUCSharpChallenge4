using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpChallenge4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = Calendar1.SelectedDate;
            DateTime secondDate = Calendar2.SelectedDate;
            TimeSpan mySpan = new TimeSpan();

            if (firstDate > secondDate)
            {
                mySpan = (firstDate - secondDate);
            }
            else
            {
                mySpan = (secondDate - firstDate);
            }

            resultLabel.Text = "There are " + mySpan + " days between those two dates.";
        }
    }
}