using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class LeftButtonClick : MonoBehaviour {
    
    public Button mButton;
    public CubeCreate cubeCreate;
    public ScoreManager scoreManager;

    // Use this for initialization
    void Start()
    {
        mButton.onClick.AddListener(OnMouseDown);
    }

    // Update is called once per frame
    void Update()
    {
        if (MyLocker.locker == 0)
        {
            //MyLocker.locker = false;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                OnMouseDown();
            //else
            //    MyLocker.locker = true;
        }
    }

    void OnMouseDown()
    {
        MyLocker.locker++;
        GameObject obj = cubeCreate.cubeList.ElementAt(0);

        //성공
        if (obj.transform.position.x == -3)
        {

            //제거
            cubeCreate.cubeList.RemoveFirst();
            Destroy(obj);

            //생성
            cubeNewCreate();
            cubeCreate.cubeMove();

            //스코어
            scoreManager.scorePlus();
        }
        //실패
        else
        {
            scoreManager.scoreMinus();
        }
        MyLocker.locker--;
    }

    void cubeNewCreate()
    {
        int ran = Random.Range(1, 3);
        if (ran == 1)
            cubeCreate.createLeftCube(4);
        else
            cubeCreate.createRightCube(4);
    }
    
}
