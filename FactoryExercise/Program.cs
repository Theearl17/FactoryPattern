// See https://aka.ms/new-console-template for more information
using FactoryExercise;

Console.WriteLine("Hello, World!");
//// Create a console app that utilizes factory pattern by taking a user’s input of how many tires are on a vehicle and, 
///based on their input, creates that type of vehicle.
///Complete this using an interface. ]
///You must have at least 2 subclasses. For instance, if I type 4 into the console, the program would create a car or truck, 
///or if someone types 2 it would create a motorcycle.

//Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!


//Create an Interface named IVehicle that has a stubbed out public void Drive method.--------------
//Create 2 new public classes that will conform to IVehicle.------------------------------------
//Example) Car, Motorcycle, BigRig-----------------------------------------------
//Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)-----

//Now we will make our static VehicleFactory class.--------------------------------------
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.

// Create a Console App  //
Console.WriteLine("Welcome To my Garage");
Console.Write("Press Any Key to Continue");
Console.ReadKey();
Console.WriteLine("How many tires?");
var n = int.TryParse(Console.ReadLine(),out int userInput);
var instance = VehicleFactory.GetVehicle(userInput);
instance.Drive();



// Variables - Prompting the user for information //

// Prompting the user for a number of tires //
// Conver user intput into an int //
// CAll the Static Method on the Vehicle Factory Class //
// Print Information to the Console //