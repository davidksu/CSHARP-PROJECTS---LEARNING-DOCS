// Manage user input during this challenge
//Author: David Lincoln

string? readResponse;
bool validentry = false;

Console.WriteLine(" Enter a string at least 3 characters long:");

do {

    readResponse =  Console.ReadLine();

    if(readResponse != null) {

        if(readResponse.Length >= 3 || readResponse.Length >= 2 ) {

            validentry =  true;
        }

        else {

            Console.WriteLine("Invalid entry. Please try again.");
        }
    }

} while(validentry == false);

