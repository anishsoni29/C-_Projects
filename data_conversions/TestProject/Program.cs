string pangrams = "My name is Anish and I belong to India";

string[] message = pangrams.Split(' ');

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = string.Join(" ", newMessage);
Console.WriteLine(result);