using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventaire", menuName = "Inventaire/Inventaire")]
public class Inventaire : ScriptableObject
{
    private int index;
    private int maxplace;
    private List<Item> items;

    public Inventaire(int _index, int _maxplace)
    {
        this.Index = _index;
        this.Maxplace = _maxplace;
        this.items = new List<Item>();
    }

    public int Index { get => index; set => index = value; }
    public int Maxplace { get => maxplace; set => maxplace = value; }
    public List<Item> Items { get => items; set => items = value; }
}