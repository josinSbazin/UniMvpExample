using Fight.Scripts.Presenter;
using Mvp;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Fight.Scripts.View
{
    public class SinusoidButtonView : ViewBase<SinusoidButtonView, SinusoidButtonPresenter>, IPointerDownHandler,
        IPointerUpHandler
    {
        public Id ButtonId;

        public enum Id
        {
            Left,
            Right
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Presenter.OnPress(ButtonId);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Presenter.OnRelease(ButtonId);
        }
    }
}