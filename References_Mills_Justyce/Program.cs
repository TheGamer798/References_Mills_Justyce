
using References_Mills_Justyce;

Sedan myFirstSedan = new Sedan(0);// ctreates new sedan object
IAutomobile myAutomobile = myFirstSedan;//Declared an IAutomobile object and assigned it to the sedan object

Sedan myOtherSedan = new Sedan(0);//Creates another new Sedan object

myFirstSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutomobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

myOtherSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutomobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

Truck myTruck = new Truck(50, 500, "myTruck");//creates a truck object

myFirstSedan.Stringify();
myAutomobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();
//Calls the Stringify method on all of the objects
