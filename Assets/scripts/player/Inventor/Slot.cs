using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Inventor
{
    public class Slot : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private Button _dropButton;
        [SerializeField] private TextMeshProUGUI _itemName;

        public Item item;



        public void AddItem(Item newItem)
        {
            item = newItem;
            _icon.sprite = item.icon;
            _icon.enabled = true;
            _dropButton.interactable = true;

            _itemName.text = item.name;
            UpdateSlot();
        }

        public void ClearSlot()
        {
            item = null;
            _icon.sprite = null;
            _icon.enabled = false;
            _itemName.text = "";
            _dropButton.interactable = false;
        }

        public void UpdateSlot()
        {
            if (item != null)
            {
                _icon.sprite = item.icon;
                _icon.enabled = true;
                _itemName.text = item.name;
                _dropButton.interactable = true;
            }
            else
            {
                _icon.sprite = null;
                _icon.enabled = false;
                _itemName.text = "";
                _dropButton.interactable = false;
            }
        }

        public void OnDropButton()
        {
            Inventory.instance.RemoveItem(item);

            SpawnItem(item.dropPrefab);
            ClearSlot();
        }

        private void SpawnItem(GameObject itemPrefab)
        {
            GameObject spawnPoint = GameObject.FindGameObjectWithTag("PointItem");
            if (spawnPoint != null)
            {
                Instantiate(itemPrefab, spawnPoint.transform.position, quaternion.identity);
            }
            
        }

        /*public void UseItem()
        {
            item.UseItem();
            ClearSlot();
        }*/

    }
    
    
}