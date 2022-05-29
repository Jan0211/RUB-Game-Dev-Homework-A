using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace A4.Scripts
{
    public class StudentController : MonoBehaviour
    {

        private Animator _animator;
        private bool _isRunning = true;
        private static readonly int Rot = Animator.StringToHash("rot");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            transform.position = new Vector3(Random.Range(2f, 8.6f), Random.Range(-4.6f, 4f), 0);
            StartCoroutine(Rotation());
        }

        private IEnumerator Rotation()
        {
            while (_isRunning)
            {
                yield return new WaitForSeconds(4);
                _animator.speed = Random.Range(0.1f, 1.2f);
                _animator.SetTrigger(Rot);
            }
        }
    }
}