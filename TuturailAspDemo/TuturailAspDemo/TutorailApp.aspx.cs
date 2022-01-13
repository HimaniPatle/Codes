using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TuturailAspDemo.DataConnection;
using System.Data;

namespace TuturailAspDemo
{
    public partial class TutorailApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButSave_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(TxtTutorialId.Text);
            tutorialModel.TutorialName = TxtTutorialName.Text;
            tutorialModel.TutorialDesc = TxtTutorialDesc.Text;
            tutorialModel.Published = Convert.ToInt32(TxtPublished.Text);
            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;

            //table display
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }
      
    }
}