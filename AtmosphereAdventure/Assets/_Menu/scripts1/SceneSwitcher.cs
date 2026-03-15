using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadScene(string theGame)
    {
        SceneManager.LoadScene(theGame);
    }
}