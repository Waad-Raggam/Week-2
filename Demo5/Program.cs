using Demo6;
using Demo7;


namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class");
            // create object from class
            // way 1
            //Car car1 = new Car("Tesla", "Y", 1999);
            Car car1 = new Car("Tesla", "Y");


            // way 2
            // var car2 = new Car("Audi", "S", 2000);
            var car2 = new Car("Audi", "S");


            // access the field
            Console.WriteLine($"Brand: {car1.Brand}");
            // "Tesla"
            // change value of field
            car1.Brand = "Honda";
            Console.WriteLine($"Brand: {car1.Brand}");


            // method
            car1.DisplayInformation();
            Console.WriteLine($"Result:{car1.Add(1, 2)}");

            // access modifiers: public, private, static 

            // private
            // create an object from Person class
            // Car car1 = new Car("Tesla", "Y");
            Person person1 = new Person();
            // Console.WriteLine($"FirstName: {person1._firstName}");
            Console.WriteLine($"FirstName: {person1.FirstName}");
            Console.WriteLine($"FirstName: {person1.LastName}");


            Console.WriteLine($"FirstName: {person1.Age}");

            // private method
            // create an object from class
            Calculator cal1 = new Calculator();
            // cal1.Add(1, 2);

            // public method
            cal1.PerformCalculator(1, 2);

            // keyword: static
            // field static => dont need to create object from class
            // 0
            Counter counter1 = new Counter();
            // Console.WriteLine($"{counter1.count}");
            // error => static

            Console.WriteLine($"Count: {Counter.count}");
            // 1

            // Counter counter2 = new Counter();
            Console.WriteLine($"Count: {Counter.count}");
            // 2

            // static method
            Console.WriteLine($"Example of static method: {MathUtilities.Square(2)}");

            // namespace
            Example example1 = new Example("class");
            // adding namespace
            // using Demo6;
            Weather weather = new Weather("class");


            // Q&A: constructor overloading

        }
    }
}

