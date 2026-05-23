using UnityEngine;

public class Move_Hako : MonoBehaviour
{
    public float speedZ = 7.0f; // 左右 (Z軸)
    private Vector3 pos;

    void Update()
    {
        //矢印キー ←→AD で左右(Z軸)
        float translationZ = -Input.GetAxis("Horizontal") * speedZ;

        translationZ *= Time.deltaTime;

        //移動処理
        transform.Translate(0, 0, translationZ);  // Z軸が左右

        Clamp();
    }

    void Clamp()
    {
        pos = transform.position;
        pos.z = Mathf.Clamp(pos.z, -6.5f, 6.5f); // 左右の制限と移動を可能に
        transform.position = pos;
    }
}
