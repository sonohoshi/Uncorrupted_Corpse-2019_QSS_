using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    public float speed = 0.125f;

    void Awake()
    {
        transform.position = new Vector2( target.position.x, target.position.y);
    }
    
    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.position, speed);
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, -12f);
        }
    }
}
