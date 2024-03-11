using UnityEngine;
using UnityEngine.SceneManagement;

namespace Enemies
{ 
    public class FightStarter : MonoBehaviour
    {
        [SerializeField] private string _sceneName;

        private void OnTriggerEnter2D(Collider2D other)
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}