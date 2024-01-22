﻿using System;

namespace EmptyMVP
{
    public abstract class BasePresentor<V, M> : IPresentor<V, M>
        where V : class, IView
        where M : class, IModel
    {
        public V View { get; }

        public M Model { get; }

        public void Dispose()
        {
            OnDispose();
            Model.Dispose();
            GC.SuppressFinalize(this);
        }

        protected abstract void OnDispose();
    }
}