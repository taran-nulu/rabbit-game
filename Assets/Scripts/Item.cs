using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType {NONE, PICKUP, TALK}
    public InteractionType type;
    public string popupText;

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        gameObject.layer = 7; //7 is the item layer
    }

    public void Interact()
    {
        switch(type)
        {
            case InteractionType.PICKUP:
                Debug.Log("Pick Up Item");
                Destroy(gameObject);
                break;
            case InteractionType.TALK:
                Dialogue pop = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop.NPCDialogue(popupText);
                Debug.Log("Hello, i am talking");
                break;
            default:
                Debug.Log("No Item");
                break;
        }
    }
}
