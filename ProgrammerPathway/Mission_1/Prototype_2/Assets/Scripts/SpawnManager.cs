using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
   public static SpawnManager Instance;

   public Text _scoreText;
   public Text _livesText;
   public int score;
   public int totalLives;
   
   public List<GameObject> animalsPrefabs;
   public List<GameObject> animalPrefabsSide;
   private float _lowerInstantiateLimit = -11f;
   private float _higherInstantiateLimit = 11f;
   private float _lowerSideInstantiateLimit = 14f;
   private float _higherSideInstantiateLimit = 1f;
   private float _startDelay = 2f;
   private float _instantiateInterval = 1.5f;

   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this;
      }
   }

   private void Start()
   {
      InvokeRepeating("SpawnRandomAnimalFromFront",_startDelay,_instantiateInterval);
      InvokeRepeating("SpawnRandomAnimalFromSide",_startDelay,_instantiateInterval);
   }

   private void SpawnRandomAnimalFromFront()
   {
      var _instantiatePosition = Random.Range(_lowerInstantiateLimit, _higherInstantiateLimit);
      var _randomAnimal = Random.Range(0, animalsPrefabs.Count);
      Instantiate(animalsPrefabs[_randomAnimal], new Vector3(_instantiatePosition, 0f, 20f), animalsPrefabs[_randomAnimal].transform.rotation);  
   }

   private void SpawnRandomAnimalFromSide()
   {
      var _instantiatePosition = Random.Range(_lowerSideInstantiateLimit, _higherSideInstantiateLimit);
      var _randomAnimal = Random.Range(0, animalsPrefabs.Count);
      Instantiate(animalPrefabsSide[_randomAnimal], new Vector3(-21f, 0f, _instantiatePosition),animalPrefabsSide[_randomAnimal].transform.rotation);  
   }
   
}
