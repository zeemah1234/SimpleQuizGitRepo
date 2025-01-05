using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

var quiz = new Dictionary<int, (string Question, string Answer, string Options)>
{
   {1, ("What is the capital of France?", "C", "A, U.S.A\nB. INDIA\nC. PARIS\nD. INDIA")},
   {2, ("What is the largest planet in our solar system?", "A", "A, JUPITER\nB. MARS\nC. EARTH\nD. STAR")},    
   {3, ("Who is the president of Nigeria?", "B", "A, MUHAMMAD BUHARI\nB. BOLA AHMED TINUBU\nC. KAZEEM SHETTIMA\nD. DAPO ABIODUN")},
   {4, ("Who wrote 'Romeo and Juliet'?", "D", "A, Thomas\nB. Tinubu\nC. Alli\nD. Shakespeare")},
   {5, ("What is the boiling point of water?", "A", "A, 100\nB. 200\nC. CARBON IV DIOXIDE\nD. 50")},
        
};

int score = 0;

foreach (var item in quiz)
{
    Console.WriteLine(item.Value.Question);
    Console.WriteLine(item.Value.Options);
    string userAnswer = Console.ReadLine()!;

    if (userAnswer.Trim().ToUpper() == item.Value.Answer.Trim().ToUpper())
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine($"Wrong! The correct answer is {item.Value.Answer}.");
    }
}

Console.WriteLine($"Your final score is: {score}/{quiz.Count}");


