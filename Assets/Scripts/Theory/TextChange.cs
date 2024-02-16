using TMPro;
using UnityEngine;

public class TextChange : MonoBehaviour
{
    [SerializeField] private string ChangeTo;
    private string ChangeFrom;
    [SerializeField] private TextMeshProUGUI text;
    private bool isChanged = false;
    public void Change()
    {
        if (!isChanged)
        {
            ChangeFrom = text.text;
            text.text = ChangeTo;
            isChanged = true;
        }
        else
        {
            isChanged = false;
            text.text = ChangeFrom;
        }
    }
}
