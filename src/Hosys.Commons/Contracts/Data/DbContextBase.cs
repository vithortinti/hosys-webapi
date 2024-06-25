using Microsoft.EntityFrameworkCore;

namespace Hosys.Commons.Contracts.Data;

public abstract class DbContextBase(DbContextOptions opts) : DbContext(opts);