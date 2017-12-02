using System;

namespace PropertyLayer
{
    public class InterviewQuestion: Category
    {
        public int QuestionId { get; set; }
        public string Heading { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CreatedBy { get; set; }
        public int Language { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte IsActive { get; set; }
        public string Tag { get; set; }
        public int Score { get; set; }
    }
}
