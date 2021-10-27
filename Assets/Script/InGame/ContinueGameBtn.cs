using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame
{
    public class ContinueGameBtn : MonoBehaviour
    {
        public GameObject pause_menu;

        public void OnClick()
        {
            pause_menu.SetActive(false);
        }
    }

}
