using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chekingCode : MonoBehaviour
{
    public int i = 0;
    public int q = 0;
    public TMP_InputField numberAns;
    public TextMeshProUGUI result;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;
    public TMP_InputField inputfield3;
    public double minA;
    public double maxA;
    public string inputField1;
    public string inputField2;
    public string inputField3;
    public ShowPersent room1;
    [SerializeField] GameObject jackdow;
    public void Changer()
    {
        result.text = "";
        double a = double.Parse(numberAns.text);
        if (a >= minA && a <= maxA && inputfield1.text == inputField1 && inputfield2.text == inputField2 && inputfield3.text == inputField3)
        {
            result.text = "Ответ правильный";
        }
        else
        {
            result.text = "Ответ неправильный";
        }
        if (i != 0)
        {
            i--;
            result.text += "\nУберите / из решения";
        }
        else if (q != 0)
        {
            q--;
            result.text += "\nУпростите решение. Уберите / из дробей";
        }
        else if (q == 0 && i == 0)
        {
            result.text = result.text;
        }
    }
    public void Plus1FromRoom()
    {
        if (result.text == "Ответ правильный" && !jackdow.activeSelf && SceneManager.GetActiveScene().buildIndex == 7)
        {
            room1.RoomOnePercent++;
            PlayerPrefs.SetFloat("RoomOnePersent", room1.RoomOnePercent);
        }
        if (result.text == "Ответ правильный" && !jackdow.activeSelf && SceneManager.GetActiveScene().buildIndex == 8)
        {
            room1.RoomTwoPercent++;
            PlayerPrefs.SetFloat("RoomTwoPersent", room1.RoomTwoPercent);
        }
        if (result.text == "Ответ правильный" && !jackdow.activeSelf && SceneManager.GetActiveScene().buildIndex == 9)
        {
            room1.RoomThreePercent++;
            PlayerPrefs.SetFloat("RoomThreePersent", room1.RoomThreePercent);
        }
        if (result.text == "Ответ правильный" && !jackdow.activeSelf && SceneManager.GetActiveScene().buildIndex == 10)
        {
            room1.RoomFourPercent++;
            PlayerPrefs.SetFloat("RoomFourPersent", room1.RoomFourPercent);
        }
        if (result.text == "Ответ правильный" && !jackdow.activeSelf && SceneManager.GetActiveScene().buildIndex == 11)
        {
            room1.RoomFivePercent++;
            PlayerPrefs.SetFloat("RoomFivePersent", room1.RoomFivePercent);
        }
    }
}
