using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class NPCController : MonoBehaviour
{
    private Animator _animator;
    private bool _isAnimated;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _isAnimated = true;
    }

    private void Start()
    {
        StartCoroutine(PlayRandomAnimation());
    }

    public void StopAnimation()
    {
        _isAnimated = false;
    }
    
    private IEnumerator PlayRandomAnimation()
    {
        while (_isAnimated)
        {
            yield return new WaitForSeconds(Random.Range(1, 6));
            int id = Random.Range(1, 4);
            _animator.SetTrigger($"Dance{id}");
        }
    }

}
