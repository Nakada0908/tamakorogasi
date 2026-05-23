using UnityEngine;

public class kurezitto : MonoBehaviour
{
    public GameObject Kurezitto;

    int cnt = 0;

    public void Start()
    {
        Kurezitto.SetActive (false);
    }

    public void OnButtonClick()
    {
        cnt++;

        if (cnt % 2 == 1)
        {
            Kurezitto.SetActive(true);
        }
        else
        {
            Kurezitto.SetActive(false);
        }
    }
}
