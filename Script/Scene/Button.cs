using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StageChange(int sceneNumber)
    {
        string sceneName = "Game_" + sceneNumber;
        SceneManager.LoadScene(sceneName);
    }
}
