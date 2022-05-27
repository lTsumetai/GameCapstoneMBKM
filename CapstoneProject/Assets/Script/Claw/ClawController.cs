using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    bool goUp, goDown, goLeft, goRight;

    // Start is called before the first frame update
    void Start()
    {

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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            goRight = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            goRight = false;
        }

  


        //function movement
        if (goUp)
        {
            gameObject.transform.Translate(0, 0.01f, 0);
        }

        if (goDown)
        {
            gameObject.transform.Translate(0, -0.01f, 0);
        }

        if (goRight)
        {
            gameObject.transform.Translate(0.01f, 0, 0);
        }

        if (goLeft)
        {
            gameObject.transform.Translate(-0.01f, 0, 0);
        }
        
        
    }
}