namespace Mvp
{
    public interface IPresenter<V, P>
        where V : IView<V, P>
        where P : IPresenter<V, P>
    {
        void Init(V view);
    }
}