using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateStudentsCampaign
{
    public class University
    {
        private readonly string _name;
        public double MinMark { get; private set; }

        public University(string name,double bal)
        {
            _name = name;
            MinMark = bal;
        }

        public void NextClassification(double NewMinMark)
        {
            MinMark = NewMinMark;
            Console.WriteLine($"The minimal mark for {_name} has dropped");
            ChangedMinMark?.Invoke(this,EventArgs.Empty);
        }

        public event EventHandler ChangedMinMark;

       
    }
}
