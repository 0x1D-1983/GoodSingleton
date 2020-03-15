using System;

namespace GoodSingleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazySingleton = new Lazy<Singleton>(
            () => new Singleton(), true
        );

        public static Singleton Instance => lazySingleton.Value;

        private Singleton() { }
    }
}