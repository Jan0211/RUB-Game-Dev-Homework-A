using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace A3.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float jumpStrength = 1;
        
        private Rigidbody2D _rigidbody2D;
        private TappyPlane _tappyPlaneInputActions;
        private bool _isDead;
        
        private void Awake()
        {
            _tappyPlaneInputActions = new TappyPlane();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _tappyPlaneInputActions.PlaneController.Jump.started += Jump;
        }

        private void OnEnable()
        {
            _tappyPlaneInputActions.Enable();
        }

        private void Jump(InputAction.CallbackContext context)
        {
            if (_isDead) return;
            if(_rigidbody2D.velocity.y < 0) _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(Vector2.up * 10 * jumpStrength);
        }

        // ReSharper disable once UnusedParameter.Local
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (_isDead) return;
            _rigidbody2D.constraints = RigidbodyConstraints2D.None;
            _rigidbody2D.AddTorque(0.1f, ForceMode2D.Impulse);
            _isDead = true;
            StartCoroutine(ReloadGame());
        }

        private IEnumerator ReloadGame()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("A3");
        }
    }
}