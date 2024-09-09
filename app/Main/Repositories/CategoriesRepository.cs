using Main.Context;
using Main.Models;
using Main.Repositories.Interfaces;

namespace Main.Repositories;

public sealed class CategoriesRepository : ICategoriesRepository
{
    private readonly AppDbContext _context;

    public CategoriesRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> Categories => _context.Categories;
}