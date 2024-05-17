string message = "My name is Anish.";

int openPosition = message.IndexOf('M');
int closePosition = message.IndexOf('.');

Console.WriteLine(openPosition);
Console.WriteLine(closePosition);

Console.WriteLine(openPosition - closePosition);