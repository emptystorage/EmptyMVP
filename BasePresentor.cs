﻿using System;

namespace EmptyMVP
{
    public abstract class BasePresentor<V, M> : IPresentor<V, M>
        where V : class, IView
        where M : class, IModel
    {
        public BasePresentor(V view, M model)
        {
            View = view;
            Model = model;
        }

        protected V View { get; }
        protected M Model { get; }

        public void Dispose()
        {
            OnDispose();
            Model.Dispose();
            GC.SuppressFinalize(this);
        }

        protected abstract void OnDispose();
    }
}
