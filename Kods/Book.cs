using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// <c>Book</c>Creates a Scriptable object to create new book pages in "Pamācība"
/// </summary>
[CreateAssetMenu]
public class Book : ScriptableObject {
    public string title;
    [TextArea(15, 20)]
    public string content;
    public Sprite example;
    public float fontSize = 18f;
}
