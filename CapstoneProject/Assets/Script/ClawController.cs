using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    bool goUp, goDown, goLeft, goRight, clawsOpen;
    Rigidbody2D rightClaw, leftClaw;

    // Start is called before the first frame update
    void Start()
    {
        rightClaw = GameObject.Find("ClawRight").GetComponent<Rigidbody2D>();
        leftClaw = GameObject.Find("ClawLeft").GetComponent<Rigidbody2D>();
        clawsOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Input to Down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            goDown = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            goDown = false;
        }


        //Input to Up
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            goUp = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            goUp = false;
        }

        //Input to Left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            goLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            goLeft = false;
        }

        //Input to Right
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            goRight = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            goRight = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            clawsOpen = !clawsOpen;
        }


        //function movement
        if (goUp)
        {
            gameObject.transform.Translate(0, 0.05f, 0);
        }

        if (goDown)
        {
            gameObject.transform.Translate(0, -0.05f, 0);
        }

        if (goRight)
        {
            gameObject.transform.Translate(0.05f, 0, 0);
        }

        if (goLeft)
        {
            gameObject.transform.Translate(-0.05f, 0, 0);
        }


        if (clawsOpen)
        {
            Debug.Log("1claw" + leftClaw.transform.eulerAngles);
            Debug.Log("Rclaw" + rightClaw.transform.eulerAngles);
            if (leftClaw.transform.eulerAngles.z < 350)
            {
                leftClaw.transform.Rotate(0, 0, 1f);
            }
            if (rightClaw.transform.eulerAngles.z > 10)
            {
                rightClaw.transform.Rotate(0, 0, -1f);
            }
        }

        if (!clawsOpen)
        {
            Debug.Log("1claw" + leftClaw.transform.eulerAngles);
            Debug.Log("Rclaw" + rightClaw.transform.eulerAngles);
            if (leftClaw.transform.eulerAngles.z > 350)
            {
                leftClaw.transform.Rotate(0, 0, -1f);
            }
            if (rightClaw.transform.eulerAngles.z < 60)
            {
                rightClaw.transform.Rotate(0, 0, 1f);
            }
        }
    }
}
