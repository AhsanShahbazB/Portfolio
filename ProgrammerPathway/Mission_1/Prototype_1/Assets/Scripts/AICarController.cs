using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarController : MonoBehaviour
{
       private float speedPlayer = 5f;
       void Update()
       {
           transform.Translate(Vector3.forward * Time.deltaTime * speedPlayer);
       }
}
