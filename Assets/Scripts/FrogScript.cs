using System;
using UnityEngine;
namespace AlexzanderCowell
{
    public class FrogScript : MonoBehaviour
    {
        private Vector3 _mousePosition;
        private Rigidbody2D _rigidbody;
        private bool _isBeingDragged;
        public static bool addSuddonForce;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Weapon"))
            {
                addSuddonForce = true;
            }
        }

        private void Update()
        {
            if (addSuddonForce || BombScript.explodingTime <= 0)
            {
                _rigidbody.AddForce(Vector3.up * 100, ForceMode2D.Impulse);
            }
        }

        private void OnMouseDown()
        {
            _isBeingDragged = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void OnMouseUp()
        {
            _isBeingDragged = false;
            Cursor.lockState = CursorLockMode.None;
        }

        private void OnMouseDrag()
        {
            _isBeingDragged = true;
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _rigidbody.MovePosition(new Vector2(_mousePosition.x, _mousePosition.y));
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Weapon"))
            {
                addSuddonForce = false;
            }
        }
    }
}
