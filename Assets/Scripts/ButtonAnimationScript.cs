using System;
using UnityEngine;

namespace AlexzanderCowell
{
    public class ButtonAnimationScript : MonoBehaviour
    {
        private Animator _animation;
        
        private void Awake()
        {
            _animation = GetComponent<Animator>();
        }

        public void PlayTheAnimation()
        {
            _animation.SetBool("ButtonPressed", true);
        }

        public void DoNotPlayTheAnimation()
        {
            _animation.SetBool("ButtonPressed", false);
        }

        private void Update()
        {
            Debug.Log(_animation.GetBool("ButtonPressed"));
        }
    }
}
