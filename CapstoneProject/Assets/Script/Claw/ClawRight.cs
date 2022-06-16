using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawRight : MonoBehaviour
{
    public GameObject Magnet;
    private Animator anim;
    public bool clawsOpen;

    // Start is called before the first frame update
    void Start()
    {
        clawsOpen = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Magnet.SetActive(true);
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == true)
        {
            anim.SetTrigger("ClawRightClose");
            clawsOpen = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == false)
        {
            anim.SetTrigger("ClawRightOpen");
            clawsOpen = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CheckPoint" && clawsOpen == false)
        {
            StartCoroutine(nameof(StartOpen));
        }
      
    }

    private IEnumerator StartOpen()
    {
        yield return new WaitForSeconds((float)0.5);
        anim.SetTrigger("ClawRightOpen");
        clawsOpen = true;
    }



}
