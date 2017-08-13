namespace M.Repository
{
    /// <summary>
    /// A base class for entities managed by IRepository.
    /// </summary>
    /// <typeparam name="TKey">The type of the entity id.</typeparam>
    public abstract class Entity<TKey> : IEntity
    {
        /// <summary>
        /// Gets or sets an id that uniquely identifies the entity.
        /// </summary>
        public TKey Id { get; set; }

        /// <summary>
        /// Gets an id that uniquely identifies the entity.
        /// </summary>
        object IEntity.Id => Id;
    }
}
