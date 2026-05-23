using UnityEngine;

public class MagumaDamege : MonoBehaviour
{
    public GameObject gannseki;
    public float span = 1.0f;
    float delta = 0;

    public Tamakesi tamakesi;//lifeの値を持ってくる
    public Clone clone;//時間管理の値をいろいろ持ってくる

    public AudioSource audioSource;
    public AudioClip damageSE;// ダメージ用SE

    // Update is called once per frame
    void Update()
    {
        if (clone.delta>0) {
            this.delta += Time.deltaTime;
        }

        if (clone.TamaCnt < clone.TamaMax)//この間は生成する
        {
            if (this.delta > this.span)
            {
                this.delta = 0;//リセット

                GameObject go = Instantiate(gannseki);//生成するやつ
                float pz = Random.Range(-5.0f, 6.0f);//生成位置のランダム要素
                go.transform.position = new Vector3(30, 10, pz);//生成位置
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("gannseki"))
        {
            audioSource.PlayOneShot(damageSE);
            --tamakesi.life;
        }
    }
}
