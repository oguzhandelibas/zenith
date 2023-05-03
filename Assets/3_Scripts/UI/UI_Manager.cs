using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenith.Enums;

namespace Zenith.UI
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private UI_Panel_Data uI_Panel_Data;

        public void PanelActiveness(MainPanels mainPanels)
        {
            
        }

        public void PanelActiveness(PopUpPanels popUpPanels)
        {

        }

    }
}

