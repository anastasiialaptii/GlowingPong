using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameObject hitSFX;

    public BallMovement ballMovement;
    public ScoreManager scoreManager;

    private void Bounce(Collision2D collision)
    {
        var ballPos = transform.position;
        var racketPos = collision.transform.position;
        var racketHeight = collision.collider.bounds.size.y;

        float posX;

        if (collision.gameObject.name == "Player1")
        {
            posX = 1;
        }
        else
        {
            posX = -1;
        }

        float posY = (ballPos.y - racketPos.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(posX, posY));
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            Bounce(collision);
        }
        else if (collision.gameObject.name == "RightBorder")
        {
            scoreManager.ChangePlayer1Score();
            ballMovement.isPlayer1Starting = false;
            StartCoroutine(ballMovement.Launch());
        }
        else if (collision.gameObject.name == "LeftBorder")
        {
            scoreManager.ChangePlayer2Score();
            ballMovement.isPlayer1Starting = true;
            StartCoroutine(ballMovement.Launch());
        }

        Instantiate(hitSFX);
    }
}
