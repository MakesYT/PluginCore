using System;
using System.Collections.Generic;

namespace KitopiaEx;

public class ObservableValue : IObservable<object>
{
    public ObservableValue()
    {
        observers = new List<IObserver<object>>();
    }

    private List<IObserver<object>> observers;

    public IDisposable Subscribe(IObserver<object> observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);
        return new Unsubscriber(observers, observer);
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<object>> _observers;
        private IObserver<object> _observer;

        public Unsubscriber(List<IObserver<object>> observers, IObserver<object> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }


    public void SetValue(object? loc)
    {
        foreach (var observer in observers)
        {
            observer.OnNext(loc);
        }
    }

    public void EndTransmission()
    {
        foreach (var observer in observers.ToArray())
            if (observers.Contains(observer))
                observer.OnCompleted();

        observers.Clear();
    }
}