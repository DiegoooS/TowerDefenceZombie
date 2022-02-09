using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TDZ.UI;

namespace TDZ.Architecture
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] GameView gameView;
        [SerializeField] MenuView menuView;

        private GameState gameState;
        private MenuState menuState;
        private BaseState currentlyActiveState;

        private void Start()
        {
            CreateStates();
            SetCurrentState(menuState);
        }

        private void Update()
        {
            currentlyActiveState.UpdateState();
        }

        private void OnDestroy()
        {
            currentlyActiveState.DestroyState();
        }

        private void SetCurrentState(BaseState newState)
        {
            currentlyActiveState?.DestroyState();
            currentlyActiveState = newState;
            currentlyActiveState.InitState();
        }

        private void CreateStates()
        {
            gameState = new GameState(gameView);
            menuState = new MenuState(menuView);
        }
    }

}