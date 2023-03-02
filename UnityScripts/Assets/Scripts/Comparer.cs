using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Comparer : MonoBehaviour
{
    [SerializeField] private InputField firstNumberField;
    [SerializeField] private InputField secondNumberField;
    [SerializeField] private Text responseField;

    public void Compare()
    {
        if (firstNumberField.text.Length == 0 || secondNumberField.text.Length == 0)
        {
            Debug.LogError("Empty field");
            return;
        }
        decimal.TryParse(firstNumberField.text, out var firstNumber);
        decimal.TryParse(secondNumberField.text, out var secondNumber);
        var result = CompareTwoNumbers(firstNumber, secondNumber);
        responseField.text = result;
    }

    private string CompareTwoNumbers(decimal firstNumber, decimal secondNumber)
    {
        if (firstNumber > secondNumber) return firstNumber.ToString();
        else if (firstNumber < secondNumber) return secondNumber.ToString();
        else return "Equals";
    }

}
