using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateStudentsCampaign
{
    public class Student: EventArgs
    {
        private readonly Guid _id;
        private readonly double _myMark;
        public string Name { get; private set; }
        public bool IsAccepted { get; private set; }

        public Student(string name,double mark)
        {
            Name = name;
            _id = Guid.NewGuid();
            _myMark = mark;

        }
        public void SubscribeTo(University university)
        {
            university.ChangedMinMark += ChangeStatus;
        }

        public void ChangeStatus(object uni, EventArgs e)
        {
            University university = (University)uni;
            _ = (university.MinMark <= _myMark) ? IsAccepted = true : IsAccepted = false;
        }
    }
}
