using System;

class Program
{
    static string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
    static string[] rsvps = new string[10];
    static int count = 0;

    static void RSVP(string name, int partySize, string allergies, bool inviteOnly)
    {
        if (inviteOnly)
        {
            bool found = false;
            foreach (string guest in guestList)
            {
                if (guest == name)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list.");
                return;
            }
        }

        rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
        count++;
    }

    static void ShowRSVPs()
    {
        Console.WriteLine("\nTotal RSVPs:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(rsvps[i]);
        }
    }

    static void Main(string[] args)
    {
        RSVP("Rebecca", 1, "none", true);
        RSVP("Nadia", 2, "Nuts", true);
        RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
        RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
        RSVP("Noor", 4, "none", false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();
    }
}
