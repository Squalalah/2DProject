using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventaire : MonoBehaviour
{
    private Inventaire inventaire;
    private GameObject[] slotInventaire;
    private GameObject[] slotInventaireImage;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Awake()
    {
        slotInventaire = GameObject.FindGameObjectsWithTag("InventaireSlots");
        slotInventaireImage = GameObject.FindGameObjectsWithTag("InventaireImage");
    }

    public void SetInventaire(Inventaire _inventaire)
    {
        this.inventaire = _inventaire;
        this.inventaire.OnObjetAjouterEvent += new QuandObjetAjouter(Inventaire_QuandObjetAjouterEvent);
        this.inventaire.OnObjetRetirerEvent += new QuandObjetRetirer(Inventaire_QuandObjetRetirerEvent);
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        Dictionary<int, Item> inv = inventaire.GetInventaireItemsPlace();
        for (int i = 0; i < inventaire.Maxplace; i++)
        {
            //Debug.Log("Essai n°" + i);
            try
            {
                slotInventaireImage[i].GetComponent<Image>().sprite = inv[i].ObtenirSprite();
                slotInventaireImage[i].GetComponent<Image>().color = Color.white;
            }
            catch
            {
                slotInventaireImage[i].GetComponent<Image>().sprite = null;
            }
        }
        /*Debug.Log("nb item : " + inventaire.GetListeItem().Count);
        int i = 0;
        foreach(Item item in inventaire.GetListeItem())
        {
            Debug.Log("item name = " + item.Type.Nom);
            slotInventaireImage[item.indexplaceinventaire].GetComponent<Image>().sprite = item.ObtenirSprite();
            slotInventaireImage[item.indexplaceinventaire].GetComponent<Image>().color = Color.white;
        }*/

    }

    #region EventHandlers
    private void Inventaire_QuandObjetAjouterEvent(Item i)
    {
        slotInventaireImage[i.indexplaceinventaire].GetComponent<Image>().sprite = i.ObtenirSprite();
        slotInventaireImage[i.indexplaceinventaire].GetComponent<Image>().color = Color.white;
    }

    private void Inventaire_QuandObjetRetirerEvent(Item i, int derniereslot)
    {
        slotInventaireImage[derniereslot].GetComponent<Image>().sprite = null;
    }
    #endregion



}
