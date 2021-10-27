using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    public Vector3 delta_pos;

    public bool is_side_view;

    // Start is called before the first frame update
    void Start()
    {
        delta_pos = transform.position - player.position;
        is_side_view = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_side_view)
        {
            transform.position = player.position + delta_pos;

        }
        else
        {
            transform.position = player.position + delta_pos + new Vector3(0, 20, 0);

        }

    }
}
