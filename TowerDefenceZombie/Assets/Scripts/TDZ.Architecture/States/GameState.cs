using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDZ.Architecture
{
    public class GameState : BaseState
    {
        public override void InitState()
        {
            Debug.Log("GAME STATE INIT");
        }

        public override void UpdateState()
        {
            
        }

        public override void DestroyState()
        {
            
        }
    } 
}
