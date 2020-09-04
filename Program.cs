using System;
using System.Collections.Generic;

namespace CandidateStudentsCampaign
{
    class Program
    {
        static void CheckIfAllAccepted(List<Student> students)
        {
            foreach (var student in students)
            {
                CheckIfAccepted(student);
            }
        }
        static void CheckIfAccepted(Student student) 
        {
            if (student.IsAccepted)
                Console.WriteLine($"{student.Name} is accepted!");
            else
                Console.WriteLine($"{student.Name} is  not accepted!");
        }

        static public List<Student> CandidatesAtFMI()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Maria", 32));
            students.Add(new Student("Martin", 33));
            students.Add(new Student("Anna", 31));
            return students;
        }

        static public void GetNotificationsFromUniversity(List<Student> students,University university)
        {
            foreach (var student in students)
            {
                student.SubscribeTo(university);
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = CandidatesAtFMI();
            University university = new University("FMI",32);
            GetNotificationsFromUniversity(students, university);
            CheckIfAllAccepted(students);
            university.NextClassification(30);
            CheckIfAllAccepted(students);
        }
    }
}
