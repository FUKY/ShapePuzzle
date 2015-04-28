using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShapeRandom : MonoSingleton<ShapeRandom> {

    public List<GameObject> listShape = new List<GameObject>();
    public Transform parentTrans;
    public bool isRand = false;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //Gắn cái hình vào trong cái vị trí
    [ContextMenu("Test")]
    void RandomShape()
    {
        List<GameObject> listTemp = new List<GameObject>();
        for (int i = 0; i < 3; i++)
        {
            int shape = Random.Range(0, listShape.Count - 1);
            listTemp.Add(listShape[shape]);
            GameObject trans = Instantiate(listShape[shape], transform.position, Quaternion.identity) as GameObject;
            trans.transform.SetParent(parentTrans);
            listShape.RemoveAt(shape);
        }
        listShape = listTemp;
    }
}
