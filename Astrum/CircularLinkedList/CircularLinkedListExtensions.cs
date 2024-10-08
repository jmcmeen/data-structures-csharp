﻿// ART GALLERY
// Chapter 4 (Variants of Lists)
// C# Data Structures and Algorithms, Second Edition

public static class CircularLinkedListExtensions
{
    public static LinkedListNode<T>? Next<T>(this LinkedListNode<T> n)
    {
        return n != null && n.List != null
            ? n.Next ?? n.List.First
            : null;
    }

    public static LinkedListNode<T>? Prev<T>(this LinkedListNode<T> n)
    {
        return n != null && n.List != null
            ? n.Previous ?? n.List.Last
            : null;
    }
}
