using ContentLib.EnemyAPI.Model.Enemy;

namespace ContentLib.Core.Model.Event;

public abstract class BrackenSeenByPlayerEvent : IMonsterEvents
{
    /// <inheritdoc />
    public abstract IEnemy Enemy { get; }
}