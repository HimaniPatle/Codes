using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TuturailAspDemo.DataConnection
{
        public class TutorialDBConnection
        {
            string sqlConnectionStr = "Data Source=DESKTOP-BP2GNRV;Initial Catalog=BasicDemo;Integrated Security=True";
            public string InsertTutorial(TutorialModel tutorialModelObj)
            {
                SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
                SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values(" + tutorialModelObj.TutorialId + ",'" + tutorialModelObj.TutorialName + "','" + tutorialModelObj.TutorialDesc + "'," + tutorialModelObj.Published + ")", sqlConnectionObj);
                sqlConnectionObj.Open();
                sqlCommandObj.ExecuteNonQuery();
                sqlConnectionObj.Close();
                return "Tutorial details saved successfully";
            }
            public void UpdateTutorial(TutorialModel tutorialModelObj)
            {

            }
            public void DeleteTutorialById(int tutorialId)
            {

            }
            public DataTable SelectTutorial()
            {
                SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
                SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial", sqlConnectionObj);
                sqlConnectionObj.Open();
                SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                sqlConnectionObj.Close();
                return dt;
            }
            public void EditTutorialById(int tutorialId)
            {

            }
        }
 }