//Pizza Party Calculator
//Name: Webster B
//Date: 1/22/25

//Declare variables
int numberOfGuests;
int slicesPerGuest = 3; // Assume each guest eats 3 slices
int slicesPerPizza = 8; // Standard pizza has 8 slices

//Prompt the user to enter the number of guests:
Console.Write("Enter the number of guests: ");

// Call the Parse function to turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculate the total number of slices needed:
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculate the number of pizza required
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Output the number of pizzas needed 
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");


