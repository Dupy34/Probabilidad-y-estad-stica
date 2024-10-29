using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public Button buttonBack;

    void Start()
    {
        buttonBack.onClick.AddListener(() => ChangeSceneBack("hub"));
    
    }

    void ChangeSceneBack(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
