using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;

namespace nlog_elmah_target.Tests.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogManager.GetCurrentClassLogger().Debug("Hallo Welt");
            LogManager.GetCurrentClassLogger().DebugException("Hallo Exception", new Exception("Test"));

        }
    }
}