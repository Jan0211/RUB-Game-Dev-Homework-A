using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace A1.Scripts
{
    public class CheatCodeHandler : MonoBehaviour
    {
        [SerializeField]private UnityEvent doge;
        [SerializeField]private UnityEvent lockdown;
        [SerializeField]private UnityEvent squidgame;
        [SerializeField]private UnityEvent glow;
        [SerializeField]private UnityEvent max;

        private StringBuilder _stringBuilder;

        private void Awake()
        {
            _stringBuilder = new StringBuilder(50);
        }

        private void OnEnable()
        {
            Keyboard.current.onTextInput += NewKeyInputListener;
        }
        
        private void OnDisable()
        {
            Keyboard.current.onTextInput -= NewKeyInputListener;
        }

        private void NewKeyInputListener(char c)
        {
            UpdateStringAndPerformAction(c.ToString());
        }

        private void UpdateStringAndPerformAction(string newInput)
        {
            _stringBuilder.Append(newInput);
            if (_stringBuilder.Length > 30)
            {
                _stringBuilder.Remove(0, _stringBuilder.Length - 30);
            }

            var tmp = _stringBuilder.ToString().ToUpper();
            
            if (tmp.EndsWith("DOGE")) doge.Invoke();
            else if (tmp.EndsWith("LOCKDOWN")) lockdown.Invoke();
            else if (tmp.EndsWith("SQUIDGAME")) squidgame.Invoke();
            else if (tmp.EndsWith("GLOW")) glow.Invoke();
            else if (tmp.EndsWith("MAX")) max.Invoke();
        }

    }
}