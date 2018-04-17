using UnityEngine;

namespace Mvp
{
    public abstract class ViewBase<V, P> : MonoBehaviour, IView<V, P>
        where V : class, IView<V, P>
        where P : IPresenter<V, P>, new()
    {
        protected P Presenter;

        protected virtual P ProvidePresenter()
        {
            P presenter = new P();
            presenter.Init(this as V);
            return presenter;
        }

        protected virtual void Awake()
        {
            Presenter = ProvidePresenter();
        }
    }
}