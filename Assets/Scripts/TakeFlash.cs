using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlash : MonoBehaviour
{
    bool canTake;
    [SerializeField] FirstPersonController controller;
    [SerializeField] GameObject buttonToPutIn;
    private void Update()
    {
        if(canTake && Input.GetMouseButtonDown(0))
        {
            controller.isTaken = true;
            buttonToPutIn.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    private void OnMouseEnter()
    {
        canTake = true;
    }
    private void OnMouseExit()
    {
        canTake = false;
    }
}
