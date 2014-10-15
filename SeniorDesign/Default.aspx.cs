using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeniorDesign
{
     public partial class _Default : Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {

              
          }

          protected void Calendar1_SelectionChanged(object sender, EventArgs e)
          {
               //string x = Calendar1.SelectedDate.ToLongDateString();
              //Label1.Text = Calendar1.SelectedDate.ToLongDateString();
               //Console.Out.WriteLine( x);

          }

          protected void NumOfDays_TextChanged(object sender, EventArgs e)
          {
               string x = shiftsPerDay.Text.ToString();
               //Label2.Text = shiftsPerDay.Text;
               Label2.Text = x;
          }
          
     }
}