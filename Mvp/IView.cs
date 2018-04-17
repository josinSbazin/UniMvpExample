namespace Mvp
{
    public interface IView<V, P>
        where V : IView<V, P>
        where P : IPresenter<V, P>
    { }
}