using UnityEngine;
using Random = UnityEngine.Random;

namespace A4.Scripts
{
    public class ScientistController : MonoBehaviour
    {

        private int _movementSpeed = 1;
        
        private void Start()
        {
            transform.position = new Vector3(Random.Range(2f, 8.6f), Random.Range(-4.6f, 4f), 0);
        }
        
        private void Update()
        {
            transform.Translate(Vector3.right * (Time.deltaTime * _movementSpeed));
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            var look = new Vector3(Random.Range(2.78f, 7.72f), Random.Range(-3.56f, 3.32f), 0);
            var transf = transform;
            transf.right = look - transf.position;
        }
    }
}