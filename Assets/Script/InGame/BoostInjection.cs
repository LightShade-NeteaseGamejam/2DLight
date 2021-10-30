using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostInjection : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!DataStorage.is_side_view)
        {
            float temp = DataStorage.emotion_state += 0.3f;
            if (temp >= 1)
            {
                DataStorage.emotion_state = 1;
            }
            else
            {
                DataStorage.emotion_state = temp;
            }
            Destroy(gameObject);
        }
        
    }
}
