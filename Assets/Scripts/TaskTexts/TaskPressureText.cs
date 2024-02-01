
using TMPro;
using UnityEngine;

public class TaskPressureText : MonoBehaviour
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
                text2.text = "500 г жидкости налили в сосуд, площадь дна которого 20 см^2. Определите давление жидкости на дно сосуда. ";
                dano1.SetActive(true);
                break;
            case "Задача 1+":
                text1.text = "Задача 1";
                dano1.SetActive(false);
                break;

            case "Задача 2":
                text1.text = "Задача 2+";
                text2.text = "Фрезерный станок массой 300 кг установлен на четырех опорах, средняя площадь каждой из которых 50 см. Каково давление станка на пол? ";
                dano1.SetActive(true);
                break;
            case "Задача 2+":
                text1.text = "Задача 2";
                dano1.SetActive(false);
                break;

            case "Задача 3":
                text1.text = "Задача 3+";
                text2.text = " У железнодорожной платформы общая площадь соприкосновения колес с рельсами 20 см^2. На нее погрузили автомобили массой 5 т. Насколько увеличилось давление платформы на рельсы? Выразите в МПа ";
                dano1.SetActive(true);
                break;
            case "Задача 3+":
                text1.text = "Задача 3";
                dano1.SetActive(false);
                break;

            case "Задача 4":
                text1.text = "Задача 4+";
                text2.text = "Определите давление лыжника на снег, если масса лыжника 72 кг, длина лыжи 2 м, ширина 10 см. ";
                dano1.SetActive(true);
                break;
            case "Задача 4+":
                text1.text = "Задача 4";
                dano1.SetActive(false);
                break;

            case "Задача 5":
                text1.text = "Задача 5+";
                text2.text = "В сосуд налили слой воды высотой 15 см. Каково давление этого слоя на дно сосуда? p воды - 1000 кг/м^3";
                dano1.SetActive(true);
                break;
            case "Задача 5+":
                text1.text = "Задача 5";
                dano1.SetActive(false);
                break;

            case "Задача 6":
                text1.text = "Задача 6+";
                text2.text = "Для спуска водолаза на очень большую глубину применяется специальный металлический скафандр. Какую силу давления должен выдержать этот скафандр в море на глубине 300 м, если общая поверхность скафандра составляет 2,5 м^2? Выразит в кН (Плотность морской воды - 1030 кг/м^3)";
                dano1.SetActive(true);
                break;
            case "Задача 6+":
                text1.text = "Задача 6";
                dano1.SetActive(false);
                break;

            case "Задача 7":
                text1.text = "Задача 7+";
                text2.text = "Вычислите разность давлений в трубах водопровода на нижнем этаже здания и на этаже, расположенном выше нижнего на 15 м. Выразите в кПа ";
                dano1.SetActive(true);
                break;
            case "Задача 7+":
                text1.text = "Задача 7";
                dano1.SetActive(false);
                break;

            case "Задача 8":
                text1.text = "Задача 8+";
                text2.text = "Давление в трубах водопровода 4 * 10^5 Па. На какую высоту будет бить вода из пожарной трубы, присоединенной к этому водопроводу, если не принимать во внимание сопротивление воздуха и трение воды в трубах? ";
                dano1.SetActive(true);
                break;
            case "Задача 8+":
                text1.text = "Задача 8";
                dano1.SetActive(false);
                break;

            case "Задача 9":
                text1.text = "Задача 9+";
                text2.text = "Человек стоит на кожаном мешке с водой . Рассчитайте, на какую высоту поднимается вода в трубке, если масса человека 75 кг, площадь соприкасающейся с мешком поверхности платформы 1000 см^2.";
                dano1.SetActive(true);
                break;
            case "Задача 9+":
                text1.text = "Задача 9";
                dano1.SetActive(false);
                break;

            
        }
    }
}
