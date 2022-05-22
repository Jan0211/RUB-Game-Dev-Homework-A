using TMPro;
using UnityEngine;
using UnityTools.General;

namespace A3.Scripts
{
    public class ScoreManager : UnitySingleton<ScoreManager>
    {
        [SerializeField] private TMP_Text text;

        private int _score;
        
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                UpdateScore();
            }
        }

        private void Start()
        {
            Score = 0;
        }

        private void UpdateScore()
        {
            text.text = $"Score: {_score}";
        }
    }
}