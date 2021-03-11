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
    public Text nomText;

    void Start()
    {
        this.inventaire = new Inventaire(0, 36);
        nomText.text = this.nom;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
