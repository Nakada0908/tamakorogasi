using UnityEngine;

public class ColorAndTag : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();//åªç›ÇÃÉ}ÉeÉäÉAÉãÇéÊìæ
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetColor(new Color(0.737f, 0.914f, 1f), "Hako_Mizu");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetColor(Color.red, "Hako_Red");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetColor(Color.blue, "Hako_Blue");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetColor(Color.green, "Hako_Green");
        }
    }

    void SetColor(Color color, string tagName)
    {
        meshRenderer.material.color = color;
        tag = tagName;
    }
}
