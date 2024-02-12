using TMPro;
using UnityEngine;

public class MainMenuTextChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject changesImage;
   public void Management()
    {
        changesImage.SetActive(false);
        text.text = " F1 - ������������� ������ \n F3 - ������� ���������� \n F5 - ����������� \n F8 - �������� �������";
    }
    public void SI()
    {
        text.text = " ������ ��� ������ � �������� ��, ���� � ������� ������ ��� ��� �� ��������: \n �������� - �/� \n ����� - �� \n ����� - � \n ������ - �� \n ���������� - � \n �������� - �� \n ���� - �\n �������� - �� \n";
        changesImage.SetActive(false);
    }
    public void Decor()
    {
        changesImage.SetActive(true);
        text.text = " 1. ���� ����� ������������ ����� - ������ 0 � ������ ������. \n 2. ������� � ������ ������ /, ����� ������� �����. \n 3.������ � ������ ����� ��� ���������� �����, ��������� ������� ����� �������";
        text.fontSizeMax = 29;
    }
}
