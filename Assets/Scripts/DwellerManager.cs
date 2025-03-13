using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwellerManager : MonoBehaviour
{
    public GameObject dwellerPrefab; // Префаб жителя
    public Room[] rooms; // Массив комнат

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // По нажатию пробела добавляем жителя
        {
            AddDweller();
        }
    }

    void AddDweller()
    {
        // Создаем нового жителя
        GameObject newDweller = Instantiate(dwellerPrefab, Vector3.zero, Quaternion.identity);
        Dweller dweller = newDweller.GetComponent<Dweller>();

        // Назначаем жителя в первую свободную комнату
        foreach (Room room in rooms)
        {
            if (room.assignedDweller == null)
            {
                dweller.AssignToRoom(room);
                room.assignedDweller = dweller;
                break;
            }
        }
    }
}