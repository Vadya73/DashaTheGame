using UnityEngine;

namespace CodeBase
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private GameObject _itemsContaner;
        private void Start()
        {
            Inventory.Inventory.I.ItemsContainer = _itemsContaner;
        }
    }
}