
using TMPro;
using UnityEngine;

public class TMovement : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    
    

    public void TextChange()
    {
        if (changetext.text == "–авномерное движение")
        {
            changetext.text = "–авномерное движение Ч это движение, при котором тело проходит\r\nравные рассто€ни€ за небольшие равные промежутки времени.\r\n";
            Debug.Log("dxhdrh");
        }
        else
            changetext.text = "–авномерное движение";
    }

    


}
