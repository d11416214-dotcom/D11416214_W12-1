namespace D11416214_W12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student s1 = new Student(60,70);
            Console.WriteLine(s1.Mid);
            Console.WriteLine(s1.Final);
            Console.WriteLine("------------------------");

            Student s2 = new Student(70, 80);
            Console.WriteLine(s2.Mid);
            Console.WriteLine(s2.Final);
            Console.WriteLine("------------------------");
            */
            //Console.WriteLine(s2.Plus(s1.Mid, s1.Final));
            //Console.WriteLine(s2.Plus(s1.Final,s1.Mid));
            //Student savg;
            //savg = s1 + s2;
            //Console.WriteLine(savg.Mid);
            //Console.WriteLine(savg.Final);
            Student s1 = new Student(60, 70);
            Student s2 = new Student(75, 80);
            Student savg = s1 + s2;
            Console.WriteLine(savg.Mid + "" + savg.Final);
        }
    }
}
