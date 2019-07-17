using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzz = new Exercise(){
                Name = "FizzBuzz",
                Language = "Javascript"
            };
            var UrbanPlanner = new Exercise(){
                Name = "UrbanPlanner",
                Language = "C#"
            };
            var Kennel = new Exercise(){
                Name = "Kennel",
                Language = "React"
            };
            var DailyJournal = new Exercise(){
                Name = "DailyJournal",
                Language = "Javascript"
            };
            var StudentExercises = new Exercise(){
                Name = "StudentExercises",
                Language = "C#"
            };

            var cohort32 = new Cohort(){
                Name = "Cohort 32"
            };

            var cohort33 = new Cohort(){
                Name = "Cohort 33"
            };

            var cohort34 = new Cohort(){
                Name = "Cohort34"
            };
            
            var jWebb = new Student(){
                FirstName = "Josh",
                LastName = "Webb",
                Slack = "Josh-Webb",
                Cohort = cohort32
            };

            var eClarke = new Student(){
                FirstName = "Eliot",
                LastName = "Clarke",
                Slack = "Eliot",
                Cohort = cohort32
            };

            var eAshe = new Student(){
                FirstName = "Ellie",
                LastName = "Ashe",
                Slack = "Ellie-Ashe",
                Cohort = cohort34
            };

            var kCard = new Student(){
                FirstName = "Keisha",
                LastName = "Card",
                Slack = "Keisha C",
                Cohort = cohort33
            };

            var dSteponawich = new Student(){
                FirstName = "Dejan",
                LastName = "Stepfonavich",
                Slack = "Dejan S",
                Cohort = cohort34
            };

            var bNilsen = new Instructor(){
                FirstName = "Bryan",
                LastName = "Wilson",
                Slack = "Bryan Nilsen",
                Cohort = cohort34,
                Speciality = "High Fives"
            };

            var rHecht = new Instructor(){
                FirstName = "Robbie",
                LastName = "Hecht",
                Slack = "Robbiehecht",
                Cohort = cohort32,
                Speciality = "Singer/Song-writer"
            };

            var aShaefer = new Instructor(){
                FirstName = "Addam",
                LastName = "Shaefer",
                Slack = "Addam Shaefer",
                Cohort = cohort33,
                Speciality = "Hats"
            };

             List<Student> students = new List<Student>();
            students.Add(jWebb);
            students.Add(eClarke);
            students.Add(eAshe);
            students.Add(kCard);
            students.Add(dSteponawich);

            List<Exercise> exercises = new List<Exercise>();
            
            exercises.Add(FizzBuzz);
            exercises.Add(UrbanPlanner);
            exercises.Add(DailyJournal);
            exercises.Add(StudentExercises);
            exercises.Add(Kennel);

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"{exercise.Name}");
            };

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName}");
            };

            bNilsen.Assign(FizzBuzz, eAshe);
            bNilsen.Assign(DailyJournal, eAshe);
            bNilsen.Assign(Kennel, kCard);
            bNilsen.Assign(UrbanPlanner, kCard);
            bNilsen.Assign(StudentExercises, dSteponawich);
            bNilsen.Assign(Kennel, dSteponawich);
            bNilsen.Assign(DailyJournal, eClarke);
            bNilsen.Assign(Kennel, eClarke);
            bNilsen.Assign(StudentExercises, jWebb);
            bNilsen.Assign(UrbanPlanner, jWebb);

            rHecht.Assign(Kennel, eAshe);
            rHecht.Assign(DailyJournal, eAshe);
            rHecht.Assign(FizzBuzz, kCard);
            rHecht.Assign(DailyJournal, kCard);
            rHecht.Assign(UrbanPlanner, dSteponawich);
            rHecht.Assign(FizzBuzz, dSteponawich);
            rHecht.Assign(StudentExercises, eClarke);
            rHecht.Assign(DailyJournal, eClarke);
            rHecht.Assign(Kennel, jWebb);
            rHecht.Assign(FizzBuzz, jWebb);

            aShaefer.Assign(UrbanPlanner, eAshe);
            aShaefer.Assign(StudentExercises, eAshe);
            aShaefer.Assign(StudentExercises, kCard);
            aShaefer.Assign(UrbanPlanner, kCard);
            aShaefer.Assign(StudentExercises, dSteponawich);
            aShaefer.Assign(Kennel, dSteponawich);
            aShaefer.Assign(DailyJournal, eClarke);
            aShaefer.Assign(Kennel, eClarke);
            aShaefer.Assign(StudentExercises, jWebb);
            aShaefer.Assign(UrbanPlanner, jWebb);

           
            foreach (Student student in students)
            {   Console.WriteLine($"{student.FirstName} is working on");
                foreach(Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{exercise.Name}");
                }
            }
            
            
            
            Console.WriteLine($"{jWebb.Cohort.Name}");
            
            // Student JoshWebb = new Student(){
            //     FirstName = "Josh",
            //     LastName = "Webb",
            //     Slack = "Josh Webb"
            // };
            // Console.WriteLine(JoshWebb.FirstName);
        }
    }
}
