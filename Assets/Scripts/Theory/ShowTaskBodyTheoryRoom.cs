using UnityEngine;

public class ShowTaskBodyTheoryRoom : MonoBehaviour
{
    [SerializeField] private GameObject Task;
    private bool isShown = false;
    public void Show()
    {
        if (!isShown)
        {
            isShown = true;
            Task.SetActive(true);
        }
        else if (isShown)
        {
            isShown = false;
            Task.SetActive(false);
        }
    }
}
