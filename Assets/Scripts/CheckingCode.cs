using TMPro;
using UnityEngine;

public class CheckingCode : MonoBehaviour
{
    public int i = 0;
    public int q = 0;
    public TMP_InputField numberAns;
    public TextMeshProUGUI result;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;
    public TMP_InputField inputfield3;
    public static double minA;
    public static double maxA;
    public static string inputField1;
    public static string inputField2;
    public static string inputField3;
    public ShowPersent room1;
    private int canAdd = 1;

    private void Start()
    {
        canAdd = PlayerPrefs.GetInt(SaveAndLoadCell.ParentName + "canAdd");
    }
    public void Changer()
    {
        result.text = "";
        double a = double.Parse(numberAns.text);
        if (a >= minA && a <= maxA && inputfield1.text == inputField1 && inputfield2.text == inputField2 && inputfield3.text == inputField3)
        {
            result.text = "Ответ правильный";
            GameObject parent = GameObject.Find(SaveAndLoadCell.ParentName);
            foreach (Transform item in parent.transform)
            {
                if (item.tag == "Jackdow")
                {
                    item.gameObject.SetActive(true);
                }
            }
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

    private void OnDisable()
    {
        result.text = "";
    }
}

