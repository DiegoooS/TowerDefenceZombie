using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDZ.Architecture
{
    public class GameController : MonoBehaviour
    {
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
            gameState = new GameState();
            menuState = new MenuState();
        }
    }

}