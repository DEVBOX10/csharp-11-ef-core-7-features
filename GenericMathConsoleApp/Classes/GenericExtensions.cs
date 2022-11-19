﻿
namespace GenericMathConsoleApp.Classes;

public static class GenericExtensions
{
    /// <summary> Provides a IN like condition generic method </summary>
    public static bool InCondition<T>(this T sender, params T[] values) 
        => values.Contains(sender);
}