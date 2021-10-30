using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeEmotion : MonoBehaviour
{
    public float value;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && DataStorage.emotion_state + value <= 1 && DataStorage.is_side_view)
        {
            DataStorage.emotion_state += value;
        }
    }
}
