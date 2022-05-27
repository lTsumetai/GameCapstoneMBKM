using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClaw : MonoBehaviour
{
    bool goUp, goDown, goLeft, goRight;

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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            goUp = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            goUp = false;
        }
        //function movement
        if (goUp)
        {
            //gameObject.transform.Translate(0, 0.01f, 0);
            transform.localScale = transform.localScale + new Vector3(0, -0.01f, 0);
        }

        if (goDown)
        {
            //gameObject.transform.Translate(0, -0.01f, 0);
            transform.localScale = transform.localScale + new Vector3(0, 0.01f, 0);
        }
    }
}