using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// мы создаем где будет храниться объект, пункт меню, order = 51 это что бы пункт был ниже File
[CreateAssetMenu(fileName = "New Food", menuName = "Shop/Food", order = 51)]
public class Food : Goods
{
    [SerializeField] private int _calorie;
    public override void ShowInfo()
    {
        Debug.Log($"Товар съедобный {Label}, вид его {Description}, стоит {Price}, сытность на {_calorie}");
    }
}
