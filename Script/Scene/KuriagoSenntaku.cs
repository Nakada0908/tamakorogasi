using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KuriagoSenntaku : MonoBehaviour
{
    public Camera result_camera;
    public string nextSceneName = "Game_2";
    public Clone clone;
    public TextMeshProUGUI result;


    // Update is called once per frame
    void Update()
    {
        if (result_camera.enabled == true)
        {
            result.text = "      Enterで\n次のステージへ";

            if (clone.result_seikou == true)//成功時
            {
                if (Input.GetKeyDown(KeyCode.Return))//エンターキーを押したら
                {
                    //次のゲームシーンに移動する
                    SceneManager.LoadScene(nextSceneName);
                }
                if (Input.GetKeyDown(KeyCode.Escape))//エスケープキーを押したら
                {
                    //ステージセレクト画面に移動する
                    SceneManager.LoadScene("stage_select");
                }
            }

            if (clone.result_sippai == true)//失敗時
            {
                result.text = "Enterで\nリトライ";

                if (Input.GetKeyDown(KeyCode.Return))//エンターキーを押したら
                {
                    //現在のゲームシーンに再チャレンジする
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                if (Input.GetKeyDown(KeyCode.Escape))//エスケープキーを押したら
                {
                    //ステージセレクト画面に移動する
                    SceneManager.LoadScene("stage_select");
                }
            }
        }
    }
}
