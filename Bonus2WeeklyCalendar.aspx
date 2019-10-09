<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus2WeeklyCalendar.aspx.cs" Inherits="BonusAssignement_n01355438.Bonus2WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
                <h1>This is your weekly schedule!</h1>

                <label>Select your school days of the week</label>
                <asp:CheckBoxList runat="server" ID="days_in_the_week">
                    <asp:ListItem Text="Monday" Value="Monday"/>
                    <asp:ListItem Text="Tuesday" Value="Tuesday"/>
                    <asp:ListItem Text="Wednesday" Value="Wednesday"/>
                    <asp:ListItem Text="Thursday" Value="Thursday"/>
                    <asp:ListItem Text="Friday" Value="Friday"/>
                    <asp:ListItem Text="Saturday" Value="Saturday"/>
                    <asp:ListItem Text="Sunday" Value="Sunday"/>
                </asp:CheckBoxList>
            </section>

            <section>
                <asp:Button Text="Submit" runat="server" />
            </section>

            <section>
                <div id="weekly_summary" runat="server"></div>
            </section>
        </div>
    </form>
</body>
</html>
