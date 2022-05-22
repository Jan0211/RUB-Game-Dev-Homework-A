using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace A1.Scripts
{
    [RequireComponent(typeof(Volume))]
    public class GlowHandler : MonoBehaviour
    {
        private Volume _volume;

        private void Awake()
        {
            _volume = GetComponent<Volume>();
        }

        public void ToggleGlow()
        {
            _volume.enabled = !_volume.enabled;
        }
    }
}