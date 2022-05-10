using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class DiscoHandler : MonoBehaviour
{
    [SerializeField] private Transform lightsHolder;
    [SerializeField] private GameObject[] lights;
    [SerializeField] private Transform player;
    [SerializeField] private float movementSpeed = 5.0f;

    private DiscoInputActions _inputActions;
    private SpriteRenderer _spriteRenderer;

    private Vector2 _moveDirection;
    private float _sprintSpeed = 1f;
    private bool _stealth;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _inputActions = new DiscoInputActions();
        _inputActions.DiscoInputMap.BackgroundColor.started += UpdateBackgroundColor;
        _inputActions.DiscoInputMap.SpawnNewLight.started += SpawnNewRandomLight;
        _inputActions.DiscoInputMap.Move.started += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Move.canceled += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Move.performed += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Sprint.started += (context) => { _sprintSpeed = 1.25f; };
        _inputActions.DiscoInputMap.Sprint.canceled += (context) => { _sprintSpeed = 1f; };
        _inputActions.DiscoInputMap.Stealth.started += context =>
        {
            _stealth = !_stealth;
            if(_stealth) player.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
            else player.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        };
        _inputActions.DiscoInputMap.ChangeSprite.started += context =>
        {
            player.GetComponent<SpriteChanger>().ChangeToRandomSprite();
        };
    }

    private void OnEnable()
    {
        _inputActions.DiscoInputMap.Enable();
    }

    private void Update()
    {
        if (_stealth) player.Translate(_moveDirection * (Time.deltaTime * movementSpeed * 0.45f));
        else player.Translate(_moveDirection * (Time.deltaTime * movementSpeed * _sprintSpeed));
    }

    private void UpdateBackgroundColor(InputAction.CallbackContext context)
    {
        var axis = context.ReadValue<float>();
        var spriteRendererColor = _spriteRenderer.color;
        if (axis > 0 && spriteRendererColor.r <= 0.9f)
            _spriteRenderer.color = new Color(spriteRendererColor.r + 0.1f, spriteRendererColor.g + 0.1f,
                spriteRendererColor.g + 0.1f, 1);
        else if (axis < 0 && spriteRendererColor.r >= 0.1f)
            _spriteRenderer.color = new Color(spriteRendererColor.r - 0.1f, spriteRendererColor.g - 0.1f,
                spriteRendererColor.g - 0.1f, 1);
    }

    private void SpawnNewRandomLight(InputAction.CallbackContext context)
    {
        var pos = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0);
        Instantiate(lights[Random.Range(0, lights.Length)], pos, Quaternion.identity).transform.SetParent(lightsHolder);
    }

    private void UpdateMoveDirection(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
    }
}