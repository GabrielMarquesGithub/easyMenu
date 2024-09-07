using Main.Models;

namespace Main.Repositories.Interfaces;

internal interface ICategoriesRepository
{
    public IEnumerable<Category> Categories { get; }
}
