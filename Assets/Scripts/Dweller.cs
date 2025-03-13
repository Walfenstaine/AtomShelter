using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dweller : MonoBehaviour
{
    public string dwellerName; // Имя жителя
    public int health = 100; // Здоровье
    public int strength = 1; // Сила
    public int agility = 1; // Ловкость
    public int intelligence = 1; // Интеллект

    public Room assignedRoom; // Комната, в которой работает житель

    // Метод для назначения в комнату
    public void AssignToRoom(Room room)
    {
        assignedRoom = room;
        transform.position = room.GetWorkPosition(); // Перемещаем жителя в комнату
    }
}