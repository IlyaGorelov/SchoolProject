using TMPro;
using UnityEngine;

public class MainMenuTextChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
   public void Management()
    {
        text.text = " F1 - �������������� ������ \n F3 - ������� ���������� \n F5 - ����������� \n F8 - �������� �������";
    }
    public void SI()
    {
        text.text = " ������ ��� ������ � �������� ��, ���� � ������� ������ ��� ��� �� ��������: \n �������� - �/� \n ����� - ��\n ����� - � \n ������ - ��\n ���������� - �\n �������� - ��\n ���� - �\n";
    }
    public void Decor()
    {
        text.text = " 1. ���� ����� ������������ ����� - ������ 0 � ������ ������.\n 2. ������� � ������ ������ /, ����� ������� �����. \n 3.������ � ������ ����� ��� ���������� �����, ��������� ������� ������ �������";
    }
}
