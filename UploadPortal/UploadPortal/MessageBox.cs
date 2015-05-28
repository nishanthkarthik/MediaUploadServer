using System;
using System.Web.UI;

namespace UploadPortal
{
    public static class MessageBox
    {
        public static void Show(this Page page, String message)
        {
            page.ClientScript.RegisterStartupScript(
               page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + message + "');</script>"
            );
        }
    }
}