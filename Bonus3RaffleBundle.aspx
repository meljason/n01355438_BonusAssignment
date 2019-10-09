<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus3RaffleBundle.aspx.cs" Inherits="BonusAssignement_n01355438.Bonus3RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
                <h1>Ticket Machine</h1>

                <label>Please input the number of tickets you wish to buy: </label>
                <asp:TextBox runat="server" ID="ticketNumber" TextMode="Number" />    
                <asp:RequiredFieldValidator ErrorMessage="Please input a valid integer value" ControlToValidate="ticketNumber" runat="server" />
            </section>

            <section>
                <asp:ValidationSummary runat="server" ShowSummary="true" />
            </section>

            <section>
                <div id="ticket_summary" runat="server"></div>
            </section>

            <section>
                <asp:Button Text="Submit" runat="server" />
            </section>

        </div>
    </form>
</body>
</html>
