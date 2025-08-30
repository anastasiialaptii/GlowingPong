using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
