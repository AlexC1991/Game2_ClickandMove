using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AlexzanderCowell
{
    public class DrawScriptOne : MonoBehaviour
    {
        [SerializeField] private Canvas _canvas;
        [SerializeField] private float minXValue;
        [SerializeField] private float maxXValue;
        private float _currentYValue;

        private void Start()
        {
            _currentYValue = transform.position.x;
        }

        public void DragHandler(BaseEventData data)
        {
            PointerEventData pointerData = (PointerEventData)data;

            Vector2 position;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                (RectTransform)_canvas.transform,
                pointerData.position,_canvas.worldCamera,out position);
               position.x = Mathf.Clamp(position.x, minXValue, maxXValue);
               position.y = _currentYValue;
                transform.position = _canvas.transform.TransformPoint(position);
        }

    }
}
