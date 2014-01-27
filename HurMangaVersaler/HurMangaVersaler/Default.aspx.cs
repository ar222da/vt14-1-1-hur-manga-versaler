using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HurMangaVersaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (TextBox.Enabled)
            {
                TextBox.Enabled = false;
                string inputText = TextBox.Text;
                int capitalLetters = Model.TextAnalyser.GetNumberOfCapitals(inputText);
                Result.Text = capitalLetters.ToString();
                OutputPlaceHolder.Visible = true;
                Button.Text = "Rensa";
            }
            else
            {
                TextBox.Text = "";
                TextBox.Enabled = true;
                OutputPlaceHolder.Visible = false;
                Button.Text = "Beräkna antalet versaler";
            }
        }
    }
}