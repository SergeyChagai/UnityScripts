using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField firstNumberField;
    [SerializeField] private InputField secondNumberField;
    [SerializeField] private Dropdown operationSelector;
    [SerializeField] private Text responseField;

    private delegate decimal Operation(decimal first, decimal second);
    private Operation operation;

    public void Calculate()
    {
        if (firstNumberField.text.Length == 0 || secondNumberField.text.Length == 0) 
        {
            Debug.LogError("Empty field");
            return; 
        }
        Decimal.TryParse(firstNumberField.text, out var firstNumber);
        Decimal.TryParse(secondNumberField.text, out var secondNumber);
        ChooseOperation();
        responseField.text = operation(firstNumber, secondNumber).ToString();
    }

    private void ChooseOperation()
    {
        switch (operationSelector.value)
        {
            case 0:
                operation = (first, second) => first + second;
                break;
            case 1:
                operation = (first, second) => first - second;
                break;
            case 2:
                operation = (first, second) => first * second;
                break;
            case 3:
                operation = (first, second) => first / second;
                break;
        }
    }
}
