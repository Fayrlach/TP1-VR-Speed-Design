using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_controller : MonoBehaviour
{
    public GameObject camera;
    //bool ball_was_shot = false;
    int points = 0;
    public TextMesh Score;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float time = Mathf.Repeat(Time.time, 5.0F);
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.R) == true)    //Was the 'shot' key pressed?
        {
            
            m_Rigidbody.position = GameObject.Find("Main Camera").transform.position;   //Get the camera position and asign it 
            m_Rigidbody.velocity = Vector3.zero;                                        //as the origin of the shot
             m_Rigidbody.AddForce(camera.transform.forward * 1000);
            
        }
        /*if(time < 2.0)       //Basic function to shot a ball from a fixed place
        {
            m_Rigidbody.position = new Vector3(102, 2, -10);                          //Default position for testing the shots
            ,_Rigidbody.velocity = Vector3.zero;
            ball_was_shot = false;
        }*/
        /*else
        {
            if (!ball_was_shot)
            {
                m_Rigidbody.AddForce(camera.transform.forward * 1000);
                ball_was_shot = true;
            }
        }*/
    }
    void OnTriggerEnter(Collider Player)    //Update score based of shots that hit the target
    {
        points += 1;
        Score.text = "Score:" + points;
    }
}
