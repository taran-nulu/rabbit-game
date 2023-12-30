using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static InteractionSystem;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    public Animator animator;
    public TMP_Text dialogueText;

    public void NPCDialogue(string text)
    {
        dialogueBox.SetActive(true);
        dialogueText.text = text;
        animator.SetTrigger("pop");
    }
}
