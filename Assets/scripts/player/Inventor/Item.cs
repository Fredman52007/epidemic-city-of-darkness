using UnityEngine;

namespace Inventor
{
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

    public class Item : MonoBehaviour
    {
        public int id;
        public string name;
        public Sprite icon;
        public GameObject dropPrefab;
        public Slot slot;

        public enum ItemType
        {
            coin,
        }

        public ItemType type;
        
       
    }
}