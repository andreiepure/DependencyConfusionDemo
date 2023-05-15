using Google.Protobuf;
using System;

Console.WriteLine($"Hello, Corporation! I will use Google.Protobuf at some point in {PrintMessage}");

void PrintMessage(IMessage message)
{
    var descriptor = message.Descriptor;
    // ToDo
}