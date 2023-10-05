using UnityEngine;
using UnityEngine.UI;
namespace AlexzanderCowell
{
    public class InGameMenuScript : MonoBehaviour
    {
        [SerializeField] private Slider ragdollSlider;
       [SerializeField] private Text ragdollNumberText;
        private float maxRagdollValue = 200;
        public static float currentValue;
        private float minRagdollValue = 3;
        private void Start()
        {
            ragdollSlider.GetComponent<Slider>().maxValue = maxRagdollValue;
            ragdollSlider.GetComponent<Slider>().minValue = minRagdollValue;
            ragdollSlider.GetComponent<Slider>().value = minRagdollValue;
        }
        private void Update()
        {
            currentValue = ragdollSlider.GetComponent<Slider>().value;
            ragdollNumberText.text = currentValue.ToString("0");
        }
        
        
        
    }
}

