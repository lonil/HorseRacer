using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;
    private string horseNumber;
    private string dialogProgress;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Horse"))
        {
            horseNumber = collision.name;
            TextContruction(horseNumber);
            dialogBox.SetActive(true);
            Debug.Log(dialogProgress);
        }
    }
    void TextContruction(string horseNumber)
    {
        dialogProgress = dialogProgress + dialog + horseNumber +"!"+ Environment.NewLine;
        dialogText.text = dialogProgress;
    }

}
