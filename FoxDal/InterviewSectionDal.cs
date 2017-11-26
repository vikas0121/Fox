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
                        CommandText = "[BMS].[Get_CategoryMaster]"
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
                        if (!string.IsNullOrEmpty(Convert.ToString(item["Description"])))
                            objCategory.CategoryDesc = Convert.ToString(item["Description"]);
                        if (!string.IsNullOrEmpty(Convert.ToString(item["CategoryCount"])))
                            objCategory.CategoryCount = Convert.ToInt32(item["CategoryCount"]);

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

    }
}
