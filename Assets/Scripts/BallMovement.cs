using System;
using UnityEngine;

namespace AlexzanderCowell
{
    public class BallMovement : MonoBehaviour
    {
        [SerializeField] private float forceAdded;
        private Rigidbody2D _rigidbody;
        private bool _hitWall;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            // If the ball hits the wall, set the bool to true
            if (other.CompareTag("Wall"))
            {
                _hitWall = true;
            }
        }
        
        private void OnMouseDown()
        {
            Cursor.lockState = CursorLockMode.Confined;
            
            // Add force to the ball depending on location of mouse click
            if (Input.mousePosition.x < Screen.width / 2 || FrogScript.addSuddonForce && BombScript.explodingTime <= 0)
            {
                _rigidbody.AddForce(Vector3.left * forceAdded, ForceMode2D.Impulse);
            }
            else if (Input.mousePosition.y < Screen.width / 2)
            {
                _rigidbody.AddForce(Vector3.up * forceAdded, ForceMode2D.Impulse);
            }
            else
            {
                _rigidbody.AddForce(Vector3.right * forceAdded, ForceMode2D.Impulse);
            }
        }

        private void Update()
        {
            // Every time the ball hits the wall it will change to a random color.
            if (_hitWall)
            {
                GetComponent<SpriteRenderer>().color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
                _hitWall = false;
            }
        }

        private void OnMouseUp()
        {
            Cursor.lockState = CursorLockMode.None;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            // If the ball hits the wall, set the bool to true
            if (other.CompareTag("Wall"))
            {
                _hitWall = false;
            }
        }
        
    }
}
