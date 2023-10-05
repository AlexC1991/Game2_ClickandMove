using System;
using UnityEngine;
namespace AlexzanderCowell
{
    public class UIControlScript : MonoBehaviour
    {
        [Header("UI Control")] 
        [SerializeField] private GameObject inGameMenuUI;
        [SerializeField] private GameObject startMenuUI;
        [SerializeField] private GameObject menuButton;
        [SerializeField] private GameObject bodyCounterUI;
        [SerializeField] private GameObject drawAUI;
        [SerializeField] private GameObject drawBUI;
        [SerializeField] private GameObject spawnButtonUI;


        private void Start()
        {
            inGameMenuUI.SetActive(false);
            startMenuUI.SetActive(true);
            menuButton.SetActive(false);
            bodyCounterUI.SetActive(false);
            drawAUI.SetActive(false);
            drawBUI.SetActive(false);
            spawnButtonUI.SetActive(false);
        }

        public void StartGameButton()
        {
            inGameMenuUI.SetActive(false);
            startMenuUI.SetActive(false);
            menuButton.SetActive(true);
            bodyCounterUI.SetActive(true);
            drawAUI.SetActive(true);
            drawBUI.SetActive(true);
            spawnButtonUI.SetActive(true);
        }
        
        public void InGameMenuButton()
        {
            inGameMenuUI.SetActive(true);
            startMenuUI.SetActive(false);
            menuButton.SetActive(false);
            bodyCounterUI.SetActive(false);
            drawAUI.SetActive(false);
            drawBUI.SetActive(false);
            spawnButtonUI.SetActive(false);
        }
    }
}
