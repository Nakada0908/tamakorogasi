using UnityEngine;
using UnityEngine.SceneManagement;

public class GoUraButton : MonoBehaviour
{
    bool ura1, ura2, ura3;
    bool isLoad=false;

    public void Ura1()
    {
        ura1=true;
    }
    public void Ura2()
    {
        ura2 = true;
    }
    public void Ura3()
    {
        ura3 = true;
    }

    void Update()
    {
        if(!isLoad && ura1&&ura2&&ura3)
        {
            SceneManager.LoadScene("Game_Ura");
        }
    }
}
