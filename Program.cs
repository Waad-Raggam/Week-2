using Demo11;

namespace Demo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Interface");
            // fan and tv
            // TurnOn()
            Fan fan1 = new Fan();
            fan1.TurnOn();
            // outcome: Fan is now ON
            fan1.TurnOff();

            TV tv1 = new TV();
            tv1.TurnOn();
            tv1.TurnOff();

            // IPowerable.TurnOn()

            // person
            Person person1 = new Person("An");

            // test
            Test test1 = new Test();
            test1.Display();
            // show data
            test1.Name = "test";
            Console.WriteLine($"new name: {test1.Name}");


            // class
            ClassExample example1 = new ClassExample();
            example1.MethodClass();

            // homework
            // step 1: create interface: 
            // name: INotificationService
            // methods: SendNotificationOnSuccess, SendNotificationOnFailure

            // step 2: implement the interface 
            // implement to the Library class
            // logic 
            // SendNotificationOnSuccess => print message: this notification sends successfully
            // SendNotificationOnFailure => print message: this notification doesnt sends successfully


            // step 3: test logic in Program.cs 

        }
    }
}
