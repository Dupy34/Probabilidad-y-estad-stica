using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MutExcluyente : MonoBehaviour
{
    public TMP_InputField inputProbabilityA;
    public TMP_InputField inputProbabilityB;

    public TextMeshProUGUI resultText;

    public void CalculateProbability()
    {

        float ProbabilityA = float.Parse(inputProbabilityA.text);
        float ProbabilityB = float.Parse(inputProbabilityB.text);

        float probaTotal = ProbabilityA + ProbabilityB;

        resultText.text = "La probabilidad total es: " + probaTotal.ToString();
    }
}
