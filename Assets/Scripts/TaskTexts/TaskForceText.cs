
using TMPro;
using UnityEngine;

public class TaskForceText : MonoBehaviour
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
                text2.text = "Банка объемом 5 дм^3 заполнена водой. Какой вес имеет вода? ";
                dano1.SetActive(true);
                break;
            case "Задача 1+":
                text1.text = "Задача 1";
                dano1.SetActive(false);
                break;

            case "Задача 2":
                text1.text = "Задача 2+";
                text2.text = "Под действием груза в 200 Н пружина динамометра удлинилась на 0,5 см. Каково удлинение пружины под действием груза в 700 Н? Выразите в см ";
                dano1.SetActive(true);
                break;
            case "Задача 2+":
                text1.text = "Задача 2";
                dano1.SetActive(false);
                break;

            

            case "Задача 3":
                text1.text = "Задача 3+";
                text2.text = "Определите общий вес пяти бильярдных шаров, масса каждого из которых равна 125 г. ";
                dano1.SetActive(true);
                break;
            case "Задача 3+":
                text1.text = "Задача 3";
                dano1.SetActive(false);
                break;

            case "Задача 4":
                text1.text = "Задача 4+";
                text2.text = "Вычислите суммарную силу тяги, действующую на поезд, который везут два тепловоза. Один развивает силу тяги 80кН, другой — 85 кН. Выразить в кН ";
                dano1.SetActive(true);
                break;
            case "Задача 4+":
                text1.text = "Задача 4";
                dano1.SetActive(false);
                break;

            case "Задача 5":
                text1.text = "Задача 5+";
                text2.text = "Найдите равнодействующую четырех сил, если известно, что F1 =150 Н и F2 = 770 Н направлены в одну сторону, а F3 =880Н и F4 = 1200 Н — по той же прямой, но в противоположную сторону. ";
                dano1.SetActive(true);
                break;
            case "Задача 5+":
                text1.text = "Задача 5";
                dano1.SetActive(false);
                break;

            case "Задача 6":
                text1.text = "Задача 6+";
                text2.text = "Чему равно изменение длины системы, состоящей из двух последовательно соединенных пружин, жесткости которых 52000Н/м и 13000Н/м, если к нижнему концу этой системы подвешен алюминиевый куб объемом 16 л, а верхний ее конец закреплен к подвесу? Плотность алюминия 2700 кг/м^3";
                dano1.SetActive(true);
                break;
            case "Задача 6+":
                text1.text = "Задача 6";
                dano1.SetActive(false);
                break;

           
        }
    }
}
