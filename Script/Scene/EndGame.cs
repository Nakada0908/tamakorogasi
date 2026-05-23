using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//エンターキーを押したら
        {
            ButtonIMG.s12clear = true;

            //次のゲームシーンに移動する
            SceneManager.LoadScene("TitleScene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))//エスケープキーを押したら
        {
            Application.Quit();//ゲームプレイ終了
        }
    }
}
