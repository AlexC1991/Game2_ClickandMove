using UnityEngine;
namespace AlexzanderCowell
{
    public class MenuScript : MonoBehaviour
    {
        private Animator _animation;

        private void Awake()
        {
            _animation = GetComponent<Animator>();
        }

        public void MenuButtonPlay()
        {
            _animation.SetBool("ButtonAnimation", true);
        }

        public void DoNotMenuButtonPlay()
        {
            _animation.SetBool("ButtonAnimation", false);
        }
    }
}
