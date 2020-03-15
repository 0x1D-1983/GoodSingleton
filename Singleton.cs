using System;

namespace GoodSingleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazySingleton = new Lazy<Singleton>(
            () => new Singleton()
        );

        public Singleton Instance => lazySingleton.Value;

        private Singleton()
        {

        }
    }
}