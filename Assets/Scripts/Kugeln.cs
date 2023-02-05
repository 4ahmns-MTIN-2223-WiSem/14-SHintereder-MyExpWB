using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugeln : MonoBehaviour


{
    public GameObject decorationPrefab;
    private Transform treeTransform;
    private GameObject[] decorations;

    void Start()
    {
        treeTransform = gameObject.transform;
        decorations = new GameObject[10]; // 10 ist eine beliebige Anzahl von Verzierungen, die Sie speichern möchten
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            int mouseButton = -1;

            if (Input.GetMouseButtonDown(0))
            {
                mouseButton = 0;
            }
            else if (Input.GetMouseButtonDown(1))
            {
                mouseButton = 1;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == treeTransform)
                {
                    switch (mouseButton)
                    {
                        case 0:
                            // Platziere eine Verzierung
                            Vector3 decorationPosition = hit.point;
                            decorationPosition.y += 0.5f;
                            GameObject decoration = Instantiate(decorationPrefab, decorationPosition, Quaternion.identity);

                            // Speichere die Verzierung im Array
                            for (int i = 0; i < decorations.Length; i++)
                            {
                                if (decorations[i] == null)
                                {
                                    decorations[i] = decoration;
                                    break;
                                }
                            }
                            break;
                        case 1:
                            // Entferne eine Verzierung
                            for (int i = 0; i < decorations.Length; i++)
                            {
                                if (decorations[i] != null)
                                {
                                    Destroy(decorations[i]);
                                    decorations[i] = null;
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}







