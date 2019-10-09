using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignement_n01355438
{
    public partial class Bonus1Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {

                    int x_Axis = Convert.ToInt32(xAxis.Text);
                    int y_Axis = Convert.ToInt32(yAxis.Text);

                    if (x_Axis > 0 && y_Axis > 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator is on quadrant 1";
                    } else if (x_Axis > 0 && y_Axis < 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator is on quadrant 4";
                    } else if (x_Axis < 0 && y_Axis > 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator is on quadrant 2";
                    } else if (x_Axis < 0 && y_Axis < 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator is on quadrant 3";
                    } else if (x_Axis < 0 && y_Axis == 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator lies on negative X axis";
                    }
                    else if (x_Axis > 0 && y_Axis == 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator lies on positive X axis";
                    }
                    else if (x_Axis == 0 && y_Axis < 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator lies on negative Y axis";
                    }
                    else if (x_Axis == 0 && y_Axis > 0)
                    {
                        coordinator_summary.InnerHtml = "Your coordinator lies on positive Y axis";
                    }
                    else
                    {
                        coordinator_summary.InnerHtml = "Your coordinator is not on any quadrant";
                    }
                }
            }

        }
    }
}