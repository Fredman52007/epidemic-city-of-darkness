using UnityEditor;
using UnityEngine;

namespace Inventor
{
    public class PickUp : MonoBehaviour
    {
        public Item _item;


        private void OnTriggerEnter2D(Collider2D other)
        {
             /*if (gameObject.TryGetComponent( player ))
            {
                
                
            }*/
            PickUps();
        }

        private void PickUps()
        {
            bool wasPickUp = Inventory.instance.AddItem(_item);

            if (wasPickUp)
            {
                Destroy(gameObject);
            }
        }
    }
}