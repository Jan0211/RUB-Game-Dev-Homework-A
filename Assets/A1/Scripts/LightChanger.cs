using System.Collections;
using UnityEngine;

namespace A1.Scripts
{
    public class LightChanger : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            StartCoroutine(ChangeColor());
        }

        private IEnumerator ChangeColor()
        {
            while(isActiveAndEnabled)
            {
                _spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
                yield return new WaitForSeconds((Random.value * 3) + 2);
            }
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }

    }
}
