using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonClassLibrary;


namespace USOform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        USOEntities uSOEntities;

        public WebForm1()
        {
            uSOEntities = new USOEntities();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // กลุ่ม
            Answer answer264 = new Answer()
            {
                AnsDes = this.groupTextbox11.Value,
                AnserTypeId = 1,
                CreateDate = DateTime.Now,
                QuestionId = 264,
                UserId = 1
            };
            uSOEntities.Answers.Add(answer264);

            int result = uSOEntities.SaveChanges();
            if (result > 0)
            {
                this.SuccessPanel.Visible = true;
            }
        }


    }
}

