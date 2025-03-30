using UnityEngine;
using TMPro;
using Zenject;

public class FoodUIManager : MonoBehaviour
{
    [Inject] private FoodService _foodService; // Inject the service
    private TextMeshProUGUI _foodText;

    private void Awake()
    {
        _foodText = GetComponent<TextMeshProUGUI>(); // Get the text component
    }

    private void Update()
    {
        _foodText.text = $"Food: {_foodService.foodAmount}"; // Update UI
    }
}
