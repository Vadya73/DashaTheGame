using System;
using UnityEngine;

namespace CodeBase.Inventory
{
    public class InventoryAddComponent : MonoBehaviour
    {
        [SerializeField] private InventoryItem _item;
        private void OnMouseDown()
        {
            Inventory.I.AddItem(_item);
        }
    }
}