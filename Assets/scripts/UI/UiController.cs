using TMPro;
using UnityEngine;


namespace UI
{
    public class UiController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinText;

        public void SetCoinText(int newCoin)
        {
            _coinText.text = newCoin.ToString();
        }
    }
}