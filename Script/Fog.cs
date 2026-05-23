using UnityEngine;

public class Fog : MonoBehaviour
{
    public Light directionalLight;//ライトを入れる
    public Material skybox_defo;
    public Material skybox_yoru;

    public float fogspan = 7;//7秒ごとにフォグのオンオフ
    float delta = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderSettings.fog = false;
        directionalLight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //めっちゃ処理されるから0.5秒間のみやるようにしましょ
        if (this.delta > fogspan && this.delta < fogspan+0.5f)//7～7.5の間
        {
            FogChangeOn();
        }
        if (this.delta > fogspan*2)//切り替え前と後の時間を同じくらいにする
        {
            delta = 0;
            FogChangeOff();
        }
    }

    void FogChangeOn()
    {
        directionalLight.enabled = false;//ライトを消す
        RenderSettings.fog = true;//フォグをつける
        RenderSettings.fogColor = Color.black;//フォグの色
        RenderSettings.fogDensity = 0.08f;//フォグの強さ
        RenderSettings.skybox = skybox_yoru;//スカイボックスを変える
    }
    void FogChangeOff()
    {
        directionalLight.enabled = true;//ライトをつける
        RenderSettings.fog = false;//フォグを消す
        RenderSettings.skybox = skybox_defo;//デフォのやつに戻す
    }
}
