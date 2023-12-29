using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class SpriteRender : MonoBehaviour
{

    public Renderer charm1;
    public Renderer charm2;
    public Renderer charm3;

    // Start is called before the first frame update
    void Start()
    {
        charm1.enabled = false;
        charm2.enabled = false;
        charm3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Item.shrinkTalked == true)
        {
            charm1.enabled = true;
        }
        if (Item.growTalked == true)
        {
            charm2.enabled = true;
        }
        if (Item.invisTalked == true)
        {
            charm3.enabled = true;
        }
    }
}
