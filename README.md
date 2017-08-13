# Repository  
[![NuGet](https://img.shields.io/nuget/v/M.Repository.svg)](https://www.nuget.org/packages/M.Repository)  

An abstraction for Repository pattern based on IQueryable.

## Implementations    

[M.Repository.EntityFramework](https://github.com/petar-m/repository.ef)

## Setup  

Inherit `Entity<TKey>` in order to use `IRepository<TEntity>`.
  
*example:*  
  
    public class Company : Entity<string>
    {
        public string Name { get; set; }
    }
    
    public class Item : Entity<int>
    {
        public string InventoryNumber { get; set; }
        public int Quantity { get; set; }
    }
    
    public class Order : Entity<Guid>
    {
        public DateTime Date { get; set; }
        public Company BillTo { get; set; }
        public ICollection<Item> Items { get; }
    }
  
Setup repositories and unit of work with concrete implementations.  

*example (pseudo code):*  
    
    For<IRepository<>>().Use<Repository<>>();
    For<IUnitOfWork>().Use<UnitOfWork>();  

To use asynchronous queries setup `QueryableAsyncExtensionsProxy` with implementation of `IQueryableAsyncExtensionsProxy`.  
  
*example:*  

    QueryableAsyncExtensionsProxy.Initialize(new SomeConcreteQueryableAsyncExtensionsProxyImplementation());  

## Usage  

### Editing  

*example:*  

    IRepository<Order> orders;
    ...

    // create 
    var order = new Order { ... };
    orders.Add(order);
    
    // modify existing
    orders.Update(order);

    // delete existing
    orders.Delete(order);

    // call IUnitOfWork.Commit() or await IUnitOfWork.CommitAsync() to persist changes.      
  

### Querying  

#### Find by Id  

*example:*  

    IRepository<Company> companies;
    IRepository<Item> items;
    ...

    // synchronous
    var company = companies.Find(Id.Of<Company>("id"));
    var item = items.Find(Id.Of<Item>(123));
    
    // asynchronous
    var company = await companies.FindAsync(Id.Of<Company>("id"));
    var item = await items.FindAsync(Id.Of<Item>(123));
  
#### Search by Id   

*example:*  

    IRepository<Order> orders;
    ...
    // synchronous
 
    // result can be used for modifications, gets related entities
    var query = QueryBuilder.ById(Id.Of<Order>(Guid.Parse("some guid")))
                            .Include(x => x.Items);
    var order = orders.GetBy(query);
 
    order.Date = DateTime.UtcNow; // IUnitOfWork.Commit() should persist changes.
    int count = order.Items.Count; // Items property is populated
    ...
   
    // specify that result will not be used for modifications and get related entities
    var query = QueryBuilder.ById(Id.Of<Order>(Guid.Parse("some guid")), readOnly: true)
                            .Include(x => x.Items);
    var order = orders.GetBy(query);
 
    order.Date = DateTime.UtcNow; // IUnitOfWork.Commit() should not persist changes.
 
    // asynchronous
    var query = QueryBuilder.ByIdAsync(Id.Of<Order>(Guid.Parse("some guid")))
                            .Include(x => x.Items);
    var order = await orders.GetByAsync(query);
  
#### Search by predicate  

*example:*

    IRepository<Order> orders;
    ...
  
    // synchronous
    var query = QueryBuilder.BySpecification<Order>(x => x.BillTo.Name == "Some Company")
                            .Include(x => x.Items);
    IEnumerable<Order> result = orders.GetBy(query);
    ...
    
    // asynchronous
    var query = QueryBuilder.BySpecificationAsync<Order>(x => x.BillTo.Name == "Some Company")
                            .Include(x => x.Items);
    IEnumerable<Order> result = await orders.GetByAsync(query);

#### Search by delegate  

*example:*  

    IRepository<Order> orders;
    ...
 
    // synchronous
    var query = QueryBuilder.ByDelegate<Order, Order>(x => x.Where(o => o.Items.Count > 3).FirstOrDefault());
    Order result = orders.GetBy(query);
    ...
    
    // asynchronous
    var query = QueryBuilder.ByDelegateAsync<Order, Order>(x => x.Where(o => o.Items.Count > 3).FirstOrDefaultAsync());
    Order result = await orders.GetByAsync(query);
  
*projection example:*  

    public class Total
    {
        public string Company { get; set; }
        public int ItemsCount { get; set; }
    }
    ...
    IRepository<Order> orders;
    ...
 
    // synchronous
    var query = QueryBuilder.ByDelegate<Order, List<Total>>(x => x.Select(o => new Total { Company = o.BillTo.Name, ItemsCount = o.Items.Count() }).ToList());
    List<Total> result = orders.GetBy(query);
    ...
    
    // asynchronous
    var query = QueryBuilder.ByDelegate<Order, List<Total>>(x => x.Select(o => new Total { Company = o.BillTo.Name, ItemsCount = o.Items.Count() }).ToListAsync());
    List<Total> result = await orders.GetByAsync(query);

#### Custom search  

*example:*  

    public class CustomQuery : Query<Order, Order[]>
    {
        private int? itemsCount;
        private string companyName;
    
        public CustomQuery(int? itemsCount = null, string companyName = null)
        {
            this.itemsCount = itemsCount;
            this.companyName = companyName;
        }
    
        public override Order[] ExecuteAgainst(IQueryable<Order> orders)
        {
            orders = string.IsNullOrWhiteSpace(companyName) ? orders.Take(100) : orders = orders.Where(x => x.BillTo.Name == companyName);
    
            orders = itemsCount.HasValue ? orders.Where(x => x.Items.Count == itemsCount) : orders;
    
            orders = orders.Where(x => x.Date >= DateTime.UtcNow.AddDays(-2) && x.Date <= DateTime.UtcNow);
    
            return orders.ToArray();
        }
    }
     
    
    ...
    IRepository<Order> orders;
    ...
 
    var query = new CustomQuery(10, "ABC");
    Order[] result = orders.GetBy(query);
 
 
