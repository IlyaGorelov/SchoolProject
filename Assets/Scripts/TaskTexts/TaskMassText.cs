
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
            case "Задача 1":
                text1.text = "Задача 1+";
                text2.text = "Три кубика из железа, меди и свинца имеют одинаковые размеры. Какой из них самый тяжелый? Плотность железа - 7800 кг/м^3, меди - 8900 кг/м^3, свинца - 11300 кг/м^3";
                dano1.SetActive(true);
                break;
            case "Задача 1+":
                text1.text = "Задача 1";
                dano1.SetActive(false);
                break;

            case "Задача 2":
                text1.text = "Задача 2+";
                text2.text = "Жидкость объемом 125 л имеет массу 100 кг. Определите ее плотность. (1 м^3 = 1000 л)";
                dano1.SetActive(true);
                break;
            case "Задача 2+":
                text1.text = "Задача 2";
                dano1.SetActive(false);
                break;

            case "Задача 3":
                text1.text = "Задача 3+";
                text2.text = "Слиток олова размером 30 см х 10 см х 10 см имеет массу 21,9 кг. Какова плотность олова? ";
                dano1.SetActive(true);
                break;
            case "Задача 3+":
                text1.text = "Задача 3";
                dano1.SetActive(false);
                break;

            case "Задача 4":
                text1.text = "Задача 4+";
                text2.text = "Полый медный куб с длиной ребра а = 6 см имеет массу m = 810 г. Какова толщина стенок куба? Плотность меди - 8900 кг/м. Выразите в см";
                dano1.SetActive(true);
                break;
            case "Задача 4+":
                text1.text = "Задача 4";
                dano1.SetActive(false);
                break;

            case "Задача 5*":
                text1.text = "Задача 5+";
                text2.text = "Масса пробирки с водой составляет 50 г. Масса этой же пробирки, заполненной водой, но с куском металла в ней массой 12 г составляет 60,5 г. Определите плотность металла, помещенного в пробирку.";
                dano1.SetActive(true);
                break;
            case "Задача 5+":
                text1.text = "Задача 5*";
                dano1.SetActive(false);
                break;

            case "Задача 6":
                text1.text = "Задача 6+";
                text2.text = "Сколько рейсов должен сделать самосвал грузоподъемностью 5 т, чтобы перевезти 100 м3 гранита? Плотность гранита 2600 кг/м3.";
                dano1.SetActive(true);
                break;
            case "Задача 6+":
                text1.text = "Задача 6";
                dano1.SetActive(false);
                break;
        }
    }
}
