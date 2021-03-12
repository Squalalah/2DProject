using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public Transform pfObjetSol;
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}
