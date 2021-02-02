using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// мы создаем где будет храниться объект, пункт меню, order = 51 это что бы пункт был ниже File
// по умолчанию у меню было 50
//[CreateAssetMenu(fileName = "New Goods", menuName = "Goods/Create New Goods", order = 51)]
public abstract class Goods : ScriptableObject
{
    [SerializeField] protected string Label;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowInfo();
}