using System;
using UnityEngine;
using UnityEngine.UI;

namespace AlexzanderCowell
{
    public class BackGroundScript : MonoBehaviour
    {
        
        [SerializeField] private Sprite[] _backgrounds;
        private Image _backGroundImage;
        private int _currentBackGround;


        private void Awake()
        {
            _backGroundImage = GetComponent<Image>();
        }
        
        
        public void ChangeBackGround()
        {
            _currentBackGround++;
            if (_currentBackGround >= _backgrounds.Length)
            {
                _currentBackGround = 0;
            }
            _backGroundImage.sprite = _backgrounds[_currentBackGround];
        }
    }
}

