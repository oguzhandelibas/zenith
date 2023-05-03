using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenith.UI
{
    [CreateAssetMenu(fileName = "UI_Panel_Data", menuName = "UIData/PanelData", order = 0)]
    public class UI_Panel_Data : ScriptableObject
    {
        [SerializeField] private GameObject panelCanvas;
        [SerializeField] private GameObject panelParent;

        [Header("Main Panels")]
        [SerializeField] private GameObject WELCOME;
        [SerializeField] private GameObject WELCOME_LOADING;
        [SerializeField] private GameObject LOBBY;

        [Header("Pop-Up Panels")]
        [SerializeField] private GameObject LOGIN;
        [SerializeField] private GameObject SIGNUP;
        [SerializeField] private GameObject ERROR_NETWORK;
    }
}
