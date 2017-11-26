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
        public List<InterviewQuestion> DashbaordQuestions()
        {
            try
            {
                List<InterviewQuestion> questions = InterviewSectionDal.GetDashbaordQuestions();
                return questions;

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
                InterviewQuestion objQuestion = InterviewSectionDal.GetQuestionById(questionId);
                return objQuestion;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
