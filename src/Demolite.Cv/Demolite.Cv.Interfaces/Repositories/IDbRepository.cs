namespace Demolite.Cv.Interfaces.Repositories;

public interface IDbRepository<T>
{
	public Task<T[]> GetAll();
}