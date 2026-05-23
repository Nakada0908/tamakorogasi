using UnityEngine;

public class GameSetting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        //ウィンドウサイズを決定できる
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);

        //フレームレートを60fpsに固定
        Application.targetFrameRate = 60;
    }
}
