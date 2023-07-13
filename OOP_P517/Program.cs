Vehicle vehicle = new Vehicle("red", 2000);
Car car = new Car("black",1999, "BMW", "Tesla",12.4,5);
car.CurrentFuel = 2;
//vehicle.ShowInfo();
//car.ShowInfo();

Shape shape = new Shape();
//shape.CalculateArea();

Circle circle = new Circle(5);
//circle.CalculateArea();

Rectangle rectangle = new Rectangle(2,3);
//rectangle.CalculateArea();

Employee employee = new Employee("Nigar", "Rahimli", 3000);

//Console.WriteLine(employee.CalculateBonus());

Engineer engineer = new Engineer("Mehemmed","Ceferli",3000);

//Console.WriteLine(engineer.CalculateBonus());

Manager manager = new Manager("Isa", "Sadiqov", 3000);

//Console.WriteLine(manager.CalculateBonus());

BankAccount bankAccount = new BankAccount(123);
bankAccount.Deposit(10);
//Console.WriteLine(bankAccount.Balance);
bankAccount.Deposit(10);
//Console.WriteLine(bankAccount.Balance);
bankAccount.Withdraw(5);