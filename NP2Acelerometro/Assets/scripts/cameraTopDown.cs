using UnityEngine;

public class cameraTopDown : MonoBehaviour
{
    public Transform target;
    public float heigth = 15f;
    public float smooth = 8f;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position = target.position;
        offset.y = heigth;
    }


    void LateUpdate()
    {
        if (!target) return;

        Vector3 desiredPos = target.position + offset;
        desiredPos.y = heigth;

        transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * smooth);
    }
}
