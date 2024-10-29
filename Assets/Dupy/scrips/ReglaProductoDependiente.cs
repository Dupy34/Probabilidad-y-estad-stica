using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReglaProductoDependiente : MonoBehaviour
{
    public TMP_InputField inputNumbers;  
    public TMP_Text resultText;          
    public UnityEngine.UI.Button calculateButton;   

    void Start()
    {
       
        calculateButton.onClick.AddListener(CalculateProductRule);
    }

    void CalculateProductRule()
    {
        string input = inputNumbers.text;
        string[] numberStrings = input.Split(' ', ',');
        int product = 1;
        foreach (string numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                product *= number;
            }
            else
            {
                resultText.text = "error, coloca bien los numeros";
                return;
            }
        }

       
        resultText.text = "resultado: " + product;
    }
}
