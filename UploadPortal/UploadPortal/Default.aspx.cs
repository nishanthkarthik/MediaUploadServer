using System;
using System.IO;
using System.Web;
using System.Web.UI;

namespace UploadPortal
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_OnClick(object sender, EventArgs e)
        {
            if (UploadBox.HasFiles)
            {
                foreach (HttpPostedFile file in UploadBox.PostedFiles)
                {
                    string servername = Environment.MachineName;

                    string resultpath = Path.Combine(servername, @"E:\", "IIS_Downloads", Path.GetFileName(file.FileName));
                    file.SaveAs(resultpath);
                }
                this.Show(UploadBox.PostedFiles.Count + " file(s) uploaded successfully");
            }
            else
            {
                this.Show("You have selected no files");
            }
        }
    }
}