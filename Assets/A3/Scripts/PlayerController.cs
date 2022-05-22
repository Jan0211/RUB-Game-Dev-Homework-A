using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityTools.General;

namespace A3.Scripts
{
    public class PlayerController : UnitySingleton<PlayerController>
    {
        [SerializeField] private float jumpStrength = 1;
        [SerializeField] private TMP_Text powerUpText;

        private const string PowerUpText = "PowerUpTime: ";
        
        private Rigidbody2D _rigidbody2D;
        private TappyPlane _tappyPlaneInputActions;
        public bool IsDead { get; private set; }

        private bool _isGodMode;
        
        public bool IsGodMode
        {
            get => _isGodMode;
            set
            {
                if (value) StartCoroutine(DeactivateGodMode());
                _isGodMode = value;
            }
        }

        private IEnumerator DeactivateGodMode()
        {
            var tmp = 10;
            while (tmp > 0)
            {
                powerUpText.text = PowerUpText + tmp.ToString();
                yield return new WaitForSeconds(1);
                tmp--;
            }
            powerUpText.text = PowerUpText + "0";
            IsGodMode = false;
        }
        
        protected override void Awake()
        {
            base.Awake();
            _tappyPlaneInputActions = new TappyPlane();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            powerUpText.text = PowerUpText + "0";
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

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (_isGodMode) return;
            if (IsDead) return;
            if (!col.gameObject.CompareTag("KillPlayer")) return;
            _rigidbody2D.constraints = RigidbodyConstraints2D.None;
            _rigidbody2D.AddTorque(0.1f, ForceMode2D.Impulse);
            IsDead = true;
            StartCoroutine(ReloadGame());
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