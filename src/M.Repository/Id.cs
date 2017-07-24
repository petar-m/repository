using System;

namespace M.Repository
{
    public static class Id
    {
        public static EntityId<TEntity, string> Of<TEntity>(string id) where TEntity : Entity<string>
        {
            return new StringId<TEntity>(id);
        }

        public static EntityId<TEntity, int> Of<TEntity>(int id) where TEntity : Entity<int>
        {
            return new IntId<TEntity>(id);
        }

        public static EntityId<TTEntity, Guid> Of<TTEntity>(Guid id) where TTEntity : Entity<Guid>
        {
            return new GuidId<TTEntity>(id);
        }

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
