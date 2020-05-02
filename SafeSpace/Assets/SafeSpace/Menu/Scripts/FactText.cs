﻿using UnityEngine;
using TMPro;

/// <summary>
/// Generates a random fact based on user input in unity editor
/// </summary>
public class FactText : MonoBehaviour
{
    public TextMeshProUGUI factToDisplay;
    public string[] test;
    private System.Random rnd;
    // Start is called before the first frame update
    void Start()
    {
        rnd = new System.Random();
        factToDisplay.text = test[this.rnd.Next(0, test.Length)];
    }

}
