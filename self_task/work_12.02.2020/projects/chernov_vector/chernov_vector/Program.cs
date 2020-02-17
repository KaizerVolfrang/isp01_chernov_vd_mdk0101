using System;

namespace chernov_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(2,3,5);
            Vector vector2 = new Vector(3,6,7);

            Console.WriteLine("vec1" + vector1.ToString());
            Console.WriteLine("vec2" + vector2.ToString());

            vector1.Length();
            Console.WriteLine($"Результат длины вектора: {vector1.Length()}");

            vector1.ScalarProduct(vector2);
            Console.WriteLine($"Результат скалярного произведения векторов: {vector1.ScalarProduct(vector2)}");

            vector1.VectorArtWork(vector2);
            Console.WriteLine($"Результат векторного произведения векторов: {vector1.VectorArtWork(vector2)}");

            Console.ReadKey();
        }
    }
}
