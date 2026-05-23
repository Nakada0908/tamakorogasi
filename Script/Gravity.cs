using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Vector3 sceneGravity = new Vector3(0, -3.0f, 0);
    //Y軸で重力を軽くしてふわっと
    //X軸をマイナスでたま加速
    //Z軸でたまを左右に転がす

    void Awake()
    {
        Physics.gravity = sceneGravity;
    }
}
