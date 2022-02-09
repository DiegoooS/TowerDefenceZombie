using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TDZ.UI;

namespace TDZ.Architecture
{
    public class GameState : BaseState
    {
        private GameView gameView;

        public GameState(GameView gameView)
        {
            this.gameView = gameView;
        }

        public override void InitState()
        {
            gameView?.ShowView();
        }

        public override void UpdateState()
        {
            
        }

        public override void DestroyState()
        {
            gameView?.HideView();
        }
    } 
}
