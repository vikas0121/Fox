using System;
using System.Collections.Generic;
using PropertyLayer;

namespace FoxDal
{
    public class InterviewSectionDal
    {
        public static List<InterviewQuestion> GetDashbaordQuestions()
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

        public static InterviewQuestion GetQuestionById(int questionId)
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
    }
}
