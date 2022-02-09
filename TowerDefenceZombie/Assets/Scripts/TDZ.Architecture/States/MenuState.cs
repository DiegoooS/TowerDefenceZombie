using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TDZ.UI;

namespace TDZ.Architecture
{
    public class MenuState : BaseState
    {
        private MenuView menuView;

        public MenuState(MenuView menuView)
        {
            this.menuView = menuView;
        }

        public override void InitState()
        {
            menuView?.ShowView();
        }

        public override void UpdateState()
        {
            
        }

        public override void DestroyState()
        {
            menuView?.HideView();
        }
    } 
}
