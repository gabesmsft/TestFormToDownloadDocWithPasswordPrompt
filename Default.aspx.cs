using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

namespace Part2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DownloadFile()
        {
            string filename = "Part2.docx";
            string path = @"d:\home\site\other\" + filename;
            Response.AppendHeader("content-disposition", "attachment; filename=" + filename);
            Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            Response.WriteFile(path);
            Response.End();
        }

        protected void LogonBtn_Click(object sender, EventArgs e) // ur link button 
        {
            string password = ConfigurationManager.AppSettings["Password"];
            if (UserTxt.Text == "devtest" && PasswordTxt.Text == password)
            {
                DownloadFile();
            }
            else
                MessageLabel.Text = "Login Failed";
        }
    }
}