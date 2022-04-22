using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiscoHandler : MonoBehaviour
{
    [SerializeField] private Transform lightsHolder;
    [SerializeField] private GameObject[] lights;

    private DiscoInputActions inputActions;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        inputActions = new DiscoInputActions();
        inputActions.DiscoInputMap.BackgroundColor.started += UpdateBackgroundColor;
        inputActions.DiscoInputMap.SpawnNewLight.started += SpawnNewRandomLight;
    }

    private void OnEnable()
    {
        inputActions.DiscoInputMap.Enable();
    }

    private void UpdateBackgroundColor(InputAction.CallbackContext context)
    {
        var axis = context.ReadValue<float>();
        if(axis > 0 && spriteRenderer.color.r <= 0.9f) spriteRenderer.color = new Color(spriteRenderer.color.r + 0.1f, spriteRenderer.color.g + 0.1f, spriteRenderer.color.g + 0.1f, 1);
        else if(axis < 0 && spriteRenderer.color.r >= 0.1f) spriteRenderer.color = new Color(spriteRenderer.color.r - 0.1f, spriteRenderer.color.g - 0.1f, spriteRenderer.color.g - 0.1f, 1);
    }

    private void SpawnNewRandomLight(InputAction.CallbackContext context)
    {
        var pos = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0);
        Instantiate(lights[Random.Range(0, lights.Length)], pos, Quaternion.identity).transform.SetParent(lightsHolder);
    }

}
