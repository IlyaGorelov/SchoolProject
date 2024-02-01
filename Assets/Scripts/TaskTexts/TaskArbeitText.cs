using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskArbeitText : MonoBehaviour
{
    public GameObject dano1;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public void Dano1()
    {

        switch (text1.text)
        {
            case "Задача 1":
                text1.text = "Задача 1+";
                text2.text = "Какую работу совершил носильщик, равномерно подняв груз массой 30 кг на высоту 0,5 м? ";
                dano1.SetActive(true);
                break;
            case "Задача 1+":
                text1.text = "Задача 1";
                dano1.SetActive(false);
                break;

            case "Задача 2":
                text1.text = "Задача 2+";
                text2.text = "Определите работу лошади, везущей равномерно по горизонтальному пути воз массой 0,2т на расстояние 0,5 км. Коэффициент трения равен 0,02.  ";
                dano1.SetActive(true);
                break;
            case "Задача 2+":
                text1.text = "Задача 2";
                dano1.SetActive(false);
                break;

            case "Задача 3":
                text1.text = "Задача 3+";
                text2.text = "Ведро воды объемом 12 л подняли вверх, совершив \r\nработу 600 Дж. На какую высоту подняли ведро? \r\n";
                dano1.SetActive(true);
                break;
            case "Задача 3+":
                text1.text = "Задача 3";
                dano1.SetActive(false);
                break;

            case "Задача 4":
                text1.text = "Задача 4+";
                text2.text = "Какую работу совершает двигатель мотоцикла мощностью 200 кВт за 30 мин? Выразите в МДж ";
                dano1.SetActive(true);
                break;
            case "Задача 4+":
                text1.text = "Задача 4";
                dano1.SetActive(false);
                break;

            case "Задача 5":
                text1.text = "Задача 5+";
                text2.text = "Вода падает в турбину Днепровской гидроэлектростанции с высоты 37,5 м. Расход воды в турбине 200 м3/с. Какова мощность турбины? Выразите в МВт";
                dano1.SetActive(true);
                break;
            case "Задача 5+":
                text1.text = "Задача 5";
                dano1.SetActive(false);
                break;

            case "Задача 6":
                text1.text = "Задача 6+";
                text2.text = "Меньшая сила, действующая на рычаг, равна 5Н. Найдите большую силу, если плечи рычага 0,1 м и 0,3м.  ";
                dano1.SetActive(true);
                break;
            case "Задача 6+":
                text1.text = "Задача 6";
                dano1.SetActive(false);
                break;

            case "Задача 7":
                text1.text = "Задача 7+";
                text2.text = "Мотор экскаватора имеет мощность 14,7 кВт. За час экскаватор поднял 500 т земли на высоту 2 м. Каков коэффициент полезного действия экскаватора? Выразите в процентах ";
                dano1.SetActive(true);
                break;
            case "Задача 7+":
                text1.text = "Задача 7";
                dano1.SetActive(false);
                break;

            case "Задача 8":
                text1.text = "Задача 8+";
                text2.text = "Какой потенциальной энергией относительно земли обладает человек массой 80 кг на высоте 20 м? ";
                dano1.SetActive(true);
                break;
            case "Задача 8+":
                text1.text = "Задача 8";
                dano1.SetActive(false);
                break;

            case "Задача 9":
                text1.text = "Задача 9+";
                text2.text = "Недеформированную пружину динамометра растянули на 10 см, и ее потенциальная энергия стала 0,4 Дж. Каков коэффициент жесткости пружины? ";
                dano1.SetActive(true);
                break;
            case "Задача 9+":
                text1.text = "Задача 9";
                dano1.SetActive(false);
                break;

           
        }
    }
}
