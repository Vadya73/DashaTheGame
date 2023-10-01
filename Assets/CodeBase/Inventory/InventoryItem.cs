using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace CodeBase.Inventory
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Items")]
    public class InventoryItem : ScriptableObject
    {
        [SerializeField] public string ID;
        [SerializeField] public Sprite Sprite;
    }
}