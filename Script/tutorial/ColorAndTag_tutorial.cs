using UnityEngine;

public class ColorAndTag_tutorial : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = new Color(0.737f, 0.914f, 1f);
            this.tag = "Hako_Mizu";
        }
    }
}
