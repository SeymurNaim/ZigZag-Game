using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    Rigidbody rigidbody;
    bool started;
    bool gameOver;



    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        started = false;
        gameOver = false;
    }

    
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager.instance.StartGame();
            }
        }

        if (!Physics.Raycast(transform.position, Vector3.down, 1f) && !gameOver)
        {
            rigidbody.velocity = new Vector3(0, -25, 0);
            Camera.main.GetComponent<CameraFollow>().GameOver = true;
            gameOver = true;
            SoundsManager.instance.GameOver();
        }


        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }

    }


    void SwitchDirection()
    {

            if (rigidbody.velocity.z > 0)
            {
                rigidbody.velocity = new Vector3(speed, 0, 0);
            }
            else if (rigidbody.velocity.x > 0)
            {
                rigidbody.velocity = new Vector3(0, 0, speed);
            }
        SoundsManager.instance.ClickSound();
    }
}
