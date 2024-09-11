using System;

namespace Demo12
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine($"Dependency injection.");

                // console app
                // app item => fav list  => send message in terminal 
                // [] => [{}, {},{}]
                // AddFav(item1)
                // message in terminal => item 1 added in the list successully

                //create obj from EmailMessageService 
                var emailService = new EmailMessageService();

                //create obj from SMSMessageService 
                var smsService = new SMSMessageService();


                var favoriteListEmail = new FavoriteList(emailService);
                favoriteListEmail.AddFav("item1");
                // A item is added: item1

                var productListEmail = new ProductList(emailService);
                productListEmail.AddProduct("1");
                // A item is added: item2


                var favoriteListSMS = new FavoriteList(smsService);
                favoriteListSMS.AddFav("new");
                // A item is added from sms: new



                // example of payment
                // 2 types of payment: Paypal and Credit card
                // print amount of money and method when I send money or receive money
                // I have receive 10$ via Paypal
                // I have send  5$ via Paypal

                // create object from class
                var paypalMethod = new PaypalPayment();
                var paymentProcessor = new PaymentProcessor(paypalMethod);

                paymentProcessor.SendMoney(100.00m);
                // Payment of 100.00 via Paypal

                // homework

                // afternoon
                // 1. re-watch the recording
                // 2. practice the demo code
                // first time: 
                // second time: 

                // 3. assignment 
                // step 1: create interface: INotificationService
                // step 2: class EmailNotificationService that implement from INotificationService
                // step 3: inject into Library class
                // step 4: use email service in Program.cs


                // SMS

            }
        }
    }
}
