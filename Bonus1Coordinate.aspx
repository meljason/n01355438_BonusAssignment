<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus1Coordinate.aspx.cs" Inherits="BonusAssignement_n01355438.Bonus1Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
                <h1>Input you coordinates!</h1>
                <label>Input X axis</label>
                <asp:TextBox runat="server" ID="xAxis" TextMode="Number" />               
                <asp:RequiredFieldValidator ErrorMessage="Please input a valid integer value" ControlToValidate="xAxis" runat="server" />

                <label>Input Y axis</label>
                <asp:TextBox runat="server" ID="yAxis" TextMode="Number" />
                <asp:RequiredFieldValidator ErrorMessage="Please input a valid integer value" ControlToValidate="yAxis" runat="server" />
            </section>

            <section>
                <asp:ValidationSummary runat="server" ShowSummary="true" />
            </section>

            <section>
                <div id="coordinator_summary" runat="server"></div>
            </section>

            <section>
                <asp:Button Text="Submit" runat="server" />
            </section>
        </div>
    </form>
</body>
</html>
