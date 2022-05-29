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

        [SerializeField] private GameObject student;
        [SerializeField] private GameObject scientist;

        [SerializeField] private DataHolder dataHolder;
        
        private int _currentMoney;

        private int _totalPlaytime;
        
        private int _currentIncrease = 1, _currentIncreaseOverTime;
        private int _levelClick, _levelStudent, _levelScientist;

        private bool _isRunning = true;
        
        private void Start()
        {
            if (PlayerPrefs.HasKey("PlayTime")) _totalPlaytime = PlayerPrefs.GetInt("PlayTime");
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
            
            textCostClick.text = $"Cost: {GetCurrentClickCost()}€";
            textCostStudent.text = $"Cost: {GetCurrentStudentCost()}€";
            textCostScientist.text = $"Cost: {GetCurrentScientistCost()}€";

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
                PlayerPrefs.SetInt("PlayTime", _totalPlaytime);
                PlayerPrefs.Save();
            }
        }

        public void UpgradeClick()
        {
            var cost = GetCurrentClickCost();
            if (_currentMoney < cost || _levelClick >= 50) return;
            _currentMoney -= cost;
            _levelClick++;
            _currentIncrease++;
            UpdateUI();
        }

        public void UpgradeStudent()
        {
            var cost = GetCurrentStudentCost();
            if (_currentMoney < cost || _levelStudent >= 50) return;
            _currentMoney -= cost;
            _levelStudent++;
            _currentIncreaseOverTime++;
            UpdateUI();
            Instantiate(student);
        }

        public void UpgradeScientist()
        {
            var cost = GetCurrentScientistCost();
            if (_currentMoney < cost || _levelScientist >= 50) return;
            _currentMoney -= cost;
            _levelScientist++;
            _currentIncreaseOverTime += 2;
            UpdateUI();
            Instantiate(scientist);
        }

        private int GetCurrentClickCost()
        {
            return (int) (dataHolder.baseCostClick * Math.Pow(dataHolder.multiplierClick, _levelClick));
        }

        private int GetCurrentStudentCost()
        {
            return (int)(dataHolder.baseCostStudent * Math.Pow(dataHolder.multiplierCharacter, _levelStudent));
        }

        private int GetCurrentScientistCost()
        {
            return (int)(dataHolder.baseCostScientist * Math.Pow(dataHolder.multiplierCharacter, _levelScientist));
        }

    }
}