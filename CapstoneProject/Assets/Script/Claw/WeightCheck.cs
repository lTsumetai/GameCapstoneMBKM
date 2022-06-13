using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightCheck : MonoBehaviour
{
    private int weight;
    public bool clawsOpen;
    bool goDown;


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "plastik")
        {
            weight = weight - 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "plastik")
        {
            weight = weight + 1;
        }

    }

    private void Start()
    {
        clawsOpen = true;
    }

    private void Update()
    {
        //Debug.Log("berat sekarang" + weight);

        if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == true)
        {
            clawsOpen = false;
            if (weight >= 2 && clawsOpen == false)
            {
                goDown = true;
                gameObject.GetComponent<ClawController>().enabled = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == false)
        {
            clawsOpen = true;
            goDown = false;
            gameObject.GetComponent<ClawController>().enabled = true;
        }

        if (goDown)
        {
            gameObject.transform.Translate(0, -0.01f, 0);
        }
    }

    
}
