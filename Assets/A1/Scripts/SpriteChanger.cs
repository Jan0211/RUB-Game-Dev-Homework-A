using UnityEngine;
using Random = UnityEngine.Random;

namespace A1.Scripts
{
    public class SpriteChanger : MonoBehaviour
    {
        [SerializeField] private Sprite[] changingOptions;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void ChangeToRandomSprite()
        {
            var chosenSprite = _spriteRenderer.sprite;
            while(chosenSprite == _spriteRenderer.sprite) _spriteRenderer.sprite = changingOptions[Random.Range(0, changingOptions.Length)];
        }
    }
}