using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to Guessing Game!");
    

}

for (int i = 4; i > 0; i--)
{
bool SecretNumberAsk = GuessingGame("What is the secret number?");
if (SecretNumberAsk)
{
    SecretNumberAnswer("You guessed the number!");
}
else
{
    SecretNumberAnswer("You did not guess the secret number!");
}

bool GuessingGame(string question)
{
    Console.WriteLine($"Your guess: ");
    string answer = Console.ReadLine();

    if (answer == "42")
    {
        return true;
    }
    else
    {
        return false;
    }
}
};
void SecretNumberAnswer(string message)
{
    Console.WriteLine($@"{message}");
}