using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public delegate void QuandObjetAjouter(Item _item);
public delegate void QuandObjetRetirer(Item _item, int derniereslot);

[CreateAssetMenu(fileName = "Inventaire", menuName = "Inventaire/Inventaire")]
public class Inventaire : ScriptableObject
{
    public event QuandObjetAjouter OnObjetAjouterEvent;
    public event QuandObjetRetirer OnObjetRetirerEvent;
    private int index;
    private int maxplace;
    private Dictionary<int, Item> placeinventaire;
    //private List<Item> items;

    public Inventaire(int _index, int _maxplace)
    {
        this.Index = _index;
        this.Maxplace = _maxplace;
        //this.items = new List<Item>();
        placeinventaire = new Dictionary<int, Item>();
    }

    public void AddItem(Item _item)
    {
        for (int i = 0; i < maxplace; i++)
        {
            try
            {
                Debug.Log("PLACE TROUVE INDEX " + i);
                this.placeinventaire.Add(i, _item);
                _item.indexplaceinventaire = i;
                //this.items.Add(_item);
                OnObjetAjouterEvent(_item);
                break;
            }
            catch
            {

            }
        }
    }

    public void RemoveItem(Item _item)
    {
        this.placeinventaire.Remove(_item.indexplaceinventaire);
        OnObjetRetirerEvent(_item, _item.indexplaceinventaire);
        _item.indexplaceinventaire = -1;
    }
    
    /*public List<Item> GetListeItem()
    {
        //return this.items;
    }*/

    public Dictionary<int, Item> GetInventaireItemsPlace()
    {
        return this.placeinventaire;
    }

    public int Index { get => index; set => index = value; }
    public int Maxplace { get => maxplace; set => maxplace = value; }
    //public List<Item> Items { get => items; set => items = value; }
}