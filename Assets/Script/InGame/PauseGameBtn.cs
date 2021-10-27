using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame
{
    public class PauseGameBtn : MonoBehaviour
    {

        public GameObject pause_menu;

        public void OnClick()
        {
            pause_menu.SetActive(!pause_menu.activeSelf);
        }
    }
}

