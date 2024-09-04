using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameManager gameManager;

    public static GameOverManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'un instance de GameOverManager");
            return;
        }
        instance = this;
    }

    public void OnPlayerDeath()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestroyOnLoad();
        gameOverUI.SetActive(true);
    }

    public void RetryButton()
    {
        gameManager.score = 0;
        gameManager.vies = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        gameOverUI.SetActive(false);
    }
    public void MainMenuButton()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("MainMenu");
        gameOverUI.SetActive(false);

    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
