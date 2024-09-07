using Main.Context;
using Main.Models;
using Main.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Main.Repositories;

sealed internal class FoodsRepository : IFoodsRepository
{
    private readonly AppDbContext _context;

    public FoodsRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Food> Foods => _context.Foods.Include(f => f.Category);
    public IEnumerable<Food> FavoriteFoods => _context.Foods
    .Where(f => f.IsFavorite)
    .Include(f => f.Category);

    public Food GetFoodById(int foodId) => _context.Foods.FirstOrDefault(f => f.Id == foodId);
}
