using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject roomPrefab; // ������ �������
    public Grid grid; // �����

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = grid.WorldToCell(mousePosition);
            Instantiate(roomPrefab, grid.CellToWorld(cellPosition), Quaternion.identity);
        }
    }
}