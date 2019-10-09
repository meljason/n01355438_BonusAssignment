using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignement_n01355438
{
    public partial class Bonus2WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {

                    //empty inner html in order to reset the summary when pressing submit again
                    weekly_summary.InnerHtml = "";

                    //creating list to store the days of the week
                    List<String> weekDays = new List<string>();
                    weekDays.Add("Monday");
                    weekDays.Add("Tuesday");
                    weekDays.Add("Wednesday");
                    weekDays.Add("Thursday");
                    weekDays.Add("Friday");
                    weekDays.Add("Saturday");
                    weekDays.Add("Sunday");

                    //list to store the selected days of the week from the days' checkbox
                    List<String> daysSelected = new List<String>();


                    //for list to add the values selected from the checkbox and store them to the list daysSelected
                    foreach (ListItem i in days_in_the_week.Items)
                    {
                        if (i.Selected)
                        {
                            daysSelected.Add(i.Value);
                        }
                    }

                    //TESTING
                    //String daysSelectedString = String.Join(" ; ", daysSelected.ToArray());

                    //weekly_summary.InnerHtml = String.Concat(daysSelectedString);

                    //display the summary of the calendar week
                    //-------------------------------------------------------------------------

                    //for-loop to loop through the days of the month
                    for (int index = 1; index <= 31; index++)
                    {
                        int day = (index - 1) % 7;

                        //declaration to get the index of the days in the list
                        int indexOfMonday = weekDays.IndexOf("Monday");
                        int indexOfTuesday = weekDays.IndexOf("Tuesday");
                        int indexOfWednesday = weekDays.IndexOf("Wednesday");
                        int indexOfThursday = weekDays.IndexOf("Thursday");
                        int indexOfFriday = weekDays.IndexOf("Friday");
                        int indexOfSaturday = weekDays.IndexOf("Saturday");
                        int indexOfSunday = weekDays.IndexOf("Sunday");

                        String havingFun = "Time to have fun!";
                        String haveToWork = "Time to work...";


                        if (day == indexOfMonday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[1] + "! ";
                        }
                        else if (day == indexOfTuesday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[2] + "! ";
                        }
                        else if (day == indexOfWednesday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[3] + "! ";
                        }
                        else if (day == indexOfThursday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[4] + "! ";
                        }
                        else if (day == indexOfFriday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[5] + "! ";
                        }
                        else if (day == indexOfSaturday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[6] + "! ";
                        }
                        else if (day == indexOfSunday)
                        {
                            weekly_summary.InnerHtml += "Oct " + index + " is a " + weekDays[0] + "! ";
                        }

                        if (daysSelected.Contains(weekDays[index % 7]))
                        {
                            weekly_summary.InnerHtml += haveToWork + "</br>";
                        }
                        else
                        {
                            weekly_summary.InnerHtml += havingFun + "</br>";
                        }
                    }
                }
            }
        }
    }
}