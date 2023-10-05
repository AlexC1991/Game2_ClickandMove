using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace AlexzanderCowell
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject ballPrefab;
        [SerializeField] private Transform ballSpawnPoint;
        private int _ballCountTracker;
        [SerializeField] private Text ballCountText;
        private GameObject _ragDoll;
        private float _ragDollNumber;
        [SerializeField] private GameObject ragDollParent;
        private bool _deleteRagDollChild;
        [SerializeField] private GameObject humanPrefab;
        [SerializeField] private GameObject frogPrefab;
        private int _prefabSelector;
        private GameObject _prefab;
        
        private void SpawnBall()
        {
            _ragDoll = Instantiate(_prefab, ballSpawnPoint.position, Quaternion.identity);
            _ragDollNumber = Random.Range(1, 9999999);
            _ragDoll.name = "RagDoll" + _ragDollNumber;
            _ragDoll.transform.parent = ragDollParent.transform;
        }

        private void FixedUpdate()
        {
            _ballCountTracker = ragDollParent.transform.childCount;
           
            /*if (_ballCountTracker > InGameMenuScript.currentValue + 1)
            {
                _deleteRagDollChild = true;
            }

            while (_deleteRagDollChild && _ballCountTracker > InGameMenuScript.currentValue)
            {
                Destroy(ragDollParent.transform.GetChild(0).gameObject);
            }*/
        }

        private void Update()
        {
            ballCountText.text = "Total In Scene" + "\n" + _ballCountTracker + "/" + InGameMenuScript.currentValue.ToString("0");

            /*if (_ballCountTracker <= InGameMenuScript.currentValue)
            {
                _deleteRagDollChild = false;
            }*/
            
            if (_prefabSelector == 0)
            {
                _prefab = ballPrefab;
            }
            else if (_prefabSelector == 1)
            {
                _prefab = humanPrefab;
            }
            else if (_prefabSelector == 2)
            {
                _prefab = frogPrefab;
            }
        }

        public void BallButton()
        {
            if (_ballCountTracker <= InGameMenuScript.currentValue)
            {
                SpawnBall();
            }
            else
            {
                Debug.Log("MaxBalls Reached");
            }
        }

        public void DeleteAllChildren()
        {
            foreach (Transform child in ragDollParent.transform)
            {
                Destroy(child.gameObject);
            }
            
        }

        public void BallPreFabSpawn()
        {
            _prefabSelector = 0;
        }
        
        public void HumanPreFabSpawn()
        {
            _prefabSelector = 1;
        }
        
        public void FrogPreFabSpawn()
        {
            _prefabSelector = 2;
        }
    }
}
