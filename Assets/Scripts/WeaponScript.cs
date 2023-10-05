using System;
using UnityEngine;
namespace AlexzanderCowell
{
    public class WeaponScript : MonoBehaviour
    {
        private int weaponSelection;
        [SerializeField] private GameObject bombPrefab;
        [SerializeField] private GameObject stickPrefab;
        private GameObject _thePreFabToSpawn;
        private Vector3 _mousePosition;
        public static bool stickInScene;


        private void Start()
        {
            weaponSelection = 0;
        }

        private void Update()
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            Debug.Log("What Weapon Has Been Chosen? " + weaponSelection);
            
            if (weaponSelection == 0)
            {
                _thePreFabToSpawn = null;
            }
            else if (weaponSelection == 1)
            {
                _thePreFabToSpawn = stickPrefab;
            }
            else
            {
                _thePreFabToSpawn = bombPrefab;
            }
            
            if (Input.GetMouseButtonDown(0) && !stickInScene)
            {
                Spawning();
            }

            if (weaponSelection == 0 || weaponSelection == 2)
            {
                stickInScene = false;
            }
            
        }

        private void Spawning()
        {
            Vector3 offsetPosition = new Vector3(0, 0, 10);
            Instantiate(_thePreFabToSpawn, _mousePosition + offsetPosition, Quaternion.identity);

            if (weaponSelection == 1)
            {
                stickInScene = true;
            }
        }
        
        public void NothingButton()
        {
            weaponSelection = 0;
        }
        
        public void StickButton()
        {
            weaponSelection = 1;
        }
        
        public void BombButton()
        {
            weaponSelection = 2;
        }
    }
}
