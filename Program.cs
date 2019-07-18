using System;
using System.Collections.Generic;
using System.Linq;

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

            var oPlank = new Student(){
                FirstName = "Olivia",
                LastName = "Plank",
                Slack = "Soft Boi",
                Cohort = cohort33
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

             List<Student> students = new List<Student>(){
                 eAshe,
                 kCard,
                 dSteponawich,
                 eClarke,
                 jWebb,
                 oPlank
             };

            List<Exercise> exercises = new List<Exercise>(){
                FizzBuzz, UrbanPlanner, Kennel, DailyJournal, StudentExercises
            };

            List<Instructor> instructors = new List<Instructor>(){
                bNilsen, aShaefer, rHecht
            };


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
            bNilsen.Assign(DailyJournal, jWebb);

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

            cohort32.Students.Add(jWebb);
            cohort32.Students.Add(eClarke);
            cohort33.Students.Add(kCard);
            cohort33.Students.Add(oPlank);
            cohort34.Students.Add(dSteponawich);
            cohort34.Students.Add(eAshe);

            
            List<Cohort> cohorts = new List<Cohort>(){
                cohort32, cohort33, cohort34
            };

           
            foreach (Student student in students)
            {   Console.WriteLine($"{student.FirstName} is working on");
                foreach(Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{exercise.Name}");
                }
            }

            Console.WriteLine($"Exercise 1 is {exercises[0].Name}");

            IEnumerable<Exercise> javascriptExercises = from exercise in exercises
                where exercise.Language == "Javascript"
                select exercise;
        
            foreach (Exercise e in javascriptExercises) {
            Console.WriteLine($"{e.Name} ${e.Language}");
        }

            IEnumerable<Student> cohort32List = from student in students
                where student.Cohort == cohort32
                select student;
            foreach(Student s in cohort32List){
                Console.WriteLine($"{s.FirstName} {s.LastName} is in Cohort 32.");
            }

            IEnumerable<Instructor> cohort32Instructors = from instructor in instructors
                where instructor.Cohort == cohort32
                select instructor;
            foreach(Instructor i in cohort32Instructors){
                Console.WriteLine($"{i.FirstName} {i.LastName} is an instructor for Cohort 32");
            }

            IEnumerable<Student> orderLastName = from student in students
                orderby student.LastName
                select student;
                foreach(Student s in orderLastName){
                Console.WriteLine($"{s.LastName}, {s.FirstName}");
            }

            IEnumerable<Student> noExercises = from student in students
                where student.Exercises.Count == 0
                select student;
                foreach(Student s in noExercises){
                    Console.WriteLine($"{s.FirstName} {s.LastName} doesn't have any exercises.");
                }

            var mostExercises = students.OrderByDescending(student => student.Exercises.Count()).Take(1);

            foreach (Student s in mostExercises)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName} has the most exercises.");
            }



           foreach (var cohort in cohorts)
           {
               Console.WriteLine($"{cohort.Name} has {cohort.Students.Count()} students.");
           }
             
                
   
              
            
            
            
            
        }
    }
}
