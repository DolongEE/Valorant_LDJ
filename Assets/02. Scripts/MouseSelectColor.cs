using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSelectColor : MonoBehaviour
{
    RaycastHit rayHit;
    Ray mouseRay;

    Button button;

    private void Awake()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        button = GetComponent<Button>();
    }

    private void Update()
    {
        Physics.Raycast(mouseRay, out rayHit);
        if (rayHit.collider != null && rayHit.collider == button)
        {
            OnMouseEnter();
        }
        else if (rayHit.collider != button)
        {
            OnMouseExit();
        }
    }

    private void OnMouseEnter()
    {
        Debug.Log("MouseEnter");
    }

    private void OnMouseExit()
    {
        Debug.Log("MouseExit");
    }

    private void OnMouseDown()
    {
        Debug.Log("MouseDown");
    }
}
