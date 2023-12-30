using UnityEngine.SceneManagement;
using UnityEngine;

public class Switch2Level : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
