
using TMPro;
using UnityEngine;

public class TaskMassText : MonoBehaviour
{
    public GameObject dano1;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public void Dano1()
    {

        switch (text1.text)
        {
            case "������ 1":
                text1.text = "������ 1+";
                text2.text = "��� ������ �� ������, ���� � ������ ����� ���������� �������. ����� �� ��� ����� �������? ��������� ������ - 7800 ��/�^3, ���� - 8900 ��/�^3, ������ - 11300 ��/�^3";
                dano1.SetActive(true);
                break;
            case "������ 1+":
                text1.text = "������ 1";
                dano1.SetActive(false);
                break;

            case "������ 2":
                text1.text = "������ 2+";
                text2.text = "�������� ������� 125 � ����� ����� 100 ��. ���������� �� ���������. (1 �^3 = 1000 �)";
                dano1.SetActive(true);
                break;
            case "������ 2+":
                text1.text = "������ 2";
                dano1.SetActive(false);
                break;

            case "������ 3":
                text1.text = "������ 3+";
                text2.text = "������ ����� �������� 30 �� � 10 �� � 10 �� ����� ����� 21,9 ��. ������ ��������� �����? ";
                dano1.SetActive(true);
                break;
            case "������ 3+":
                text1.text = "������ 3";
                dano1.SetActive(false);
                break;

            case "������ 4":
                text1.text = "������ 4+";
                text2.text = "����� ������ ��� � ������ ����� � = 6 �� ����� ����� m = 810 �. ������ ������� ������ ����? ��������� ���� - 8900 ��/�. �������� � ��";
                dano1.SetActive(true);
                break;
            case "������ 4+":
                text1.text = "������ 4";
                dano1.SetActive(false);
                break;

            case "������ 5*":
                text1.text = "������ 5+";
                text2.text = "����� �������� � ����� ���������� 50 �. ����� ���� �� ��������, ����������� �����, �� � ������ ������� � ��� ������ 12 � ���������� 60,5 �. ���������� ��������� �������, ����������� � ��������.";
                dano1.SetActive(true);
                break;
            case "������ 5+":
                text1.text = "������ 5*";
                dano1.SetActive(false);
                break;

            case "������ 6":
                text1.text = "������ 6+";
                text2.text = "������� ������ ������ ������� �������� ����������������� 5 �, ����� ��������� 100 �3 �������? ��������� ������� 2600 ��/�3.";
                dano1.SetActive(true);
                break;
            case "������ 6+":
                text1.text = "������ 6";
                dano1.SetActive(false);
                break;
        }
    }
}
