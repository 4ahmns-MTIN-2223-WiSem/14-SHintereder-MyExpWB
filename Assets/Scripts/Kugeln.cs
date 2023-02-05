using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugeln : MonoBehaviour

{
    public GameObject decorationPrefab;
    private Transform treeTransform;
    private GameObject currentDecoration;

    void Start()
    {
        treeTransform = gameObject.transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == treeTransform)
                {
                    Vector3 decorationPosition = hit.point;
                    decorationPosition.y += 0.5f;
                    currentDecoration = Instantiate(decorationPrefab, decorationPosition, Quaternion.identity);
                }
                else if (hit.transform.gameObject == currentDecoration)
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}






