using UnityEngine;

public class ShowTaskAnswers : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;

    public void Activate()
    {
        foreach (var button in buttons)
        {
            button.SetActive(false);
        }
    }
}
