using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SpawnManager.Instance.score++;
        SpawnManager.Instance._scoreText.text = "Score  " + SpawnManager.Instance.score;
        if (other.GetComponent<DestroyOutOfBounds>().gameObjectSliderEnemy)
        {
            other.GetComponent<DestroyOutOfBounds>().gameObjectSliderEnemy.value += 0.33f;
            if (other.GetComponent<DestroyOutOfBounds>().gameObjectSliderEnemy.value > 0.95f)
            {
                other.GetComponent<DestroyOutOfBounds>().gameObjectSliderEnemy.value = 1.0f;
                Destroy(other.gameObject);
            }
        }

        else
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
