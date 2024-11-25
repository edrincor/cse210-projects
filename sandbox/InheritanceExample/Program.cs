class Program
{
    public static void Main(string[] args)
    {
        Person bob = new Person("Bob", "Billy", 37);
        Doctor doctorBob = new Doctor("Bob", "Budge", 65, "Hack Saw");
        Police policeDoug = new Police("Doug", "Denver", 40, "Taser");

        Console.WriteLine(bob.GetPersonInfo());
        Console.WriteLine(doctorBob.GetDoctorInfo());
        Console.WriteLine(policeDoug.GetPoliceInfo());
    }
}
