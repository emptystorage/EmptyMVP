using System;

namespace EmptyMVP
{
    public interface IPresentor<V, M> : IDisposable
        where V : class, IView
        where M : class, IModel
    {
    }
}
