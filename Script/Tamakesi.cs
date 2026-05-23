using UnityEngine;

public class Tamakesi : MonoBehaviour
{
    //life管理用
    public int life = 3;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Tama_Mizu") || col.CompareTag("Tama_Red")
         || col.CompareTag("Tama_Blue") || col.CompareTag("Tama_Green")  )
        {
            TamaKesi(col.gameObject);
        }
        if (col.CompareTag("gannseki"))
        {
            Destroy(col.gameObject); 
        }
    }

    void TamaKesi(GameObject tama)
    {
        --life;//ライフを削る
        if (life>0) { 
            GetComponent<AudioSource>().Play();//ダメージ音
        }
        Destroy(tama);//玉を消す
    }
}
