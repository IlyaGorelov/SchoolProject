
using TMPro;
using UnityEngine;

public class TMovement : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    
    

    public void TextChange()
    {
        if (changetext.text == "����������� ��������")
        {
            changetext.text = "����������� �������� � ��� ��������, ��� ������� ���� ��������\r\n������ ���������� �� ��������� ������ ���������� �������.\r\n";
            Debug.Log("dxhdrh");
        }
        else
            changetext.text = "����������� ��������";
    }

    


}
