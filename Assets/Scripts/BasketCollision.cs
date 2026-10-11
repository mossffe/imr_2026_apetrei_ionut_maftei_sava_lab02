using UnityEngine;

public class BasketCollision : MonoBehaviour
{
    GameManager gameManager = null;

    void Start()
    {
        gameManager = GameManager.GetInstance();
        Debug.Assert(gameManager != null);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            gameManager.AddPlayerScore(10);

            // TODO: Sava do distance gogo
        }
    }
}