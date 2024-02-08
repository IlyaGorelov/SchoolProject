using UnityEngine;

public class OpenExitMenu : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    bool isOpen = true;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&& !isOpen && !ToSolution.isSoluting)
        {
            gameObject.SetActive(true);
            isOpen = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&isOpen)
        {
            gameObject.SetActive(false);
            isOpen = false;
        }
    }
}
