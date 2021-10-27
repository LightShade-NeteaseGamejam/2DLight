using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLightControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light2D>().intensity = Mathf.Lerp(GetComponent<Light2D>().intensity, 0.4f + DataStorage.emotion_state * 0.3f, Time.deltaTime);
    }
}
