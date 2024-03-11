namespace XX_UsingObjects
{
    internal static class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 2500; i++)
            {
                Student s = new Student();

                for(int j = 0; j < 100; j++)
                {
                    s.grades.Add(new Random().NextDouble() * 100);
                }

                students.Add(s);
            }

            Console.WriteLine();
        }
    }
}