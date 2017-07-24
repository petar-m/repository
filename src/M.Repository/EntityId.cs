namespace M.Repository
{
    public abstract class EntityId<TEntity, TKey> where TEntity : IEntity
    {
        public EntityId(TKey id)
        {
            Id = id;
        }

        public TKey Id { get; private set; }
    }
}
