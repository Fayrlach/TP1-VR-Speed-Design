using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_controller : MonoBehaviour
{
    public GameObject camera;
    bool ball_was_shot = false;
    int points = 0;
    public TextMesh Score;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.Repeat(Time.time, 5.0F);
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
        if (time < 2.0)
        {
            m_Rigidbody.position = new Vector3(102, 2, -10);
            m_Rigidbody.velocity = Vector3.zero;
            ball_was_shot = false;
        }
        else
        {
            if (!ball_was_shot)
            {
                m_Rigidbody.AddForce(camera.transform.forward * 1000);
                ball_was_shot = true;
            }
        }
    }
    void OnTriggerEnter(Collider Player)
    {
        points += 1;
        Score.text = "Score:" + points;
    }
}

