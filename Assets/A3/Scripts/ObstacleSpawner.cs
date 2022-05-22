using System.Collections;
using UnityEngine;

namespace A3.Scripts
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject obsUp;
        [SerializeField] private GameObject obsDown;
        [SerializeField] private GameObject duck;
        [SerializeField] private GameObject powerUp;
        [SerializeField] private int spawnTime = 4;

        private bool _nextUp;
        private bool _isRunning;
        private int _obsCount;

        private void Start()
        {
            _isRunning = true;
            StartCoroutine(SpawnObstacles());
            StartCoroutine(SpawnPowerUps());
        }

        private IEnumerator SpawnPowerUps()
        {
            while (_isRunning)
            {
                yield return new WaitForSeconds(Random.Range(20, 40));
                Instantiate(powerUp, transform);
            }
        }
        
        private IEnumerator SpawnObstacles()
        {
            while (_isRunning)
            {
                yield return new WaitForSeconds(spawnTime);
                if (_obsCount >= 6)
                {
                    Instantiate(duck, transform);
                    _obsCount = 0;
                }
                else
                {
                    Instantiate(_nextUp ? obsUp : obsDown, this.transform);
                    _nextUp = !_nextUp;
                    _obsCount++;
                }
            }
        }

    }
}