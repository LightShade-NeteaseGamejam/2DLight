using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame
{
    public class EmotionBarControl : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            GetComponent<RectTransform>().sizeDelta = Vector2.Lerp(GetComponent<RectTransform>().sizeDelta, new Vector2(280 * DataStorage.emotion_state, 70), Time.deltaTime);
        }
    }
}

