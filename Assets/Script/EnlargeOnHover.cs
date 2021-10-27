using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeOnHover : MonoBehaviour
{
    private Vector3 scale;

    private void Start()
    {
        scale = transform.localScale;
    }

    private void OnMouseOver()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, scale * 1.2f, Time.deltaTime);
    }

    private void OnMouseExit()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, scale, Time.deltaTime);
    }
}
