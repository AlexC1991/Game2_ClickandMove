using UnityEngine;
namespace AlexzanderCowell
{
    public class BombScript : MonoBehaviour
    {
        private float _countDown = 2;
        private Animator _animator;
        public static float explodingTime;
        
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
        private void Update()
        {
            _countDown -= Time.deltaTime;
            if (_countDown <= 0)
            {
                _animator.SetBool("Explode", true);
                
                explodingTime = _animator.GetCurrentAnimatorStateInfo(0).length;
                
                if (explodingTime < 0.6f)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}