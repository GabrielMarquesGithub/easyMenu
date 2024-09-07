using Main.Models;

namespace Main.Repositories.Interfaces;

public interface IFoodsRepository
{
    IEnumerable<Food> Foods { get; }
    IEnumerable<Food> FavoriteFoods { get; }

    Food GetFoodById(int foodId);
}
