using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while(isActiveAndEnabled)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
            yield return new WaitForSeconds((Random.value * 3) + 2);
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
