using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StartMenu
{
    public class ContinueGameBtn : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            if (DataStorage.progress == "")
            {
                gameObject.SetActive(false);
            }
        }

        public void OnClick()
        {
            SceneManager.LoadSceneAsync(DataStorage.progress);
        }
    }
}

