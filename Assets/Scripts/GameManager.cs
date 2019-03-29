using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public void EndGame()
    {
        Debug.Log("Game OVER");
        Invoke("Restart", restartDelay);

    }

    void Restart()
    {
        SceneManager.LoadScene("GameOver");
    }
 

}
