using UnityEngine;
using UnityEngine.SceneManagement;

public class stage_select : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Game_1");
    }
}
