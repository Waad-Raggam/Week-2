namespace Demo9

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("OOP");
            // Inheritance
            // 3 classes
            // category: id, name, createdDate
            // product: id, name, quantity, createdDate
            // user: id, name, email, createdDate

            // animal example
            Dog dog = new Dog();
            dog.Eat("dog"); // from Animal class
            // The animal is eating
            // The dog is eating
            dog.Bark();
            dog.Sound();

            Duck duck = new Duck();
            duck.Eat("duck"); // from Animal class
            // The duck is eating
            duck.Quack();
            duck.Sound();

            // bank
            BankAccount bankAccount = new BankAccount();
            //Console.WriteLine($"{bankAccount._accountNumber}");
            // protected => cant access field from outside of class
            // not possible
            bankAccount.GetAccountNumber();

            // saving account - derived class
            // saving account object can access : _accountNumber
            SavingAccount savingAccount = new SavingAccount();
            // Console.WriteLine($"{savingAccount._accountNumber}");
            // not allow
            // derived class cant private fields
            savingAccount.GetAccountInformation();



        }
    }
}