using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ektron.Cms;
using Ektron.Cms.API;
using Ektron.Cms.Widget;
using Ektron.Cms.Common;

public partial class widgets_AnimationFrame : System.Web.UI.UserControl, IWidget
{
    private IWidgetHost _host;
    private string _url;

    [WidgetDataMember("")]
    public string URL
    {
        get { return _url; }
        set { _url = value; }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        _host = Ektron.Cms.Widget.WidgetHost.GetHost(this);
        _host.Title = "Animation Frame";
        _host.Edit += new EditDelegate(EditButtonClicked);
        ViewSet.SetActiveView(View);
    }

    protected void EditButtonClicked(string settings)
    {
        URLtextBox.Text = URL;
        ViewSet.SetActiveView(Edit);
    }

    protected void CancelButton_Click(object sender, EventArgs e)
    {
        ViewSet.SetActiveView(View);
    }

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        URL = URLtextBox.Text;
        _host.SaveWidgetDataMembers();
        ViewSet.SetActiveView(View);
    }
}