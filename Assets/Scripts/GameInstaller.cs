using Zenject;
using UnityEngine;
// using IPTech.Coroutines;

public class GameInstaller : Installer<GameInstaller>
{
    // public Slider foodSlider;  // Reference to the UI Slider in Inspector

    public override void InstallBindings()
    {
        // Bind the Slider from the scene (you can drag it into the Inspector)
        // Container.Bind<Slider>().FromInstance(foodSlider).AsSingle();

        // Bind the Food class as a single instance, automatically injected via Zenject
        Container.Bind<FoodService>().AsSingle();
        
        // Bind the GameManager (optional, but useful for testing injection)
        Container.Bind<GameManager>().AsSingle();

        // Container.Bind<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle();

    }
}
