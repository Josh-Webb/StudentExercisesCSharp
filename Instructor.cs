namespace StudentExercises {

    class Instructor
    {
        public string FirstName { get; set; }

        public string LastName {  get; set; }

        public string Slack { get; set; }

        public Cohort Cohort { get; set; }

        public string Speciality { get; set; }

        public void Assign( Exercise exercise, Student student)
        {
           student.Exercises.Add(exercise);         
        } 
    }
}