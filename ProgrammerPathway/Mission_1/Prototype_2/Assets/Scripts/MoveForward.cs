using UnityEngine;

public class MoveForward : MonoBehaviour
{
   public float speedFood; 
   private void Update()
   {
      transform.Translate(Vector3.forward * Time.deltaTime * speedFood);
   }
}
