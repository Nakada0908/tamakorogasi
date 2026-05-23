using UnityEngine;

public class MagumaDamege_S12 : MonoBehaviour
{
    public GameObject gannseki;
    float span = 1.0f;
    float delta = 0;//たまの出現頻度用
    float deltaspanspeed = 0;//スパンの速さ変更用

    public Tamakesi tamakesi;//lifeの値を持ってくる
    public Clone clone;//時間管理の値をいろいろ持ってくる

    public AudioSource audioSource;
    public AudioClip damageSE;// ダメージ用SE

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        span = 1.5f;//初期は遅め
    }

    // Update is called once per frame
    void Update()
    {
        if (clone.delta > 0)
        {
            this.delta += Time.deltaTime;
            this.deltaspanspeed += Time.deltaTime;
        }

        if (this.deltaspanspeed > 5 && this.deltaspanspeed < 5.5f)
        {
            span = 0.7f;//岩石の生成速度上昇
        }
        if (this.deltaspanspeed > 15)
        {
            span = 1.5f;//岩石の生成速度低下
            deltaspanspeed = 0;
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
