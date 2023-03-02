using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private Grid grid;

    private List<GameObject> gridObjects;

    [SerializeField] private GameObject obj;

    void Awake()
    {
        grid = GetComponent<Grid>();
        grid.cellGap = new Vector3();

        gridObjects = new List<GameObject>();
    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    PlaceObject(obj);

        //    //var vector = GetGridCellVector();

        //    //var cell = gridObjects.FirstOrDefault(c => c.transform.position == vector);

        //    //if (cell is null)
        //    //{
        //    //    var createdObject = Instantiate(obj, vector, Quaternion.identity);
        //    //    createdObject.transform.position = vector;

        //    //    gridObjects.Add(createdObject);
        //    //}
        //}

        if (Input.GetMouseButtonDown(1))
        {
            var vector = GetGridCellVector();

            var clickedObject = gridObjects.FirstOrDefault(o => o.transform.position == vector);

            if (clickedObject != null)
            {
                gridObjects.Remove(clickedObject);
                Destroy(clickedObject);
            }
        }
    }

    Vector3 GetGridCellVector()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        var mouseVector = new Vector3Int((int)mousePosition.x, (int)mousePosition.y, 0);

        var cellVector = grid.GetCellCenterWorld(mouseVector);

        return cellVector;
    }

    public void PlaceObject(GameObject objectToPlace)
    {
        var vector = GetGridCellVector();

        var cell = gridObjects.FirstOrDefault(c => c.transform.position == vector);

        if (cell is null)
        {
            var createdObject = Instantiate(objectToPlace, vector, Quaternion.identity);
            createdObject.transform.position = vector;

            gridObjects.Add(createdObject);
        }
    }
}
