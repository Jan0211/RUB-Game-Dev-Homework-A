using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityTools.General;

namespace A3.Scripts
{
    public class PlayerController : UnitySingleton<PlayerController>
    {
        [SerializeField] private float jumpStrength = 1;
        
        private Rigidbody2D _rigidbody2D;
        private TappyPlane _tappyPlaneInputActions;
        public bool IsDead { get; private set; }

        protected override void Awake()
        {
            base.Awake();
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
            if (IsDead) return;
            if(_rigidbody2D.velocity.y < 0) _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(Vector2.up * 10 * jumpStrength);
        }
        
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (IsDead) return;
            if (!col.gameObject.CompareTag("KillPlayer")) return;
            _rigidbody2D.constraints = RigidbodyConstraints2D.None;
            _rigidbody2D.AddTorque(0.1f, ForceMode2D.Impulse);
            IsDead = true;
            StartCoroutine(ReloadGame());
        }

        private IEnumerator ReloadGame()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("A3");
        }
    }
}