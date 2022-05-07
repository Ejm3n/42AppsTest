using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObjectWhenFocused : MonoBehaviour
{
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;

    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.red;

    }
}
