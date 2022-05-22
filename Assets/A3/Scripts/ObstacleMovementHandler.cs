using UnityEngine;

namespace A3.Scripts
{
    public class ObstacleMovementHandler : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 1f;

        private bool _scoreUpdated = false;
        
        private void Update()
        {
            if(transform.position.x <= -10) Destroy(this.gameObject);
            if (transform.position.x <= -5.22f && !PlayerController.Instance.IsDead && !_scoreUpdated)
            {
                ScoreManager.Instance.Score++;
                _scoreUpdated = true;
            }
            transform.Translate(Time.deltaTime * -1 * movementSpeed, 0, 0);
        }
    }
}