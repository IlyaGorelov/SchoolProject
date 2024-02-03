using UnityEngine;

public class ShowTask : MonoBehaviour
{
    [SerializeField] GameObject Task;
    bool isShown = false;
    public void Show()
    {
        if (!isShown)
        {
            isShown = true;
            Task.SetActive(true);
        }else if (isShown)
        {
            isShown = false;
            Task.SetActive(false);
        }
    }
}
