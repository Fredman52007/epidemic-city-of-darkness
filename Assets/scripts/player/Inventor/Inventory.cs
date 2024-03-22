using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Inventor
{
    public class Inventory : MonoBehaviour
    {
        public static Inventory instance;
        public List<Item> _items = new List<Item>();
        public List<Slot> _slots = new List<Slot>();

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }


        public bool AddItem(Item newItem)
        {
            if (newItem == null)
            {
                return false;
            }
            
            _items.Add(newItem);

            foreach (Slot slot in _slots)
            {
                if (slot.item == null)
                {
                    slot.AddItem(newItem);
                    return true;
                }
                
            }

            return false;

        }

        public void RemoveItem(Item itemToRemove)
        {
            foreach (Slot slot in _slots)
            {
                if (slot.item == itemToRemove)
                {
                    slot.UpdateSlot();
                }
            }
        }
        
    }
}