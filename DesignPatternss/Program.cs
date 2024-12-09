using DesignPatterns.Lib.BuilderPattern;
using DesignPatternss.AdepterPattern;
using DesignPatternss.BuilderPattern.DiffInstitutions;
using DesignPatternss.ChainOfResponsibility;
using DesignPatternss.FactoryPattern;
using DesignPatternss.ObserverPattern;
using DesignPatternss.StatePattern;
using DesignPatternss.StrategyPattern;
using System;

class Program
{
    static void Main(string[] args)
    {

        //#region BuilderPattern
        //IEmployeeBuilder employeeBuilder = new InternalEmployeeBuilder();
        //employeeBuilder.SetEmailAdress("egerumas@gmail.com");
        //employeeBuilder.SetFullName("Ege Samur");
        //var emp = employeeBuilder.BuildEmployee();
        //Console.WriteLine(emp.EmailAdress);
        //Console.WriteLine(emp.FirstName);
        //Console.WriteLine(emp.LastName);
        //var emp2 = GenereteEmp("Ege Samur", "egeruams@gmail.com", 1);
        //var emp3 = GenereteEmp("Ege sual", "samurege@gmail.com",0);
        //Console.WriteLine(emp2.EmailAdress);
        //Console.WriteLine(emp2.FirstName);
        //Console.WriteLine(emp2.LastName);
        //Console.WriteLine(emp3.EmailAdress);
        //Console.WriteLine(emp3.FirstName);
        //Console.WriteLine(emp3.LastName);
        //#endregion

        //#region ChainOfResponsibility
        //var order = new Order();
        //var stockControl = new StockControl();
        //var payment = new PaymentControl();
        //var invoice = new InvoicetControl();
        //var shipping = new ShippingControl();
        //stockControl.SetNext(payment);
        //payment.SetNext(invoice);
        //invoice.SetNext(shipping);
        //#endregion

        //#region FactoryPattern
        //var hakkariPizzaStore = new HakkariPizzaStore();
        //hakkariPizzaStore.OrderPizza("cheese");
        //var izmirPizzaStore = new İzmirPizzaStore(); 
        //izmirPizzaStore.OrderPizza("veggie");
        //#endregion

        //#region StatePattern
        //// if order.State = asdf kontrolü yapmaya gerek yok 
        //var newOrder = new OrderStatePattern();
        //newOrder.PrintOrderState();
        //newOrder.NextState();
        //newOrder.PrintOrderState();
        //#endregion

        //#region ObserverPattern
        //var samsung =  new Product("Samsung", 1000);
        //var egeObserver = new EgeObserver("Ege Samur");
        //var amazon = new Amazon();
        //amazon.Register(egeObserver, samsung);
        //amazon.NotifyAll();
        //#endregion


        //#region StrategyPattern
        //var paymentOptions = new PaymentOptions
        //{
        //    Amount = 1000,
        //    CardHolderName = "Ege Samur",
        //    CardNumber = "123456789",
        //    Cvv = "123",
        //    ExpDate = "12/23"
        //};
        //var paymentService = new PaymentService();

        //do
        //{
        //    Console.WriteLine("Ödeme yapmak istediğiniz bankayı seçiniz 1,2,3");
        //    var bank = Console.ReadLine();

        //    IPaymentService bankPaymentService = null;
        //    switch (bank)
        //    {
        //        case "1":
        //            bankPaymentService = new GarantiBankPaymentService();
        //            break;
        //        case "2":
        //            bankPaymentService = new YapiKrediBankPaymentService();
        //            break;
        //        case "3":
        //            bankPaymentService = new IsBankPaymentService();
        //            break;
        //        default:
        //            Console.WriteLine("Geçersiz banka seçimi");
        //            break;
        //    }
        //    paymentService.SetPaymentService(bankPaymentService);
        //    paymentService.PayViaStrategy(paymentOptions);

        //}
        //while(Console.ReadKey().Key != ConsoleKey.Escape);
        //#endregion


        #region AdepterPattern
        var transaction = new DesignPatternss.AdepterPattern.TransferTransaction()
        {
            FromIBAN = "TR123456789",
            toIban = "TR987654321",
            Amount = 1000
        };
        var adepterJson = new JsonBankApiAdepter();
        adepterJson.ExecuteTransaction(transaction);
        var adepterXml = new XmlBankApiAdepter();
        adepterXml.ExecuteTransaction(transaction);
        #endregion

    }
    private static Employee GenereteEmp(string fullName, string email, int type)
    {
        IEmployeeBuilder employeeBuilder;
        if (type == 0)
            employeeBuilder = new InternalEmployeeBuilder();
        else
            employeeBuilder = new ExternalEmployeeBuilder();

        employeeBuilder.SetEmailAdress(email);
        employeeBuilder.SetFullName(fullName);
        return employeeBuilder.BuildEmployee();
    }
}
