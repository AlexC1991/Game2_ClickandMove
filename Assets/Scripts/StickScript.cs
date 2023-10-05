using UnityEngine;
namespace AlexzanderCowell
{
    public class StickScript : MonoBehaviour
    {
        private Vector2 mousePosition;
        void Update()
        {

            if (WeaponScript.stickInScene)
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePosition;
            }
            else if (!WeaponScript.stickInScene)
            {
                Destroy(gameObject);
            }

        }
    }
}
