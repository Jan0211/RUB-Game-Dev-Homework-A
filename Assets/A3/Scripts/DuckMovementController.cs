using UnityEngine;

namespace A3.Scripts
{
    public class DuckMovementController : MonoBehaviour
    {
        [SerializeField] private float offset1;
        [SerializeField] private float offset2;
        [SerializeField] private float movementSpeed = 1f;
        [SerializeField] private float movementSpeedUpDown = 3f;

        private bool _moveDown;
        private float _y1, _y2;
        private float _randomUpDownSpeed;
        
        private void Start()
        {
            _randomUpDownSpeed = movementSpeedUpDown + Random.Range(-1.5f, 1.5f);
            var position = transform.position;
            _y1 = position.y + offset1;
            _y2 = position.y + offset2;
        }

        private void Update()
        {
            if (transform.position.x <= -10) Destroy(gameObject);
            if (transform.position.y <= _y2 && _moveDown) _moveDown = false;
            if (transform.position.y >= _y1 && !_moveDown) _moveDown = true;
            var movement = new Vector3(Time.deltaTime * -1 * movementSpeed,
                _moveDown ? Time.deltaTime * -1 * _randomUpDownSpeed : Time.deltaTime * _randomUpDownSpeed, 0);
            transform.Translate(movement);
        }

        private void OnDrawGizmos()
        {
            var position = transform.position;
            var pos1 = position + new Vector3(0, offset1, 0);
            var pos2 = position + new Vector3(0, offset2, 0);
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(pos1, 0.1f);
            Gizmos.DrawSphere(pos2, 0.1f);
            Gizmos.DrawLine(pos1, pos2);
        }
    }
}