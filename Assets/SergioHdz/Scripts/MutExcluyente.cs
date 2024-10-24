using UnityEngine;
using UnityEngine.UI;

public class MutExcluyente : MonoBehaviour
{
    public InputField inputProbabilityA;
    public InputField inputProbabilityB;

    public Text resultText;

    // Método que se ejecutará cuando se presione el botón de cálculo
    public void CalcularProbabilidad()
    {
        // Convertir las entradas de texto a números (probabilidades)
        float probabilidadA = float.Parse(inputProbabilityA.text);
        float probabilidadB = float.Parse(inputProbabilityB.text);

        // Calcular la probabilidad total usando la Regla de la Suma para eventos mutuamente excluyentes
        float probabilidadTotal = probabilidadA + probabilidadB;

        // Mostrar el resultado en el UI
        resultText.text = "La probabilidad total es: " + probabilidadTotal.ToString();
    }
}
