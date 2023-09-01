using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
   private float leftBounds = -15;
   private PlayerController _playerControllerRef;
   public float speed;

   private void Start()
   {
      _playerControllerRef = FindObjectOfType<PlayerController>();
   }

   private void Update()
   {
      if (_playerControllerRef.IsGameOver == false)
      {
         transform.Translate(Vector3.left * Time.deltaTime * speed);
      }

      if (transform.position.x < leftBounds && gameObject.CompareTag("Obstacle"))
      {
         Destroy(gameObject);
      }
   }
}
