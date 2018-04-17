
using Fight.Scripts.View;
using Mvp;
using UnityEngine;

namespace Fight.Scripts.Presenter
{
    public class SinusoidButtonPresenter : PresenterBase<SinusoidButtonView, SinusoidButtonPresenter>
    {
        public void OnPress(SinusoidButtonView.Id id)
        {
            Debug.Log(id + "OnPress");
        }

        public void OnRelease(SinusoidButtonView.Id id)
        {
            Debug.Log(id + "OnRelease");
        }
    }
}