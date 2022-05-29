using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace A2.Scripts
{
    public class StateHandler : MonoBehaviour
    {
        [SerializeField] private GameObject template;
        [SerializeField] private GameObject activeGameObjectTitle;
        [SerializeField] private GameObject activeGameObjectBeforeCastle;
        [SerializeField] private GameObject activeGameObjectEntrance;
        [SerializeField] private GameObject activeGameObjectZombieRoom;
        [SerializeField] private GameObject activeGameObjectKitchen;
        [SerializeField] private GameObject activeGameObjectWall;
        [SerializeField] private GameObject activeGameObjectFinalRoom;

        [SerializeField] private TMP_Text textRoom;
        [SerializeField] private TMP_Text textFirstOption;
        [SerializeField] private TMP_Text textSecondOption;
        [SerializeField] private TMP_Text textThirdOption;
        [SerializeField] private TMP_Text textFourthOption;

        private GameState _gameState = GameState.BeforeCastle;

        private bool _silversword, _steelsword;
        private bool _gameStarted;

        private string[] _optionsBeforeCastle =
        {
            "You are the famous robot knight in search of the magic star. This is hidden in a castle, which is guarded by a dragon, which unfortunately has already discovered you. Now you are in front of the castle and you have to act quickly.",
            "You try to hide in a bush in front of the castle",
            "You try to get into the castle quickly", "", ""
        };

        private string[] _optionsEntrance =
        {
            "You just made it into the castle and quickly lock the door behind you. You now stand in the entrance hall with two doors and think about what you should do...",
            "You go into the right door",
            "You choose the left door",
            "You take a silver sword leaning against a statue",
            "You take a steel sword leaning against a statue"
        };

        private string[] _optionsEntrancePickedUp =
        {
            "You have picked up the sword and now you have to choose a door",
            "You go into the right door",
            "You choose the left door"
        };

        private string[] _optionsZombieRoom;

        private string[] _optionsWall =
        {
            "After killing the zombie with the silver sword, you will reach the castle walls at the end of the corridor. Here you can see the dragon still trying to find you. But you know that you have to get to the opposite tower.",
            "You attack the dragon, hoping to defeat it too with the silver sword",
            "You try to hide cleverly and get to the tower inconspicuously",
            "You jump down the castle wall to look for another way into the tower"
        };

        private string[] _optionsFinalRoom =
        {
            "You have reached the tower and right when you enter you see the magic star shining in front of you",
            "You take the star and wish to be home again",
            "You take the star and try to escape with it",
            "You jump from the tower in fear of the dragon"
        };

        private TextAdenture _textAdentureActions;

        private void Awake()
        {
            _textAdentureActions = new TextAdenture();
            _textAdentureActions.PlayerActionMap.anyKey.started += AnyKeyPressed;
            _textAdentureActions.PlayerActionMap.press1.started += c => {SwitchState(1); };
            _textAdentureActions.PlayerActionMap.press2.started += c => { SwitchState(2); };
            _textAdentureActions.PlayerActionMap.press3.started += c => { SwitchState(3); };
            _textAdentureActions.PlayerActionMap.press4.started += c => { SwitchState(4); };
        }

        private void AnyKeyPressed(InputAction.CallbackContext callbackContext)
        {
            if (_gameStarted) return;
            activeGameObjectTitle.SetActive(false);
            _gameState = GameState.BeforeCastle;
            template.SetActive(true);
            activeGameObjectBeforeCastle.SetActive(true);
            SetTexts(_optionsBeforeCastle);
            _gameStarted = true;
        }
        
        private void OnEnable()
        {
            _textAdentureActions.Enable();
        }

        // The gameloop is not finished due to time problems. Maybe this will be finished in a feature branch.
        // However, the principle should also become clear here, unfortunately it is not fully implemented
        private void SwitchState(int i)
        {
            if(!_gameStarted) return;
            switch (_gameState)
            {
                case GameState.BeforeCastle:
                    switch (i)
                    {
                        case 1:
                            _gameState = GameState.Death;
                            activeGameObjectBeforeCastle.SetActive(false);
                            Death();
                            break;
                        case 2:
                            _gameState = GameState.Entrance;
                            activeGameObjectBeforeCastle.SetActive(false);
                            activeGameObjectEntrance.SetActive(true);
                            SetTexts(_optionsEntrance);
                            break;
                    }
                    break;
                case GameState.Entrance:
                    switch (i)
                    {
                        case 1:
                            activeGameObjectEntrance.SetActive(false);
                            activeGameObjectZombieRoom.SetActive(true);
                            _gameState = GameState.ZombieRoom;
                            FillOptionsZombieRoom();
                            break;
                        case 2:
                            activeGameObjectEntrance.SetActive(false);
                            Death();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;
                case GameState.ZombieRoom:
                    switch (i)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;
                case GameState.Wall:
                    switch (i)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;
                case GameState.FinalRoom:
                    switch (i)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;
            }
        }

        private void Death()
        {
            //TODO Deathscreen
        }
        
        private void SetTexts(string[] options)
        {
            if (options.Length != 5) return;
            textRoom.text = options[0];
            textFirstOption.text = "(1) " + options[1];
            textSecondOption.text = "(2) " + options[2];
            textThirdOption.text = "(3) " + options[3];
            textFourthOption.text = "(4) " + options[4];
        }

        private void FillOptionsZombieRoom()
        {
            if (!_silversword && !_steelsword)
            {
                _optionsZombieRoom = new []
                {
                    "You enter a long hallway, but right in front of you is a zombie. Unfortunately, you don't have a weapon with you...",
                    "You try to fight the zombie with your hands",
                    "You try to run away",
                    "", ""
                };
            }
            else
            {
                _optionsZombieRoom = new []
                {
                    "You enter a long hallway, but right in front of you is a zombie. Good that you took a sword with you",
                    "You try to kill the zombie with the sword",
                    "You try to run away",
                    "", ""
                };
            }
        }
        
        private enum GameState
        {
            BeforeCastle,
            Entrance,
            EntrancePickedUp,
            ZombieRoom,
            Wall,
            FinalRoom,
            Death
        }
    }
}