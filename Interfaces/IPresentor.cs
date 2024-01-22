using System;

namespace EmptyMVP
{
    public interface IPresentor<V, M> : IDisposable
        where V : class, IView
        where M : class, IModel
    {
        V View { get; }
        M Model { get; }
    }
}
