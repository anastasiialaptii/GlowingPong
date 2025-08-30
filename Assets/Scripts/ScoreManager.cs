using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int _p1Score = 0;
    private int _p2Score = 0;
    private int _scoreToReach = 3;

    public Text p1ScoreText;
    public Text p2ScoreText;

    public void ChangePlayer1Score()
    {
        _p1Score++;
        p1ScoreText.text = _p1Score.ToString();
        CheckScore();
    }

    public void ChangePlayer2Score()
    {
        _p2Score++;
        p2ScoreText.text = _p2Score.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if(_p1Score == _scoreToReach || _p2Score == _scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
