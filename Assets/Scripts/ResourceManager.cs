using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public int food = 100;
    public int water = 100;
    public int energy = 100;

    public Text foodText;
    public Text waterText;
    public Text energyText;

    void Update()
    {
        // Обновляем UI
        foodText.text = "Food: " + food;
        waterText.text = "Water: " + water;
        energyText.text = "Energy: " + energy;
    }

    public void AddFood(int amount)
    {
        food += amount;
    }

    public void AddWater(int amount)
    {
        water += amount;
    }

    public void AddEnergy(int amount)
    {
        energy += amount;
    }
}