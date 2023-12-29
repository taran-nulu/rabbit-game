using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class GrowthAbility : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                transform.localScale = new Vector3(0.18f, 0.16f, 1);
            }

            if (Input.GetKeyUp(KeyCode.G))
            {
                transform.localScale = new Vector3(0.09f, 0.08f, 1);
            }
        }
    }
}