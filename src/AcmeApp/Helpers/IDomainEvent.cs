using System;

namespace AcmeApp.Helpers
{
    public interface IDomainEvent
    {
        int Versao { get; }
        DateTime DataOcorrencia { get; }
    }
}
