using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace A1.Scripts
{
    public class SquidgameHandler : MonoBehaviour
    {
        
        public bool IsSquidgameRed { get; private set; }
        
        private List<LightChanger> _lightChangers;
        private bool _isSquidgameActive;

        private void Awake()
        {
            _lightChangers = new List<LightChanger>();
        }

        public void StartSquidGame()
        {
            _lightChangers.AddRange(FindObjectsOfType<LightChanger>());
            foreach (var lc in _lightChangers) lc.StopAllCoroutines();
            _isSquidgameActive = true;
            StartCoroutine(ChangeLights());
        }

        private IEnumerator ChangeLights()
        {
            while (_isSquidgameActive)
            {
                IsSquidgameRed = false;
                foreach (var lc in _lightChangers) lc.GetComponent<SpriteRenderer>().color = Color.green;
                yield return new WaitForSeconds(Random.Range(3, 5));
                foreach (var lc in _lightChangers) lc.GetComponent<SpriteRenderer>().color = Color.red;
                IsSquidgameRed = true;
                yield return new WaitForSeconds(Random.Range(1, 3));
            }
        }
        
    }
}