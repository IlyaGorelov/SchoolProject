using TMPro;
using UnityEngine;

public class TextChange : MonoBehaviour
{
    [SerializeField] string ChangeTo;
    string ChangeFrom;
    [SerializeField] TextMeshProUGUI text;
    bool isChanged = false;
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
