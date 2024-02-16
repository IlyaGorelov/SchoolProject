using UnityEngine;

public class TakeFlash : MonoBehaviour
{
    private bool canTake;
    [SerializeField] private FirstPersonController controller;
    [SerializeField] private GameObject buttonToPutIn;

    private void Update()
    {
        if (canTake && Input.GetMouseButtonDown(0))
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
