using Main.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers;

public sealed class FoodController : Controller
{
    private readonly IFoodsRepository _foodRepository;

    public FoodController(IFoodsRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }

    public IActionResult List()
    {
        var foods = _foodRepository.Foods;
        return View(foods);
    }

}

