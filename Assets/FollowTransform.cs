using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}