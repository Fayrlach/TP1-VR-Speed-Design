using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensor_movement : MonoBehaviour
{
    Vector3 start_position;
    // Start is called before the first frame update
    void Start()
    {
        start_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        transform.position = start_position + new Vector3(0, 0, 3 * Mathf.Sin(2 * Mathf.PI * 0.6F * time));
    }
}