using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType {NONE, SHRINK, GROW, INVISIBLE, INVIS_WIZ, SHRINK_WIZ, GROW_WIZ, CARROT}
    public InteractionType type;
    public string popupText;

    public static bool canShrink;
    public static bool canGrow;
    public static bool canInvis;

    public static bool shrinkTalked;
    public static bool growTalked;
    public static bool invisTalked;

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
                shrinkTalked = true;
                break;
            case InteractionType.GROW_WIZ:
                growTalked = true;
                Dialogue pop1 = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop1.NPCDialogue(popupText);
                break;
            case InteractionType.INVIS_WIZ:
                Dialogue pop2 = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Dialogue>();
                pop2.NPCDialogue(popupText);
                invisTalked = true;
                break;
            case InteractionType.CARROT:
                Debug.Log("You Win!");
                break;
            default:
                Debug.Log("No Item");
                break;
        }
    }
}