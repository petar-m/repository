namespace M.Repository
{
    public abstract class Entity<TKey> : IEntity
    {
        public TKey Id { get; set; }

        object IEntity.Id => Id;
    }
}
