using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class SpriteRender : MonoBehaviour
{

    public Renderer shrink;
    public Renderer grow;
    public Renderer invis;

    // Start is called before the first frame update
    void Start()
    {
        shrink.enabled = false;
        grow.enabled = false;
        // invis.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Item.invisTalked == true)
        {
            invis.enabled = true;
            Debug.Log("invis");
        }
        if (Item.shrinkTalked == true)
        {
            shrink.enabled = true;
            Debug.Log("shrink");
        }

        if (Item.growTalked == true)
        {
            grow.enabled = true;
            Debug.Log("grow");
        }

    }
}
