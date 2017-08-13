using System;

namespace M.Repository
{
    /// <summary>
    /// A helper class for defining strongly typed entity identifiers.
    /// </summary>
    public static class Id
    {
        /// <summary>
        /// Creates a string entity identifier representation.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The concrete identifier.</param>
        /// <returns>A strongly typed identifier for entity of type TEntity.</returns>
        public static EntityId<TEntity, string> Of<TEntity>(string id) where TEntity : Entity<string>
        {
            return new StringId<TEntity>(id);
        }

        /// <summary>
        /// Creates an integer entity identifier representation.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The concrete identifier.</param>
        /// <returns>A strongly typed identifier for entity of type TEntity.</returns>
        public static EntityId<TEntity, int> Of<TEntity>(int id) where TEntity : Entity<int>
        {
            return new IntId<TEntity>(id);
        }

        /// <summary>
        /// Creates a GUID entity identifier representation.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The concrete identifier.</param>
        /// <returns>A strongly typed identifier for entity of type TEntity.</returns>
        public static EntityId<TEntity, Guid> Of<TEntity>(Guid id) where TEntity : Entity<Guid>
        {
            return new GuidId<TEntity>(id);
        }

        /// <summary>
        /// Creates a long entity identifier representation.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="id">The concrete identifier.</param>
        /// <returns>A strongly typed identifier for entity of type TEntity.</returns>
        public static EntityId<TEntity, long> Of<TEntity>(long id) where TEntity : Entity<long>
        {
            return new LongId<TEntity>(id);
        }

        class StringId<TEntity> : EntityId<TEntity, string> where TEntity : IEntity
        {
            public StringId(string id) : base(id)
            {
            }
        }

        class IntId<TEntity> : EntityId<TEntity, int> where TEntity : IEntity
        {
            public IntId(int id) : base(id)
            {
            }
        }

        class GuidId<TEntity> : EntityId<TEntity, Guid> where TEntity : IEntity
        {
            public GuidId(Guid id) : base(id)
            {
            }
        }

        class LongId<TEntity> : EntityId<TEntity, long> where TEntity : IEntity
        {
            public LongId(long id) : base(id)
            {
            }
        }
    }
}
