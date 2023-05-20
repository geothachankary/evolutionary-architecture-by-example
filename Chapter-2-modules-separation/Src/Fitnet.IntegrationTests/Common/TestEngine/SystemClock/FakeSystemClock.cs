using EvolutionaryArchitecture.Fitnet.Common.Api.SystemClock;

namespace EvolutionaryArchitecture.Fitnet.IntegrationTests.Common.TestEngine.SystemClock;

internal sealed class FakeSystemClock : ISystemClock
{
    public FakeSystemClock(DateTimeOffset fakeDateTimeOffset) => Now = fakeDateTimeOffset;

    public DateTimeOffset Now { get; }
}