<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AnimationFrame.ascx.cs" Inherits="widgets_AnimationFrame" %>
<asp:MultiView ID="ViewSet" runat="server">
    <asp:View ID="View" runat="server">
        <div class="animationWrapper">
            <iframe src="<%= URL %>"/>
        </div>
    </asp:View>
    <asp:View ID="Edit" runat="server">
        <table>
            <tr>
                <td>Animation URL:</td>
                <td>
                    <asp:TextBox ID="URLtextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click"/>
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click"/>
    </asp:View>
</asp:MultiView>