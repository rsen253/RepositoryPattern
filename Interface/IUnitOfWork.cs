using System;

namespace Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICourceRepository Course { get; }
        int Complete();
    }
}
