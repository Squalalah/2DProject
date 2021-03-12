using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSolEvent : MonoBehaviour
{
    private Item item;
    private SpriteRenderer spriteRenderer;
    public static ItemSolEvent SpawnObjet(Vector3 position, Item _item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.pfObjetSol, position, Quaternion.identity);
        ItemSolEvent itemsolobject = transform.GetComponent<ItemSolEvent>();
        itemsolobject.SetItem(_item);
        return itemsolobject;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetItem(Item _item)
    {
        this.item = _item;
        spriteRenderer.sprite = this.item.ObtenirSprite();
    }

    public Item GetItem()
    {
        return this.item;
    }

    public void AutoDestruction()
    {
        Destroy(gameObject);
    }
}
