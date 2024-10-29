using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menumanager : MonoBehaviour
{
    public Button scene1Button;
    public Button scene2Button;
    public Button scene3Button;

    void Start()
    {
        scene1Button.onClick.AddListener(() => ChangeScene("regladelproducto"));
        scene2Button.onClick.AddListener(() => ChangeScene("Cal"));
        scene3Button.onClick.AddListener(() => ChangeScene("FirstScene"));
    }

    void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
