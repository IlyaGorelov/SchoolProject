using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Velocity : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    public GameObject GameObject;

    

    public void TextChange()
    {
        if (changetext.text == "Скорость")
        {
            changetext.text = "Скорость при равномерном движении тела показывает, какой путь оно прошло в единицу времени.\n Скорость в раномерном движении остается постоянной. (    ) ";
            GameObject.SetActive(true);
        }
        else
        {
            changetext.text = "Скорость";
            GameObject.SetActive(false);
        }
    }

    


}
