using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwellerManager : MonoBehaviour
{
    public GameObject dwellerPrefab; // ������ ������
    public Room[] rooms; // ������ ������

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // �� ������� ������� ��������� ������
        {
            AddDweller();
        }
    }

    void AddDweller()
    {
        // ������� ������ ������
        GameObject newDweller = Instantiate(dwellerPrefab, Vector3.zero, Quaternion.identity);
        Dweller dweller = newDweller.GetComponent<Dweller>();

        // ��������� ������ � ������ ��������� �������
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