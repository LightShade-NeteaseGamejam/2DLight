using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloatingLight : MonoBehaviour
{
    public Transform player;
    public Vector3 delta_pos;

    // Start is called before the first frame update
    void Start()
    {
        delta_pos = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + delta_pos, Time.deltaTime * 3);

    }
}
