using System.Collections.Generic;
using UnityEngine;

namespace A1.Scripts
{
    public class NpcCollectionHandler : MonoBehaviour
    {
        private List<NpcController> _controllers;

        private void Awake()
        {
            _controllers = new List<NpcController>();
        }

        private void Start()
        {
            _controllers.AddRange(FindObjectsOfType<NpcController>());
        }

        public void Doge()
        {
            foreach (var c in _controllers) c.Doge();
        }

        public void Maximize()
        {
            foreach (var c in _controllers)
            {
                c.transform.parent.transform.localScale = new Vector3(2, 2, 2);
            }
        }
        
    }
}