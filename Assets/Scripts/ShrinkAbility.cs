using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAbility : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.localScale = new Vector3(0.045f, 0.04f, 1);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            transform.localScale = new Vector3(0.09f, 0.08f, 1);
        }
    }
}