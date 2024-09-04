using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int vies = 3;

    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }
    public Brick[] bricks { get; private set; }


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        ball = FindObjectOfType<Ball>();
        paddle = FindObjectOfType<Paddle>();
        bricks = FindObjectsOfType<Brick>();
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.vies = 3;

        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level=level;
        SceneManager.LoadScene("Level"+level);
    }

     public void Hit(Brick brick)
    {
        score += brick.points;

        if (Cleared()) {
            LoadLevel(level + 1);
        }
    }

    public void Miss(){
        this.vies --;
        if (vies > 0) {
            ResetLevel();
        } else {
            GameOver();
        }
    }

    private void ResetLevel()
    {
        paddle.ResetPaddle();
        ball.ResetBall();

        // Resetting the bricks is optional
        // for (int i = 0; i < bricks.Length; i++) {
        //     bricks[i].ResetBrick();
        // }
    }

     private void GameOver()
    {
        // Start a new game immediately
        // You can also load a "GameOver" scene instead
        Time.timeScale = 0;
        GameOverManager.instance.OnPlayerDeath();
     }

    private bool Cleared()
    {
        for (int i = 0; i < bricks.Length; i++)
        {
            if (bricks[i].gameObject.activeInHierarchy && !bricks[i].unbreakable) {
                return false;
            }
        }

        return true;
    }
}
