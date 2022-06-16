using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;

    private string nmScene;
    private GameObject character;
    public Text txtNama;
    public Text txtDialogue;

    public Animator animator;

    private Queue<string> sentences;
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);


        //Debug.Log("Starting conversetion with " + dialogue.nama);
        txtNama.text = dialogue.nama;

        nmScene = dialogue.sceneName;// numpang ambil data


        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        SoundManager.instance.ButtonClickSfx();

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }


        string sentence = sentences.Dequeue();

        //Debug.Log(sentence);
        //txtDialogue.text = sentence; // tanpa animasi text
        StopAllCoroutines();// stop animasi agar tidak tertumpuk
        StartCoroutine(TypeSentence(sentence));// dengan animasi
    }

    IEnumerator TypeSentence(string sentence)
    {
        txtDialogue.text = "";
        foreach (char letter in sentence.ToCharArray())// ToCharArray mengubah string ke array string ( ayam > a, y, a, m)
        {
            txtDialogue.text += letter;
            yield return null;
        }
    }

    public void laodScene()
    {
        SceneManager.LoadScene(nmScene);
    }

    public void EndDialogue() // tadinya private
    {
        animator.SetBool("isOpen", false);
        //Debug.Log("end of conversation");
        laodScene();

    }
}

//https://youtu.be/_nRzoTzeyxU
