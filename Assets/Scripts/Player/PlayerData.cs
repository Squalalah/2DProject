using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public int index;
    public string nom;
    public int argent;
    public Inventaire inventaire;
    public int maxplace;
    public Text nomText;
    public Item itemtest;
    private GameObject inventaireBox;
    private GameObject[] inventairerapide;
    [SerializeField] private UI_Inventaire ui_inventaire;

    void Start()
    {
        this.inventaire = new Inventaire(0, 36);
        nomText.text = this.nom;
        inventaireBox = GameObject.FindGameObjectWithTag("InventaireBox");
        inventairerapide = GameObject.FindGameObjectsWithTag("InventaireRapide");
        inventaireBox.SetActive(false);
        ui_inventaire.SetInventaire(this.inventaire);
        ItemSolEvent.SpawnObjet(new Vector3(-1, 3), itemtest);
        ItemSolEvent.SpawnObjet(new Vector3(5, 5), itemtest);

    }

    void Awake()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            inventaireBox.SetActive(!inventaireBox.activeSelf);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemSolEvent itemSol = collision.GetComponent<ItemSolEvent>();
        if (itemSol != null)
        {
            inventaire.AddItem(itemSol.GetItem());
            itemSol.AutoDestruction();
        }
    }
}
