using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoScene : MonoBehaviour
{
    public void OnClick(string scene_name)
    {
        SceneManager.LoadSceneAsync(scene_name);
    }
}
