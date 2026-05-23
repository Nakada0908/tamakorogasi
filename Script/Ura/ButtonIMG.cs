using UnityEngine;
using UnityEngine.UI;

public class ButtonIMG : MonoBehaviour
{
    public static bool s12clear;

    public Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image.enabled = false;

        if (s12clear)
        {
            image.enabled = true;
        }
    }
}
