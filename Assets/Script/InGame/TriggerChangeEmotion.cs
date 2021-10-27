using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeEmotion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DataStorage.emotion_state + 0.1f <= 1)
        {
            DataStorage.emotion_state += 0.1f;
        }
    }
}
