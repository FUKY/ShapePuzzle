using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShapeRandom : MonoBehaviour {

    public List<GameObject> listShape = new List<GameObject>();
    public List<RectTransform> listPosition = new List<RectTransform>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //Gắn cái hình vào trong cái vị trí
    [ContextMenu("Test")]
    void RandomShape()
    {
        int prevShape = -1;
        int prevPos = -1;
        GameObject trans;
        for (int i = 0; i < 2; i++)
        {
            int pos = Random.Range(0, listPosition.Count - 1) - prevPos;
            int shape = Random.Range(0, listShape.Count - 1) - prevShape;
            trans = Instantiate(listShape[shape], listPosition[pos].transform.position, Quaternion.identity) as GameObject;
            trans.transform.SetParent(listPosition[pos].transform);
            prevPos = pos;
            prevShape = shape;
        }
    }
}
