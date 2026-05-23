using TMPro;
using UnityEngine;

public class TMPStyle : MonoBehaviour
{
    public float outlineWidth = 1.0f;
    public Color outlineColor = Color.black;

    private TMP_Text tmp;

    void Awake()
    {
        tmp = GetComponent<TMP_Text>();

        // 縁取りを設定
        tmp.outlineWidth = outlineWidth;
        tmp.outlineColor = outlineColor;

        // 文字色はタグで変更可能
        tmp.text = "<color=#FFFFFF>１キー：</color><color=#B4E9FF>水色</color>\n" +
                   "<color=#FFFFFF>２キー：</color><color=#FF0000>赤色</color>\n" +
                   "<color=#FFFFFF>３キー：</color><color=#0000FF>青色</color>\n" +
                   "<color=#FFFFFF>４キー：</color><color=#00FF00>緑色</color>";
    }
}
