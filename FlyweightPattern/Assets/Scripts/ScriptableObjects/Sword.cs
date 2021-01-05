using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// мы создаем где будет храниться объект, пункт меню, order = 51 это что бы пункт был ниже File
[CreateAssetMenu(fileName = "New Weapon", menuName = "Shop/Weapon", order = 51)]
public class Sword : Goods
{
    [SerializeField] private int _damage;
    public override void ShowInfo()
    {
        Debug.Log($"Товар weapon {Label}, вид его {Description}, стоит {Price}, beat на {_damage}");
    }
}
