namespace Demo6
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List, Generic and Linq");
            // List
            // create a list
            List<int> numbers = new List<int>();
            // {}
            numbers.Add(1);
            // {1}
            numbers.Add(2);
            // {1,2}
            numbers.Add(3);
            // {1,2,3}

            // print ech item in list
            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list: {number}");

            }
            // shortcut
            // List<int> numbers = [];
            // List<int> numbers1 = [1, 2, 3];
            // List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };

            // example list: numbers = [1,2,3]
            // built-in methods
            // indexOf - 0
            int index = numbers.IndexOf(3);
            Console.WriteLine($"Index of number 1: {index}");

            // Insert(int index, item)
            // [1,2,3]
            // outcome: [1,4,2,3]
            numbers.Insert(1, 4);
            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list: {number}");
            }
            // outcome [1,4,2,3]


            // Remove(item)
            numbers.Remove(1);
            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list after remove: {number}");
            }
            // check has number => remove
            // for loop => any => remove
            // [4,2,3]
            numbers.Remove(10);
            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list after remove 10: {number}");
            }

            // [4,2,3] => same list

            // RemoveAt(index);
            // error => index
            numbers.RemoveAt(0);
            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list after remove item with index 0: {number}");
            }
            // numbers.RemoveAt(5);
            // error => handle exception

            // RemoveAll
            // lambda expression 
            numbers.RemoveAll(number => number > 3);

            foreach (int number in numbers)
            {
                Console.WriteLine($"Item in number list after remove all item >1: {number}");
            }

            numbers.Add(4);
            numbers.Add(5);
            // [2,3,4,5]

            // Contains(item)
            // return type: bool
            bool hasTwo = numbers.Contains(2);
            Console.WriteLine($"Contains result: {hasTwo}");

            bool hasOne = numbers.Contains(1);
            Console.WriteLine($"Contains result: {hasOne}");

            // Find number>1
            // [2,3,4,5]
            // first element match with condition
            int foundNumber = numbers.Find(n => n > 1);
            Console.WriteLine($"Found number >1 : {foundNumber}");
            // 2

            int foundNumberEx = numbers.Find(n => n > 8);
            Console.WriteLine($"Found number >8: {foundNumberEx}");
            // outcome 0

            // Sort - asc
            numbers.Sort();
            // Reverse
            numbers.Reverse();


            // Generic
            // example: Box

            // var<int> boxInt = new Box<int>(123);
            Box<int> boxInt = new Box<int>(123);
            boxInt.Display(1);
            // outcome: T has int type

            // var boxStr = new Box<string>("Hello");
            Box<string> boxStr = new Box<string>("Hello");

            var boxBool = new Box<bool>(true);

            Box<object> objBox1 = new Box<object>(345);

            // create 2 separate class
            // 1 class => generic 
            // constructor overloading
            // (int pa2)
            // (string pa1)

            // generic method
            // method1:

            // Person person1 = new Person();
            // person1.PrintItem(123);
            // person1.PrintItem("hello");
            // person1.PrintItem(true);
            Person.PrintItem(123);


            // pass a list
            List<int> numberList = [1, 2, 3, 4, 5];
            List<string> stringList = ["Jomana", "Raghad", "Manar"];

            // method to print each item in list
            // person1.PrintList(numberList);
            Person.PrintList(numberList);
            Person.PrintList(stringList);

            // Linq

            // example product list
            // product: name, quantity
            // list: logic: add 

            // create a ProductItem class
            // create a ProductList class => logic

            // try logic
            ProductList storeInventory = new ProductList();
            storeInventory.AddProduct(new ProductItem("Laptop", 10));
            storeInventory.AddProduct(new ProductItem("Phone", 20));
            storeInventory.AddProduct(new ProductItem("Tablet", 15));
            storeInventory.AddProduct(new ProductItem("Watch", 5));
            storeInventory.RemoveProduct("Watch");
            // after:  [{"Laptop", 10}, {"Phone",20},{"Tablet", 15} ]

            storeInventory.RemoveProduct("Phone");
            // after:  [{"Laptop", 10}, {"Tablet", 15} ]
            Console.WriteLine($"Sum quantity: {storeInventory.GetCurrentVolume()}");
            // 10+15 = 25
            storeInventory.AddProduct(new ProductItem("Watch1", 12));
            storeInventory.AddProduct(new ProductItem("Watch2", 3));
            //var sortedArray = storeInventory.SortByName();

            // foreach (var item in sortedArray)
            // {
            //     Console.WriteLine($"Item: {item.Name},  {item.Quantity}");

            // }


            storeInventory.SortByName();

            foreach (var item in storeInventory.items)
            {
                Console.WriteLine($"Item: {item.Name},  {item.Quantity}");

            }













        }
    }
}
