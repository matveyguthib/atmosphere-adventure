using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}