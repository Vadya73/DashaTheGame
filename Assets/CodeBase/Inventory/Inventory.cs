using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace CodeBase.Inventory
{
    public class Inventory : MonoBehaviour
    {
        public static Inventory I;

        public GameObject ItemsContainer;
        [SerializeField] private InvenotyItemUI _itemPrefab;
        [SerializeField] private List<InventoryItem> _items;

        private void Awake()
        {
            if (I == null)
            {
                I = this;
            }
            else if (I == this)
            {
                Destroy(gameObject);
            }
        }

        public void AddItem(InventoryItem item)
        {
            _items.Add(item);
            UpdateUI(item);
        }

        public void DeleteItem(InventoryItem item)
        {
            foreach (var currentItem in _items)
            {
                if (item == currentItem) _items.Remove(currentItem);
                else return;
            }
        }

        private void UpdateUI(InventoryItem item)
        {
            var instItem = Instantiate(_itemPrefab, ItemsContainer.transform, true);
            instItem.GetComponent<InvenotyItemUI>().UpdateInfo(item.Sprite,1);
        }
    }
}