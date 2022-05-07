using UnityEngine;

public class ColorObjectWhenFocused : MonoBehaviour
{
    [SerializeField] private Color _defaultColor;
    [SerializeField] private Color _changeColor;
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = _changeColor;

    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = _defaultColor;

    }
}
