using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignement_n01355438
{
    public partial class Bonus3RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    int userTicketInput = Convert.ToInt32(ticketNumber.Text);
                    double ticketPrice = 0.25;
                    double totalTicketPrice = ticketPrice * userTicketInput;

                    ticket_summary.InnerHtml = "";


                    if (userTicketInput <= 50)
                    {
                        for (int i = 1; i <= userTicketInput; i++)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 1! That's ticket " + i + "</br>";
                        }
                    }
                    else if (userTicketInput >= 51 && userTicketInput <= 150)
                    {
                        for (int i = 2; i <= userTicketInput; i = i + 2)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 2! That's ticket " + i + "</br>";
                        }
                        //ticket_summary.InnerHtml += i + "</br>";
                        //ticket_summary.InnerHtml += userTicketInput + "</br>";
                        //ticket_summary.InnerHtml += i - userTicketInput + "</br>";
                        ticket_summary.InnerHtml += "Your leftover ticket(s) is " + (userTicketInput % 2) + ". That's " + userTicketInput +  " ticket(s)" + "</br>";
                    }
                    else if (userTicketInput >= 151 && userTicketInput <= 300)
                    {         
                        for (int i = 3; i <= userTicketInput; i = i + 3)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 3! That's ticket " + i + "</br>";
                        }
                        //ticket_summary.InnerHtml += i + "</br>";
                        //ticket_summary.InnerHtml += userTicketInput + "</br>";
                        //ticket_summary.InnerHtml += i - userTicketInput + "</br>";
                        ticket_summary.InnerHtml += "Your leftover ticket(s) is " + (userTicketInput % 3) + ". That's " + userTicketInput + " ticket(s)" + "</br>";
                    }
                    else
                    {
                        //ticket_summary.InnerHtml += "TEST";
                        for (int i = 5; i <= userTicketInput; i = i + 5)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 5! That's ticket " + i + "</br>";
                        }
                        //ticket_summary.InnerHtml += i + "</br>";
                        //ticket_summary.InnerHtml += userTicketInput + "</br>";
                        //ticket_summary.InnerHtml += i - userTicketInput + "</br>";
                        ticket_summary.InnerHtml += "Your leftover ticket(s) is " + (userTicketInput % 5) + ". That's " + userTicketInput + " ticket(s)" + "</br>";
                    }

                    ticket_summary.InnerHtml += "Your total ticket(s) is " + userTicketInput + " and your cost is $" + totalTicketPrice;


                }
            }
        }
    }
}