// write code that validates integer input
// Author: David Lincoln

string? readValue;
string userEntry = "";
int numValue = 0;
bool validEntry = false;


Console.WriteLine("Enter an integer value between 5 and 10:");
Console.ReadLine();
do {
    readValue = Console.ReadLine();
    if(readValue != null) {
        userEntry = readValue;
    }

    validEntry = int.TryParse(userEntry, out numValue); // check if userEntry is an integer

    if(validEntry == true) {
        
        if (numValue >= 5 || numValue <= 10) {
            Console.WriteLine($"You entered: {numValue} has been accepted ");
            validEntry = true;
        }
        else if (numValue < 5 || numValue > 10) {
            Console.WriteLine("Invalid entry. Please enter an integer value between 5 and 10");
            validEntry = false;
        }
        
        else {
            Console.WriteLine("Invalid entry. Please enter an integer value between 5 and 10");
            validEntry = false;
        }
    }

} while (validEntry == false);