using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToNextLevel : MonoBehaviour
{
    public LevelLoader levelLoader;
    public void OnTriggerStay2D(Collider2D collision)
    {
        levelLoader.LoadNextLevel();
    }
}
