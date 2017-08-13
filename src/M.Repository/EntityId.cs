namespace M.Repository
{
    /// <summary>
    /// Represents a strongly typed identifier of an entity.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TKey">The type of the entity identifier.</typeparam>
    public abstract class EntityId<TEntity, TKey> where TEntity : IEntity
    {
        /// <summary>
        /// Creates a new instance of the EntityId class.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        public EntityId(TKey id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets an entity identifier.
        /// </summary>
        public TKey Id { get; private set; }
    }
}
