using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CubeCreate : MonoBehaviour {

    public GameObject cube;
    public LinkedList<GameObject> cubeList = new LinkedList<GameObject>();

    // Use this for initialization
    void Start () {
        cubeCreate();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void cubeCreate()
    {
        for (int i=6; i>=0; i--)
        {
            int ran = Random.Range(1, 3);
            if(ran == 1)
                createLeftCube(4 - i);
            else
                createRightCube(4 - i);
        }

    }

    public void createLeftCube(int height)
    {
        Vector3 v = new Vector3();
        v.x = -3;
        v.y = height;
        v.z = 0;
        cube.transform.position = v;
        
        GameObject temp = Instantiate(cube);
        cubeList.AddLast(temp);
    }

    public void createRightCube(int height)
    {
        Vector3 v = new Vector3();
        v.x = 3;
        v.y = height;
        v.z = 0;
        cube.transform.position = v;

        GameObject temp = Instantiate(cube);
        cubeList.AddLast(temp);
    }

    public void cubeMove()
    {
        MyLocker.locker += 6;
        for (int i = 0; i < 6; i++)
        {
            StartCoroutine(MoveDown(cubeList.ElementAt(i).transform, 1f, 5f));
        }
    }

    IEnumerator MoveDown(Transform thisTransform, float distance, float speed)
    {
        float startPos = thisTransform.position.y;
        float endPos = startPos - distance;
        float rate = 1.0f / Mathf.Abs(startPos - endPos) * speed;
        float t = 0.0f;
        while (t < 1.0f)
        {
            t += Time.deltaTime * rate;
            Vector3 pos = thisTransform.position;
            pos.y = Mathf.Lerp(startPos, endPos, t);
            thisTransform.position = pos;
            yield return 0;
        }
        MyLocker.locker--;
    }

}
