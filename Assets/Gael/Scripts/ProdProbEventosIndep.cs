using UnityEngine;
using TMPro;

public class ProdProbEventosIndep : MonoBehaviour
{
    public TMP_InputField TMP_InputProbabilityA; 
    public TMP_InputField TMP_InputProbabilityB;
    public TextMeshProUGUI TMP_ResultText; 

    public void CalculateProbability()
    {
        if (float.TryParse(TMP_InputProbabilityA.text, out float probabilityA) &&
            float.TryParse(TMP_InputProbabilityB.text, out float probabilityB))
        {
            if (probabilityA < 0 || probabilityA > 1 || probabilityB < 0 || probabilityB > 1)
            {
                TMP_ResultText.text = "Las probabilidades deben estar entre 0 y 1.";
                return;
            }

            float result = probabilityA * probabilityB;
            TMP_ResultText.text = "Probabilidad de ambos eventos: " + result.ToString("F2");
        }
        else
        {
            TMP_ResultText.text = "ingresa valores numéricos.";
        }
    }
}