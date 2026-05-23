using UnityEngine;
using UnityEngine.UI;

public class Clone : MonoBehaviour
{
    //オブジェクト
    public GameObject Tama_Mizu;
    public GameObject Tama_Red;
    public GameObject Tama_Blue;
    public GameObject Tama_Green;

    public Image Setumei;

    //クローン
    public float span = 2.5f;
    public float delta = -60.0f;//初期値をマイナスにして、その間にゲームルールの説明を表示する
    public int TamaCnt = 0;
    public int TamaMax = 10;
    public int Color = 4;//簡単に変更できるように
    enum TamaColor
    {
        Mizu,   // 0
        Red,    // 1
        Blue,   // 2
        Green   // 3
    }

    //リザルト画面
    public Tamakesi tamakesi;//lifeの値を持ってくる
    bool result = false;
    public bool result_seikou = false;//成功時に使用
    public bool result_sippai = false;//ゲームオーバー時に使用
    public Camera game_camera;//ゲーム用のカメラ
    public Camera result_camera;//リザルト用のカメラ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //日付からシード値変えてよりランダムに
        Random.InitState(System.DateTime.Now.Millisecond);

        //ゲーム用のカメラをON、リザルト用のカメラをOFF
        game_camera.enabled = true;
        result_camera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Return))//エンターキーを押したら
        {
            if (this.delta < 0)//0以下の時
            {
                float span1 = span - 1;//たま出現1秒前に画像を消すため
                //deltaを0.1にして、説明の画像をほぼスキップする
                this.delta = span1;
                Destroy(Setumei);
            }
        }

        //玉のクローン生成
        if (TamaCnt < TamaMax)//この間は生成する
        {
            //通常のたま生成
            if (this.delta > this.span)
            {
                this.delta = 0;//リセット
                int Tama_Kettei = Random.Range(0, Color);//色の決定

                if (Tama_Kettei == (int)TamaColor.Mizu)//水色
                {
                    ++TamaCnt;
                    Create_Tama(Tama_Mizu);//玉の生成
                }
                if (Tama_Kettei == (int)TamaColor.Red)//赤色
                {
                    ++TamaCnt;
                    Create_Tama(Tama_Red);
                }
                if (Tama_Kettei == (int)TamaColor.Blue)//青色
                {
                    ++TamaCnt;
                    Create_Tama(Tama_Blue);
                }
                if (Tama_Kettei == (int)TamaColor.Green)//緑色
                {
                    ++TamaCnt;
                    Create_Tama(Tama_Green);
                }
            }
        }
        else
        {
            if (tamakesi.life > 0)//生きていたら
            {
                if (result == false)
                {
                    string lastTamaName = "tama" + TamaMax ; // 最後の玉の名前
                    GameObject lastTama = GameObject.Find(lastTamaName); // 探す
                    if (lastTama == null)//最後の玉が消えたら
                    {
                        //２秒後にリザルト画面に切り替え
                        Invoke("Result", 2.0f);

                        result = true;
                        result_seikou = true;
                    }
                }
            }
        }

        if (tamakesi.life <= 0)//失敗したら
        {
            if (result == false)
            {
                Invoke("Result", 2.0f);
                result = true;
                result_sippai = true;
            }
        }
    }

    void Create_Tama(GameObject tama)
    {
        GameObject go = Instantiate(tama);//生成するやつ
        float pz = Random.Range(-5.0f, 6.0f);//生成位置のランダム要素
        go.transform.position = new Vector3(30, 10, pz);//生成位置
        go.name = "tama" + TamaCnt;//各たまにナンバリングする
    }

    void Result()
    {
        //カメラのON/OFFを切り替える
        game_camera.enabled = false;
        result_camera.enabled = true;
    }
}
