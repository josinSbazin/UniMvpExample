namespace Mvp
{
    public abstract class PresenterBase<V, P> : IPresenter<V, P>
        where V : IView<V, P>
        where P : IPresenter<V, P>
    {
        protected V View;
        public virtual void Init(V view)
        {
            View = view;
        }
    }
}