using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class FoodService
{
    public int foodAmount { get; private set; } = 0; // Food counter
    // private readonly Slider _foodSlider;  // The UI Slider

    public IEnumerator IncreaseFoodOverTime()
    {
        float progress = 0f; // Slider progress

        while (true)
        {
            progress += Time.deltaTime; // Increase progress based on time
            // _foodSlider.value = Mathf.Clamp01(progress); // Update slider value (clamped between 0 and 1)

            if (progress >= 1f) // Every 1 second
            {
                foodAmount++; // Increment food
                progress = 0f; // Reset progress for next second
            }

            Debug.Log(foodAmount);
            yield return null; // Wait for the next frame
        }
    }
}