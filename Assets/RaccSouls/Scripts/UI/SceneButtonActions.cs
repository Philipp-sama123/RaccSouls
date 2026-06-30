using UnityEngine;
using UnityEngine.SceneManagement;

namespace RaccSouls.UI
{
    public class SceneButtonActions : MonoBehaviour
    {
        public void RestartCurrentScene()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
