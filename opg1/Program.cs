
using System;

namespace opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Preben", "S1", new DateTime(2021, 8, 10));
            Student b = new Student("Lars", "T1", new DateTime(2020, 1, 1));
            Student c = new Student("Daddy", "S1", new DateTime(2020, 1, 1));
            Student d = new Student("Viktor", "S1", new DateTime(2020, 1, 1));
            Student e = new Student("Simon", "S1", new DateTime(2020, 1, 1));


            Console.WriteLine(a.ToString());
        }
    }
}
