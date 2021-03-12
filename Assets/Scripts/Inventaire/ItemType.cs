using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Permet de créer un type d'objet pour l'assigner à un slot

[CreateAssetMenu(fileName = "ItemType", menuName = "Inventaire/ItemType")]
public class ItemType : ScriptableObject
{
    public int id;
    public int categorie;
    public string nom, description, nomcategorie;
    public Sprite ItemTypeSprite;

    public ItemType(int _id, int _categorie, string _nom, string _description)
    {
        this.id = _id;
        this.nom = _nom;
        this.description = _description;
        switch(categorie)
        {
            case 0:
                {
                    this.nomcategorie = "basique";
                    break;
                }
        }
    }

    public int Id { get => id; set => id = value; }
    public int Categorie { get => categorie; set => categorie = value; }
    public string Nom { get => nom; set => nom = value; }
    public string Description { get => description; set => description = value; }
    public string Nomcategorie { get => nomcategorie; set => nomcategorie = value; }
    //public Sprite Image { get => image; set => image = value; }
}
