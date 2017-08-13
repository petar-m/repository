namespace M.Repository
{
    /// <summary>
    /// Represents an entity uniquely identifiable by id.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets an id that uniquely identifies the entity.
        /// </summary>
        object Id { get; }
    }
}
