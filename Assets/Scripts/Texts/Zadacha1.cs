using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Zadacha1 : MonoBehaviour
{
    public TextMeshProUGUI changetext;
    

    

    public void TextChange()
    {
        if (changetext.text == "Задача 1")
        {
            changetext.text = "Поезд, двигаясь равномерно, за два часа проходит путь, равный 108 км. Вычислите скорость движения поезда. (Выразить в единицах СИ)";
            
        }
        else
        {
            changetext.text = "Задача 1";
            
        }
        
    }

    


}
