using UnityEngine;

public class LifeKanri : MonoBehaviour
{
    public Tamakesi tamakesi;//lifeの値を持ってくる
    public GameObject hako_stpoer_Mizu;//箱を消す
    public GameObject life_Kara;//lifeが削れたと時用
    public GameObject playerIconPre;//HPのUIのアイコンのプレハブ
    public Camera game_camera;//HPがなくなった時用

    int beforeHP;//前回のHPを保持
    bool lifezero = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //HPの分だけ空のアイコンを生成
        for (int i = 0; i < tamakesi.life; ++i)
        {
            CreateHPIcon(life_Kara, i);
        }
        //HPの分だけアイコンを生成
        for (int i = 0; i < tamakesi.life; ++i)
        {
            CreateHPIcon(playerIconPre, i);
        }

        beforeHP = tamakesi.life;//変化前のHPを保持
    }

    // Update is called once per frame
    void Update()
    {
        if (beforeHP != tamakesi.life)//lifeに変化があったら
        {
            if (tamakesi.life < beforeHP)//減ってたら
            {
                string kesuyatu = "life" + (beforeHP - 1);//消したいlifeの名前を指定
                GameObject life = GameObject.Find(kesuyatu);//指定したものを探す
                Destroy(life);//探したやつを消す
            }
            beforeHP = tamakesi.life;//保持するHPを更新
        }

        if (tamakesi.life <= 0)//lifeが０になったら
        {
            //ゲーム失敗
            if (lifezero == false)
            {
                //カメラを初期位置に戻す
                game_camera.transform.position = new Vector3(-5.6f, 6.7f, 0.1f);

                //ゲームオーバー音を鳴らす
                GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);

                Destroy(hako_stpoer_Mizu);
                lifezero = true;
            }
        }
    }

    void CreateHPIcon(GameObject lifePrefab, int hanasu)
    {
        //離していい感じに生成
        GameObject HPIcon = Instantiate(lifePrefab, transform);

        HPIcon.transform.localPosition = new Vector3(99.1f, 1.6f, 71.2f - (hanasu * 7));//*7が離す距離

        if (lifePrefab == playerIconPre)//生きてるlifeだけ名前を変える
        {
            HPIcon.name = "life" + hanasu;
        }
    }
}
