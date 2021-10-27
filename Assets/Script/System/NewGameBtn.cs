using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StartMenu
{
    public class NewGameBtn : MonoBehaviour
    {
        public void OnClick()
        {
            DataStorage.progress = "Level01";
            SceneManager.LoadSceneAsync("Level01");
        }
    }
}

