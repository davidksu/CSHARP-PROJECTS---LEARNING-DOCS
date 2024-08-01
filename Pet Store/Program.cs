//Pet Store - Code Project 3
//Author: David Lincoln
// Description: This program provides sample data, a user interface for selecting pet data from a menu, and display the correct pet data based on user selection.



// ourAnimals array will store the following: 
using System.Collections;
using System.Runtime.CompilerServices;

string animalSpeciies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

//variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
bool validEntry = false;
int petCount = 0;
string anotherPet = "y";
int petAge = 0;

//array for storing real-time data, there is no persisted data 
string[,] ourAnimals = new string[maxPets, 6];

// sample dataset for ourAnimals array
for (int i = 0; i < maxPets; i++) {

    switch(i) {

            case 0: 
            animalSpeciies = "Dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored femail golden retriever";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. give lots of kisses.";
            animalNickname = "lola";
            break;

            case 1:
                animalSpeciies = "Dog";
                animalID = "d2";
                animalAge = "9";
                animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                animalNickname = "loki";
                break;

            case 2: 
                animalSpeciies = "Cat";
                animalID = "c3";
                animalAge = "1";
                animalPhysicalDescription = "small black and white kitten with a pink nose and blue eyes.";
                animalPersonalityDescription = "loves to play with toys and chase string. very affectionate and loves to be held.";
                animalNickname = "mittens";
                break;

            case 3: 
                animalSpeciies = "Cat";
                animalID = "c4";
                animalAge = "?";
                animalPhysicalDescription = "";
                animalPersonalityDescription = "";
                break;

            default: 
                    animalSpeciies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpeciies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical Description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality Description: " + animalPersonalityDescription;

}

// menu loop program
do {
    // Display the top-level menu options
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:\n");
    Console.WriteLine("1. list all of our current pet information");
    Console.WriteLine("2. Add a new animal friend to the ourAnimal Array");
    Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine("5. Edit an animal's age");
    Console.WriteLine("6. Edit an animal's personality description");
    Console.WriteLine("7. Display all cats with a specified characteristic");
    Console.WriteLine("8. Display all dogs with a specified characteristic\n");
    Console.WriteLine("Enter your selection number (or type exit to close the program)");

    readResult = Console.ReadLine();
    if(readResult != null) {
        menuSelection = readResult.ToLower();
    }
   
    Console.WriteLine("\nPress the Enter key to continue");
    Console.ReadLine();


    switch(menuSelection) {



        case "1":
         // List all of our current pet information
         //outer for loop
        for(int i = 0; i < maxPets; i++){
            // if statement that checks for petID data

            if(ourAnimals[i,0] != "ID#: ") {

                Console.WriteLine(ourAnimals[i,0]);

                //inner loop that counts the number of pets in the ourAnimals array with assigned data
                for (int j = 0; j < 6; j++) {

                    Console.WriteLine(ourAnimals[i,j]);
                
                }
            }
        }

        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "2":
         // List all of our current pet information

        for(int i = 0; i < maxPets; i++) {

            //checks data for petID and increments the pet count by 1.
            if(ourAnimals[i,0] != "ID #: ") {

                petCount += 1;
            }
        }

        if(petCount < maxPets) {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {maxPets - petCount} more. ");
        } 

        Console.WriteLine("Press the Enter key to continue.");
        
        while(anotherPet == "y" && petCount < maxPets) {
            
            do {
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();

                if(readResult != null) {
                    animalSpeciies = readResult.ToLower();

                    if(animalSpeciies == "dog" || animalSpeciies == "cat") {
                     validEntry = false;
                    }
                    else {
                        validEntry =  true;
                    }
                }
            } while (validEntry == false);

            //Buld ID numbers for the animals

            animalID = animalSpeciies.Substring(0,1) + (petCount + 1).ToString();
        }


        break;

        case "3":
         Console.WriteLine("Challenge Project - please check back soon to see progress.");
         Console.WriteLine("Press the Enter key to continue.");
         readResult = Console.ReadLine();
        break;

        case "4":
         Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
         Console.WriteLine("Press the Enter key to continue.");
         readResult = Console.ReadLine();
        break;

        case "5":
         // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "6":
         // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "7":
         // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();

        break;

        case "8":
         // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        default:
         // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    }
} while (menuSelection != "exit");