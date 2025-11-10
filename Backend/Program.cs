
using Backend;


Console.WriteLine("Welcome to Morse Code Translator!");

bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("Choose from the following options:");
    Console.WriteLine("1. Encode a message to Morse code");
    Console.WriteLine("2. Decode a Morse code message");
    Console.WriteLine("Q to quit");

    Console.Write("Enter your choice: ");
    char option = Console.ReadKey().KeyChar;

    Console.WriteLine(); // For better formatting

    switch (option)
    {
        case '1':
            Console.WriteLine("Enter the message to encode:");
            string? message = Console.ReadLine();
            // Call the encoding function here
            if (message != null)
            {
                foreach (char c in message.ToUpper())
                {
                    if (MorseDict.CharToMorse.TryGetValue(c, out string? value))
                    {
                        Console.Write(value + " ");
                    }
                    else if (c == ' ')
                    {
                        Console.Write("  "); // Extra space for word separation
                    }
                }
                Console.ReadLine();
            }
            break;
        case '2':
            Console.WriteLine("Enter the Morse code to decode:");
            string? morseCode = Console.ReadLine();
            // Initialize the binary tree for decoding
            BinaryTree tree = new BinaryTree();
            tree.InitTree();
            // Call the decoding function here
            string[] codes = morseCode?.Split(' ') ?? Array.Empty<string>();
            foreach (var code in codes)
            {
                char decodedChar = (code == "") ? ' ' : tree.Decode(code);
                Console.Write(decodedChar);
            }
            Console.ReadLine();
            break;
        case 'Q':
        case 'q':
            Console.WriteLine("Exiting...");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
