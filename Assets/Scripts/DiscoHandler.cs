using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class DiscoHandler : MonoBehaviour
{
    [SerializeField] private Transform lightsHolder;
    [SerializeField] private GameObject[] lights;
    [SerializeField] private Transform player;
    [SerializeField] private Transform playerMoveable;
    [SerializeField] private float movementSpeed = 5.0f;

    private DiscoInputActions _inputActions;
    private SpriteRenderer _spriteRenderer;

    private Vector2 _moveDirection;
    private float _sprintSpeed = 1f;
    private bool _stealth;

    private Animator _animator;

    private void Awake()
    {
        _animator = player.GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _inputActions = new DiscoInputActions();
        _inputActions.DiscoInputMap.BackgroundColor.started += UpdateBackgroundColor;
        _inputActions.DiscoInputMap.SpawnNewLight.started += SpawnNewRandomLight;
        _inputActions.DiscoInputMap.Move.started += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Move.canceled += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Move.performed += UpdateMoveDirection;
        _inputActions.DiscoInputMap.Sprint.started += (_) => { _sprintSpeed = 1.25f; };
        _inputActions.DiscoInputMap.Sprint.canceled += (_) => { _sprintSpeed = 1f; };
        _inputActions.DiscoInputMap.Stealth.started += (_) =>
        {
            _stealth = !_stealth;
            player.GetComponent<SpriteRenderer>().color = _stealth ? new Color(1, 1, 1, 0.5f) : new Color(1, 1, 1, 1);
        };
        _inputActions.DiscoInputMap.ChangeSprite.started += (_) =>
        {
            player.GetComponent<SpriteChanger>().ChangeToRandomSprite();
        };

        _inputActions.DiscoInputMap.Dance1.started += (_) => { PerformDanceMove(1); };
        _inputActions.DiscoInputMap.Dance2.started += (_) => { PerformDanceMove(2); };
        _inputActions.DiscoInputMap.Dance3.started += (_) => { PerformDanceMove(3); };
    }

    private void OnEnable()
    {
        _inputActions.DiscoInputMap.Enable();
    }

    private void Update()
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Wait"))
        {
            if (_stealth) playerMoveable.Translate(_moveDirection * (Time.deltaTime * movementSpeed * 0.45f));
            else playerMoveable.Translate(_moveDirection * (Time.deltaTime * movementSpeed * _sprintSpeed));
        }
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

    private void PerformDanceMove(int i)
    {
        if (_stealth)
        {
            player.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            _stealth = !_stealth;
        }
        _animator.SetTrigger($"Dance{i}");
    }
    
}