//Title: Inventory Managment
//Author: David Lincoln

//initialize
using System.Runtime.CompilerServices;

int[] inventory = { 200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
//foreach statement 

// sum each element in the array.
foreach (int i in inventory) {
    sum += i;
    bin++;
    Console.WriteLine($"Bin{bin} = {i} items (Running total: {sum})");
}

//output display
Console.WriteLine($"We have {sum} items in inventory");

//challenge: Report the order IDs that need further investigation

//initialize

string [] orderID = { "B123", "C234","A345", "C15", "B177", "G3003","C235", "B179"};

foreach( string i in orderID ) {
    if (orderID.StartsWith("B")) {
        Console.WriteLine(i);
    }
}