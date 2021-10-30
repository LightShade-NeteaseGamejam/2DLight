using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public string tag;
    public float distance_up;
    public float distance_down;
    public float distance_left;
    public float distance_right;

    // Start is called before the first frame update
    void Start()
    {
        distance_up = 0;
        distance_down = 0;
        distance_left = 0;
        distance_right = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance_up = GetDistance(Vector2.up);
        distance_down = GetDistance(Vector2.down);
        distance_left = GetDistance(Vector2.left);
        distance_right = GetDistance(Vector2.right);
    }

    private float GetDistance(Vector2 direction)
    {
        RaycastHit2D[] results = new RaycastHit2D[16];
        int count = GetComponent<Rigidbody2D>().Cast(direction, results, 5);
        float min_distance = 5;
        for (int i = 0; i < count; i++)
        {
            if (results[i].distance < min_distance & results[i].transform.tag == tag)
            {
                min_distance = results[i].distance;
            }
        }
        return min_distance;
    }
}
