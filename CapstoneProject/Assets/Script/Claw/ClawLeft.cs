using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLeft : MonoBehaviour
{
    private Animator anim;
    public bool clawsOpen;
    public bool clawmode;

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
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == true)
        {
            anim.SetTrigger("ClawLeftClose");
            clawsOpen = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && clawsOpen == false)
        {
            anim.SetTrigger("ClawLeftOpen");
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
        anim.SetTrigger("ClawLeftOpen");
        clawsOpen = true;
    }

}