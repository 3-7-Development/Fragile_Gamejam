//using CodeMonkey.Utils;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TestingBuilding : MonoBehaviour
//{
//    private Grid grid;

//    [SerializeField] private GameObject obj;
//    [SerializeField] private GameObject obj2;

//    [SerializeField] private int width;
//    [SerializeField] private int height;
//    [SerializeField] private float cellSize;
//    [SerializeField] private Vector3 position;

//    private void Awake()
//    {
//    }

//    private void Start()
//    {
//        var clone = Instantiate(obj);

//        grid = new Grid(width, height, cellSize, position, clone);
//    }

//    private void Update()
//    {
//        HandleClickToModifyGrid();
//    }

//    private void HandleClickToModifyGrid()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            mousePos.z = 0;

//            //mousePos.x = Mathf.Ceil(mousePos.x);
//            //mousePos.y = Mathf.Ceil(mousePos.y);

//            //mousePos = grid.GetWorldPosition((int)mousePos.x, (int)mousePos.y);

//            //grid.GetXY(mousePos, out var x, out var y);

//            var currentValue = grid.GetValue((int)(mousePos.x*cellSize), (int)(mousePos.y*cellSize));
//            var currentPos = currentValue.transform.position;

//            //int x = (int)((mousePos.x+0.5f) / cellSize);
//            //int y = (int)((mousePos.y+0.5f) / cellSize);
//            int x = (int)Mathf.Ceil(mousePos.x);
//            int y = (int)Mathf.Ceil(mousePos.y);

//            Debug.Log($"Mouse: {mousePos}\nGetValue: {x}, {y}");
//            //Debug.Log($"CurrentValue: {currentValue.transform.position}");


//            if (currentValue == null)
//            {
//                currentValue = obj;
//            }
//            if (currentValue.tag == "obj")
//            {
//                currentValue = obj2;
//            }
//            else if (currentValue.tag == "RedObj")
//            {
//                currentValue = obj;
//            }

//            currentValue.transform.position = new Vector3(x, y);

//            grid.SetValue(x, y, currentValue);
//        }
//    }
//}
