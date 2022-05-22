using UnityEngine;

namespace A3.Scripts
{
    public class ObstacleMovementHandler : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 1f;
        private void Update()
        {
            if(transform.position.x <= -10) Destroy(this.gameObject);
            transform.Translate(Time.deltaTime * -1 * movementSpeed, 0, 0);
        }
    }
}