using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace A3.Scripts
{
    public class PowerUpController : MonoBehaviour
    {

        [SerializeField] private float movementSpeed = 1f;

        private void Start()
        {
            transform.position = transform.position + new Vector3(0, Random.Range(5.5f, -3.7f), 0);
        }

        private void Update()
        {
            if (transform.position.x <= -10) Destroy(gameObject);
            transform.Translate(Time.deltaTime * -1 * movementSpeed, 0, 0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag("Player")) return;
            PlayerController.Instance.IsGodMode = true;
            Destroy(this.gameObject);
        }
    }
}