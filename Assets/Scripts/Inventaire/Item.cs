using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventaire/Item")]
public class Item : ScriptableObject
{
    private int id;
    private ItemType type;
    private int count;
    private double prixachat = 0.0f;

    public Item(int _id, ItemType _type, int _count = 1, double _prixachat = 0.0f)
    {
        this.Id = _id;
        this.Type = _type;
        this.Count = _count;
        this.Prixachat = _prixachat;
    }

    public int Id { get => id; set => id = value; }
    public ItemType Type { get => type; set => type = value; }
    public int Count { get => count; set => count = value; }
    public double Prixachat { get => prixachat; set => prixachat = value; }
}
