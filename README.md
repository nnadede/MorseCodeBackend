# Morse Code Translator (Console)

Simple console application that encodes and decodes Morse code using a binary tree for decoding and a dictionary for encoding.

## Features

- Interactive console menu to encode text to Morse and decode Morse to text.
- Supports letters, digits, and common punctuation.
- Unit tests for the Node, Morse dictionary, and binary tree.

## Prerequisites

- .NET 9.0 SDK (or compatible .NET 9.x)

## Build

From the repository root:

```bash
dotnet restore
dotnet build
```

## Run (interactive)

Run the console app from the Backend project folder:

```bash
cd Backend
dotnet run
```

Follow the on-screen menu:

- Choose "1" to encode a message (text → Morse)
- Choose "2" to decode Morse (Morse → text)
- Press "Q" to quit

## Input format / examples

- **Encoding**: enter plain text (letters, digits, punctuation). Output uses a single space between Morse letters and two spaces between words.
  - Example: `SOS` → `··· --- ···` (displayed as `... --- ...`)
- **Decoding**: enter Morse with a single space between letters and two spaces between words.
  - Example: `.... . .-.. .-.. ---` → `HELLO`
  - Use double space to separate words when decoding: `.... .  .-..` → yields a space between decoded words

## Tests

From the repository root or the tests folder:

```bash
dotnet test Backend.Tests
```

## Notes

- This is a local console tool. The encoding map is in `Backend/MorseDict.cs` and decoding is performed via `Backend/BinaryTree.cs`.
