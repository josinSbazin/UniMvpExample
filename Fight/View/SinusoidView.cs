using Fight.Scripts.Presenter;
using Mvp;
using UnityEngine;

namespace Fight.Scripts.View
{
    public class SinusoidView : ViewBase<SinusoidView, SinusoidPresenter>
    {
        private RectTransform _sinTransform;
        private Vector2 _sinStartPosition;
        private float _sinWidth;

        protected override void Awake()
        {
            base.Awake();
            _sinTransform = (RectTransform) transform;
            _sinStartPosition = _sinTransform.anchoredPosition;
            _sinWidth = _sinTransform.rect.width;
        }

        public void SetPosition(float position)
        {
            float newPosition = position * _sinWidth;
            _sinTransform.anchoredPosition = _sinStartPosition + Vector2.right * newPosition;
        }
    }
}