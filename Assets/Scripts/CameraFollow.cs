using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;

    private void Update()
    {
        var moveDirection = (Vector2)(targetToFollow.position - transform.position);
        if (moveDirection.magnitude > 0.2f)
        {
            transform.Translate(moveDirection * (Time.deltaTime * 1.5f));
        }
    }
}