using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType {NONE, SHRINK, GROW, INVISIBLE, INVIS_WIZ, SHRINK_WIZ, GROW_WIZ}
    public InteractionType type;
    public string popupText;

    public static bool canShrink;
    public static bool canGrow;
    public static bool canInvis;

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        gameObject.layer = 7; //7 is the item layer
    }

    public void Interact()
    {
        switch(type)
        {
            case InteractionType.SHRINK:
                canShrink = true;
                Debug.Log("SHRINK");
                Destroy(gameObject);
                break;
            case InteractionType.GROW:
                canGrow = true;
                Debug.Log("GROW");
                Destroy(gameObject);
                break;            
            case InteractionType.INVISIBLE:
                canInvis = true;
                Debug.Log("John Cena?");
                Destroy(gameObject);
                break;
            case InteractionType.SHRINK_WIZ:
                Dialogue pop = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop.NPCDialogue(popupText);
                // Debug.Log("Hello, i am talking");
                break;
            case InteractionType.GROW_WIZ:
                Dialogue pop1 = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop1.NPCDialogue(popupText);
                // Debug.Log("Hello, i am talking");
                break;
            case InteractionType.INVIS_WIZ:
                Dialogue pop2 = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop2.NPCDialogue(popupText);
                // Debug.Log("Hello, i am talking");
                break;
            default:
                Debug.Log("No Item");
                break;
        }
    }
}
