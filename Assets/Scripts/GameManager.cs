using UnityEngine;
using UnityEngine.UI;
using Zenject;
// using IPTech.Coroutines;

public class GameManager : MonoBehaviour
{
    // public Slider foodSlider;  // UI Slider to show food progress
    [Inject]
    private FoodService _foodService;
    [SerializeField]
    private UnitManager unitManager;
    public Button SpawnMelee;
    private void Awake()
    {
        //if (Instance == null)
        //    Instance = this;
        //else
        //    Destroy(gameObject);
    }

    void Start() {} 

    void Update() {}
    
    public void spawnMelee(){
        SpawnMelee.interactable=false;
        UnitManager.Instance.SpawnFriendlyUnit();
        StartCoroutine(_foodService.IncreaseFoodOverTime());
    }


}
