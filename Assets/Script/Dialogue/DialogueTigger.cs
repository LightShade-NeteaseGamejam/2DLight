using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTigger : MonoBehaviour
{
    //public Dialogue dialogue;
    public Button dialogueBox;

    public void TiggerDialogue()
    {
        dialogueBox.gameObject.SetActive(true);
        Destroy(gameObject);
    }

    private void Start()
    {
        //TiggerDialogue();
    }
}
