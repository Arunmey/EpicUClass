using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string money = pocketMoneyTextBox.Text;

            resultLabel.Text = "At " + age + " years old, I would have expected you to have more than $" + money + " in your pocket.";


        }
    }
}