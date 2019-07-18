namespace StudentExercises 
{

    class Instructor : NSSPerson
    {
        public string Speciality { get; set; }

        public void Assign( Exercise exercise, Student student)
        {
           student.Exercises.Add(exercise);         
        } 
    }
}