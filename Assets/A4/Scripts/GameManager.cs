using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace A4.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text textLevelClick;
        [SerializeField] private TMP_Text textLevelStudent;
        [SerializeField] private TMP_Text textLevelScientist;

        [SerializeField] private TMP_Text textCostClick;
        [SerializeField] private TMP_Text textCostStudent;
        [SerializeField] private TMP_Text textCostScientist;

        [SerializeField] private TMP_Text textMoney;
        [SerializeField] private TMP_Text textIncrease;
        
        [SerializeField] private TMP_Text textPlaytime;

        [SerializeField] private GameObject spawnText;
        
        private int _currentMoney;

        private int _totalPlaytime;
        
        private int _currentIncrease = 1, _currentIncreaseOverTime = 0;
        private int _levelClick = 0, _levelStudent = 0, _levelScientist = 0;

        private bool _isRunning = true;
        
        private void Start()
        {
            UpdateUI();
            StartCoroutine(TimeProgress());
        }

        public void IncreaseClick()
        {
            _currentMoney += _currentIncrease;
            if (Camera.main != null)
            {
                var pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                pos.z = 1;
                Instantiate(spawnText, pos, Quaternion.identity).transform.GetChild(0).GetComponent<TMP_Text>().text =
                    $"+{_currentIncrease}";
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            textLevelClick.text = _levelClick.ToString();
            textLevelStudent.text = _levelStudent.ToString();
            textLevelScientist.text = _levelScientist.ToString();

            var costClick = (int)(7 * Math.Pow(1.4f, _levelClick));
            textCostClick.text = $"Cost: {costClick}€";
            var costStudent = (int)(7 * Math.Pow(1.08f, _levelStudent));
            textCostStudent.text = $"Cost: {costStudent}€";
            var costScientist = (int)(7 * Math.Pow(1.08f, _levelScientist));
            textCostScientist.text = $"Cost: {costScientist}€";

            textMoney.text = $"{_currentMoney} €";
            textIncrease.text = $"+ {_currentIncreaseOverTime} € / Second";

            textPlaytime.text = $"Total Playtime: {_totalPlaytime}";
        }

        private IEnumerator TimeProgress()
        {
            while (_isRunning)
            {
                yield return new WaitForSeconds(1);
                _totalPlaytime++;
                _currentMoney += _currentIncreaseOverTime;
                UpdateUI();
            }
        }
        
    }
}