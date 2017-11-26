using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FoxDal;
using PropertyLayer;

namespace FoxService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InterviewSection" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InterviewSection.svc or InterviewSection.svc.cs at the Solution Explorer and start debugging.
    public class InterviewSection : IInterviewSection
    {
        public List<Category> DashbaordData()
        {
            try
            {
                var objSectionDal = new InterviewSectionDal();
                List<Category> dashboardData = objSectionDal.GetDashbaordData();
                return dashboardData;

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
                var objSectionDal = new InterviewSectionDal();
                InterviewQuestion objQuestion = objSectionDal.GetQuestionById(questionId);
                return objQuestion;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
