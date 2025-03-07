﻿using BinaryFormatterAlternate.Classes;
using MessagePack;

namespace BinaryFormatterAlternate.Models;

/// <summary>
/// Represents a friend entity with personal details such as ID, first name, last name, birthdate, and cell phone.
/// IMessagePackSerializationCallbackReceiver provides events for before and after serialization and deserialization.
/// </summary>
/// <remarks>
/// This version of the Friend class uses the MessagePack library for serialization and deserialization by decorating
/// this class with attributes, indicating how the binary file should be encoded.
/// </remarks>
[MessagePackObject]
public class Friend1 : IMessagePackSerializationCallbackReceiver
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string FirstName { get; set; }
    [Key(2)]
    public string LastName { get; set; }
    [Key(3)]
    public DateOnly BirthDate { get; set; }
    [Key(4)]
    public string CellPhone { get; set; }

    public void OnBeforeSerialize()
    {
        SpectreConsoleHelpers.PrintCyan();
    }

    public void OnAfterDeserialize()
    {
        SpectreConsoleHelpers.PrintCyan();
    }
}