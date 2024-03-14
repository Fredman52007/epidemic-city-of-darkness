using UI;
using UnityEngine;


namespace Resurs
{
    public class Resurses : MonoBehaviour
    {
        [SerializeField] private int _coin;
        private UiController _ui;

        private void Awake()
        {
            _ui = FindObjectOfType<UiController>();
        }

        public void AddCoin()
        {
            _coin++;
            _ui.SetCoinText(_coin);
        }
    }
}