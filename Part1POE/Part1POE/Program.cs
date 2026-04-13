using System;
using System.Speech.Synthesis;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        speech.SelectVoiceByHints(VoiceGender.Female);

        speech.Speak("Hello, Welcome to the Cybersecurity awareness bot");

        ShowLogo();

        Divider();
        TypeText("Protect your data * Trust no link * Stay encrypted");
        Divider();

        string name = GetUserName();

        Console.WriteLine("Welcome " + name + "! Let's keep you safe online.");
        Console.WriteLine("Please press any key to start...");
        Console.ReadKey(true);

        int choice = 0;

        do
        {
            Console.Clear();

            ShowLogo();

            Divider();
            Console.WriteLine("   CYBERSECURITY AWARENESS MENU");
            Divider();

            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing Awareness");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. Chat with Bot");
            Console.WriteLine("5. Exit");

            Divider();
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("I didn’t understand that. Please enter a valid option.");
                continue;
            }

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    TypeText("PASSWORD SAFETY");
                    Console.WriteLine(" *Use strong passwords (12+ characters)");
                    Console.WriteLine(" *Mix letters, numbers, symbols");
                    Console.WriteLine(" *Never reuse passwords");
                    Console.WriteLine(" *Avoid personal information or any of your family member's personal information");
                    break;

                case 2:
                    TypeText("PHISHING AWARENESS");
                    Console.WriteLine(" *Do not click suspicious links");
                    Console.WriteLine(" *Check sender email carefully");
                    Console.WriteLine(" *Look for spelling mistakes");
                    Console.WriteLine(" *Never share OTPs or passwords");
                    break;

                case 3:
                    TypeText("SAFE BROWSING");
                    Console.WriteLine(" *Use HTTPS websites only");
                    Console.WriteLine(" *Avoid unknown downloads");
                    Console.WriteLine(" *Keep browser updated");
                    Console.WriteLine(" *Use antivirus protection");
                    break;

                case 4:
                    TypeText("Entering Chat Mode...");
                    ChatMode();
                    break;

                case 5:
                    TypeText("Exiting Cyber Awareness Bot... Stay safe online!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (choice != 5)
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey(true);
            }

        } while (choice != 5);
    }


    static void ChatMode()
    {
        while (true)
        {
            Console.WriteLine("\n===== CHAT MENU =====");
            Console.WriteLine("1. How are you?");
            Console.WriteLine("2. What's your purpose?");
            Console.WriteLine("3. What can I ask you about?");
            Console.WriteLine("4. Exit chat");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please select a valid option.");
                continue;
            }

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Bot: I'm doing great! How are you?");
                    string mood = Console.ReadLine().ToLower();

                    if (mood == "good" || mood == "Good")
                        Console.WriteLine("Bot: Glad to hear that ");
                    else if (mood == "bad" || mood == "Bad")
                        Console.WriteLine("Bot: Sorry to hear that ");
                    else
                        Console.WriteLine("Bot: Thanks for sharing.");
                    break;

                case 2:
                    Console.WriteLine("Bot: I help you learn cybersecurity awareness and stay safe online.");
                    break;

                case 3:
                    Console.WriteLine("Bot: You can ask about passwords, phishing, and safe browsing.");
                    Console.Write("Type a topic: ");

                    string topic = Console.ReadLine().ToLower();

                    if (topic.Contains("password"))
                        Console.WriteLine("Bot: Use strong passwords and never reuse them.");
                    else if (topic.Contains("phishing"))
                        Console.WriteLine("Bot: Phishing tricks users into giving sensitive info.");
                    else if (topic.Contains("safe"))
                        Console.WriteLine("Bot: Use HTTPS websites and avoid suspicious downloads.");
                    else
                        Console.WriteLine("Bot: I didn’t quite understand that.");
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }


    static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("   ____        _               ____        _   ");
        Console.WriteLine("  / ___| _   _| |__   ___ _ __| __ )  ___ | |_ ");
        Console.WriteLine(" | |    | | | | '_ \\ / _ \\ '__|  _ \\ / _ \\| __|");
        Console.WriteLine(" | |___ | |_| | |_) |  __/ |  | |_) | (_) | |_ ");
        Console.WriteLine("  \\____| \\__, |_.__/ \\___|_|  |____/ \\___/ \\__|");
        Console.WriteLine("         |___/                                 ");

        Console.ResetColor();
    }

    static string GetUserName()
    {
        string name;

        do
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name.");
            }

        } while (string.IsNullOrWhiteSpace(name));

        return name;
    }

    static void TypeText(string text, int delay = 20)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    static void Divider()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("==========================================");
        Console.ResetColor();
    }
}