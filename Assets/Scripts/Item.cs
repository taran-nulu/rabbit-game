using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum InteractionType {NONE, PICKUP, TALK}
    public InteractionType type;

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
                break;
            case InteractionType.TALK:
                Debug.Log("Hello, i am talking");
                break;
            default:
                Debug.Log("No Item");
                break;
        }
    }
}
