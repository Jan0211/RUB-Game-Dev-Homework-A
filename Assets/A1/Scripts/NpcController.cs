using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace A1.Scripts
{
    public class NpcController : MonoBehaviour
    {
        [SerializeField] private Sprite dogeSprite;
        
        private Animator _animator;
        private bool _isAnimated;
        private bool _isInDogeMode;
        private SpriteRenderer _spriteRenderer;

        private SquidgameHandler _squidgameHandler;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _animator = GetComponent<Animator>();
            _isAnimated = true;
        }

        private void Start()
        {
            _squidgameHandler = FindObjectOfType<SquidgameHandler>();
            StartCoroutine(PlayRandomAnimation());
        }

        public void StopAnimation()
        {
            _isAnimated = false;
        }

        private void Update()
        {
            if (_squidgameHandler.IsSquidgameRed && !_animator.GetCurrentAnimatorStateInfo(0).IsName("Wait"))
                StartCoroutine(Die());
        }

        private IEnumerator PlayRandomAnimation()
        {
            while (_isAnimated)
            {
                yield return new WaitForSeconds(Random.Range(1, 6));
                var id = Random.Range(1, 4);
                _animator.SetTrigger($"Dance{id}");
            }
        }

        public void Doge()
        {
            if (_isInDogeMode) return;
            _isInDogeMode = true;
            _spriteRenderer.sprite = dogeSprite;
            transform.parent.transform.Rotate(0, 0, 180);
        }

        private IEnumerator Die()
        {
            yield return new WaitForSeconds(1);
            Destroy(this.gameObject);
        }
        
    }
}
