
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds;
    public float lowBounds;
    private float sideBounds = 21;
    public Slider gameObjectSliderEnemy;
    private void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBounds | transform.position.x > sideBounds)
        {
            SpawnManager.Instance.totalLives--;
            if (SpawnManager.Instance.totalLives <= 0)
            {
                SpawnManager.Instance._livesText.text = "Lives 0";
                Debug.Log("Game Over");
            }
            else
            {
                SpawnManager.Instance._livesText.text = "Lives " + SpawnManager.Instance.totalLives;
            }
            Destroy(gameObject);
        }

    }
}
