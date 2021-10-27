using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    //FIFO sentences
    private Queue<string> sentences;
    public Dialogue dialogue;
    public Button nextDialogue;
    private bool isDisplay;
    //private Button self;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        sentences = new Queue<string>();
        isDisplay = false;
    }

    void Update()
    {
        if (gameObject.activeSelf && isDisplay == false)
        {
            isDisplay = true;
            StartDialogue();
        }
    }

    public void StartDialogue()
    {
        //Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        gameObject.SetActive(false);
        isDisplay = false;
        if (nextDialogue != null)
        {
            nextDialogue.gameObject.SetActive(true);
        }
    }
}
