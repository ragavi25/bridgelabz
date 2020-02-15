using DesiginPattern.BehavioralDesignPatterns.ObserverDesignPattern;

namespace DesiginPattern.BehavioralDesignPatterns
{
    public interface IObservers
    {
        public void Uptate();
        public void setSubject(ISubject subject);
    }
}