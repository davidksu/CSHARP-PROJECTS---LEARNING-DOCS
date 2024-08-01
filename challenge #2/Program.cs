/*
title: student grade calulator 
author: David Lincoln
date: 07/14/2024
*/

// student names
string [] studentNames = new string [] { "Tequan", "Terron", "Danyo",};
//student grades

int examAssignments = 5;

decimal [] studentScores = new decimal [10];

decimal[] tequanScores = new decimal[] { 90, 93, 88, 97 };
decimal[] terronScores = new decimal[] { 90, 93, 95, 88 };
decimal[] danyoScores = new decimal[] { 90, 91, 86, 74 };

//headers
Console.WriteLine("Student\t\tExam Score\t\t Overall Grade \t\t Extra Credit\n");

//calculation
foreach (string i in studentNames)
{
    string currentStudent = i;

    if (currentStudent == "Tequan")
    {
        studentScores = tequanScores;
    }
    else if (currentStudent == "Terron")
    {
        studentScores = terronScores;
    }
    else if (currentStudent == "Danyo")
    {
        studentScores = danyoScores;
    }

    //initalization exam score
    decimal examScore = 0;
    //intitialization - overall grade 
    decimal overallGrade = 0;
    //initialization - extracredit 
    decimal extraCredit = 0;

    foreach (decimal score in studentScores)
    {
        examScore += 1;
    }

    overallGrade = examScore/studentScores.Length;
    extraCredit =overallGrade * 0.10m;

    //Grade Scale
    string grade;
    if (overallGrade >= 90) {
        grade = overallGrade >= 93 ? "A" : "A-";
    }
    else if (overallGrade >= 80) {
        grade = overallGrade >= 87 ? "B+": "B-";
    }
    else {
        grade = "C";
    }
    Console.WriteLine($"{currentStudent}\t\t{studentScores}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
