using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PropertyLayer;

namespace FoxDal
{
    public class InterviewSectionDal
    {
        DataSet _ds;
        DataTable _dt;
        SqlDataAdapter _adp;
        SqlConnection con;
        SqlCommand cmd;

        public List<InterviewQuestion> GetDashbaordQuestions()
        {
            try
            {
                List<InterviewQuestion> objListQuestions = new List<InterviewQuestion>();

                return objListQuestions;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public InterviewQuestion GetQuestionById(int questionId)
        {
            try
            {
                InterviewQuestion objInterviewQuestion = new InterviewQuestion();
                return objInterviewQuestion;
            }
            catch (Exception)
            {              
                throw;
            }
        }

        public List<Category> GetDashbaordData()
        {
            try
            {
                var objCategories = new List<Category>();
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.AppSettings["sqlConnection"];
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "[dbo].[Get_CategoryMaster]"
                    };
                    connection.Open();
                    _adp = new SqlDataAdapter(sqlCommand);
                    _dt = new DataTable();
                    _adp.Fill(_dt);
                }
                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow item in _dt.Rows)
                    {
                        Category objCategory = new Category();
                        if (!string.IsNullOrEmpty(Convert.ToString(item["CategoryId"])))
                            objCategory.CategoryId = Convert.ToInt32(item["CategoryId"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["CategoryName"])))
                            objCategory.CategoryName = Convert.ToString(item["CategoryName"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Description"])))
                            objCategory.CategoryDesc = Convert.ToString(item["Description"]);

                        objCategories.Add(objCategory);
                    }
                }
                return objCategories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InterviewQuestion> InterviewQuestionsById(string id)
        {
            try
            {
                var objInterviewQuestions = new List<InterviewQuestion>();
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.AppSettings["sqlConnection"];
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "[DBO].[Get_InterviewQuestionsById]"
                    };
                    connection.Open();
                    _adp = new SqlDataAdapter(sqlCommand);
                    _dt = new DataTable();
                    _adp.Fill(_dt);
                }
                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow item in _dt.Rows)
                    {
                        InterviewQuestion objInterviewQuestion = new InterviewQuestion();
                        if (!string.IsNullOrEmpty(Convert.ToString(item["CategoryId"])))
                            objInterviewQuestion.CategoryId = Convert.ToInt32(item["CategoryId"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Heading"])))
                            objInterviewQuestion.Heading = Convert.ToString(item["Heading"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Question"])))
                            objInterviewQuestion.Question = Convert.ToString(item["Question"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Answer"])))
                            objInterviewQuestion.Answer = Convert.ToString(item["Answer"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Score"])))
                            objInterviewQuestion.Score = Convert.ToInt32(item["Score"]);

                        objInterviewQuestions.Add(objInterviewQuestion);
                    }
                }
                return objInterviewQuestions;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
