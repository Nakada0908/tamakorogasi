using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 7.0f;//遅れる度合い
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void Update()
    {
        if (target == null)//ターゲットがいなくなったら
        {
            return;//何もしない
        }

        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(
            transform.position,
            targetCamPos,
            Time.deltaTime * smoothing
        );
    }
}

