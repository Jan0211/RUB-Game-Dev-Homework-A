using UnityEngine;

namespace A1.Scripts
{
    public class LockdownHandler : MonoBehaviour
    {
        [SerializeField] private GameObject lockdownAnimalPrefab;
        [SerializeField] private Transform cameraTransform;

        private Transform _lockdownAnimalTransform;
        
        private bool _isRunning;
        
        private void Update()
        {
            if (!_isRunning) return;
            _lockdownAnimalTransform.Translate(Time.deltaTime * 3, 0, 0);
            if (_lockdownAnimalTransform.position.x - cameraTransform.position.x < 10) return;
            Destroy(_lockdownAnimalTransform.gameObject);
            _isRunning = false;
        }

        public void StartLockdown()
        {
            if (_isRunning) return;
            var position = cameraTransform.position;
            _lockdownAnimalTransform = Instantiate(lockdownAnimalPrefab, new Vector3(position.x - 10, position.y, 0),
                Quaternion.identity).transform;
            _isRunning = true;
        }
        
    }
}