using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zadachi : MonoBehaviour
{

    public TextMeshProUGUI changetext;
    public GameObject dano;
    
    public void TextChange()
    {
        switch (changetext.text)
        {
            case "Задача":

                changetext.text = "";
                dano.SetActive(true);
                
                break;
            case "":

                changetext.text = "Задача";
                dano.SetActive(false);
                
                break;

            case "Задача1":

                changetext.text = "Задача1+";
                dano.SetActive(true);
                

                break;
            case "Задача1+":

                changetext.text = "Задача1";
                dano.SetActive(false);
                break;

            case "Задача2. Давление в жидкости":

                changetext.text = "Задача2. Давление в жидкости+";
                dano.SetActive(true);
                break;
            case "Задача2. Давление в жидкости+":

                changetext.text = "Задача2. Давление в жидкости";
                dano.SetActive(false);
                break;

            case "Задача3. Aрхимедова сила":

                changetext.text = "Задача3. Aрхимедова сила+";
                dano.SetActive(true);
                break;
            case "Задача3. Aрхимедова сила+":

                changetext.text = "Задача3. Aрхимедова сила";
                dano.SetActive(false);
                break;

            case "Задача 6":
                changetext.text = "Задача 6+";
                dano.SetActive(true);
                break;
            case "Задача 6+":
                changetext.text = "Задача 6";
                dano.SetActive(false);
                break;

            case "Задача 7":
                changetext.text = "Задача 7+";
                dano.SetActive(true);
                break;
            case "Задача 7+":
                changetext.text = "Задача 7";
                dano.SetActive(false);
                break;

            case "Задача 8":
                changetext.text = "Задача 8+";
                dano.SetActive(true);
                break;
            case "Задача 8+":
                changetext.text = "Задача 8";
                dano.SetActive(false);
                break;
        }
    }
}
