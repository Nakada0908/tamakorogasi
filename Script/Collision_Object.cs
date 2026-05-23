using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Object : MonoBehaviour
{
    public GameObject Tama_Mizu;
    public GameObject Tama_Red;
    public GameObject Tama_Blue;
    public GameObject Tama_Green;

    public Text nowScore;
    int nowscore = 0;

    public TextMeshProUGUI resultScore;
    int resultscore = 0;

    public Camera result_camera;
    public Tamakesi tamakesi;//lifeの値を持ってくる


    void Update()
    {
        if (result_camera.enabled == true)
        {
            if (tamakesi.life > 0)//生きていたら
            {
               resultscore = nowscore;
               resultScore.text = "結果は " + resultscore + " 点です！";
            }
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Tama_Mizu") && CompareTag("Hako_Mizu") ||
            col.CompareTag("Tama_Red")  && CompareTag("Hako_Red")  ||
            col.CompareTag("Tama_Blue") && CompareTag("Hako_Blue") ||
            col.CompareTag("Tama_Green")&& CompareTag("Hako_Green")  )
        {
            AddScore(col.gameObject);
        }
    }

    void AddScore(GameObject tama)
    {
        GetComponent<AudioSource>().Play();//たまゲットの音
        ++nowscore;
        nowScore.text = "Score:" + nowscore;
        Destroy(tama);
    }
}