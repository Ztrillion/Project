using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetting : MonoBehaviour
{
    public class Body
    {
        public GameObject bodyObj;
        public GameObject eyeLObj;
        public GameObject eyeRObj;
        public GameObject faceObj;
        public GameObject hairBaseObj;
        public GameObject hairFrontObj;
        public GameObject accessoryObj;

        public List<GameObject> faceListObj = new List<GameObject>();
        public List<GameObject> eyeLListObj = new List<GameObject>();
        public List<GameObject> eyeRListObj = new List<GameObject>();
        public List<GameObject> hairFrontListObj = new List<GameObject>();
        public List<GameObject> hairBaseListObj = new List<GameObject>();
        public List<GameObject> accessoryListObj = new List<GameObject>();

        public int eyeObjNum = 0;
        public int faceObjNum = 0;
        public int hairObjNum = 0;
        public int accessoryObjNum = 0;
    }

    // 불러오는 오브젝트 리스트화
    public List<GameObject> bodyList = new List<GameObject>();
    public List<GameObject> faceList = new List<GameObject>();
    public List<GameObject> eyeLList = new List<GameObject>();
    public List<GameObject> eyeRList = new List<GameObject>();
    public List<GameObject> hairBaseList = new List<GameObject>();
    public List<GameObject> hairFrontList = new List<GameObject>();
    public List<GameObject> accessoryList = new List<GameObject>();

    // 눈 세트로 만든 리스트
    public List<GameObject> eyeSetLList = new List<GameObject>();
    public List<GameObject> eyeSetRList = new List<GameObject>();

    public Button[] listButtons;
    public List<Body> setBodyList = new List<Body>();

    public int currentBodyNum = 0;
    public RuntimeAnimatorController anim;

    private void Start()
    {
        LoadResourceFile();
        BodySetting();
        ButtonSetting();
    }

    private void ButtonSetting()
    {
        listButtons = GameObject.Find("Panel").GetComponentsInChildren<Button>();

        listButtons[0].transform.GetComponentInChildren<Text>().text = "FACE";
        listButtons[0].transform.GetComponentInChildren<Text>().fontSize = 30;
        listButtons[0].transform.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        listButtons[0].onClick.AddListener(SetChangeFace);

        listButtons[1].transform.GetComponentInChildren<Text>().text = "HAIR";
        listButtons[1].transform.GetComponentInChildren<Text>().fontSize = 30;
        listButtons[1].transform.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        listButtons[1].onClick.AddListener(SetChangeHair);

        listButtons[2].transform.GetComponentInChildren<Text>().text = "BODY";
        listButtons[2].transform.GetComponentInChildren<Text>().fontSize = 30;
        listButtons[2].transform.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        listButtons[2].onClick.AddListener(SetChangeBody);

        listButtons[3].transform.GetComponentInChildren<Text>().text = "EYE";
        listButtons[3].transform.GetComponentInChildren<Text>().fontSize = 30;
        listButtons[3].transform.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        listButtons[3].onClick.AddListener(SetChangeEye);

        listButtons[4].transform.GetComponentInChildren<Text>().text = "ACCESSORY";
        listButtons[4].transform.GetComponentInChildren<Text>().fontSize = 30;
        listButtons[4].transform.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
        listButtons[4].onClick.AddListener(SetChangeAccessory);
    }

    private void LoadResourceFile()
    {
        bodyList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Models/Parts/Costume_01"));
        bodyList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Models/Parts/Costume_02"));
        bodyList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Models/Parts/Costume_03"));

        faceList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Face/Face_00 BlendShapes"));
        faceList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Face/Face_01 BlendShapes"));
        faceList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Face/Face_02 BlendShapes"));

        eyeLList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_00_L"));
        eyeLList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/EyeLight_00_L"));
        eyeLList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/EyeLight_01_L"));
        eyeLList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_01_L Set"));
        eyeLList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_02_L Set"));

        eyeRList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_00_R"));
        eyeRList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/EyeLight_00_R"));
        eyeRList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/EyeLight_02_R"));
        eyeRList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_01_R Set"));
        eyeRList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Eye/Eye_02_R Set"));

        hairBaseList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_00_Base"));
        hairBaseList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_01_Base"));
        hairBaseList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_02_Base"));

        hairFrontList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_00_Front"));
        hairFrontList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_01_Front"));
        hairFrontList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Hair/Hair_02_Front"));

        accessoryList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Accessory/Accessory_00"));
        accessoryList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Accessory/Accessory_01"));
        accessoryList.Add(Resources.Load<GameObject>("SD Unity-Chan Haon Custom/Prefabs/Accessory/Accessory_02"));

        anim = Resources.Load<RuntimeAnimatorController>("SD Unity-Chan Haon Custom/Animation Controller/C StandB");
    }

    private Body MakeBody(int bodyNum)
    {
        GameObject rootHeadObj;
        GameObject rootEyeLObj;
        GameObject rootEyeRObj;

        Body body = new Body();

        if (bodyNum == 0)
        {
            body.bodyObj = Instantiate(bodyList[bodyNum]);
            body.bodyObj.transform.SetParent(this.transform, false);
            rootHeadObj = body.bodyObj.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(3).GetChild(0).gameObject;
            rootEyeLObj = body.bodyObj.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(3).GetChild(0).GetChild(0).gameObject;
            rootEyeRObj = body.bodyObj.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(3).GetChild(0).GetChild(1).gameObject;

            for (int i = 0; i < 3; i++)
            {
                body.faceObj = Instantiate(faceList[i]);
                body.faceObj.transform.SetParent(rootHeadObj.transform, false);
                body.faceListObj.Add(body.faceObj);

                body.eyeLObj = Instantiate(eyeSetLList[i]);
                body.eyeLObj.transform.SetParent(rootEyeLObj.transform, false);
                body.eyeLListObj.Add(body.eyeLObj);

                body.eyeRObj = Instantiate(eyeSetRList[i]);
                body.eyeRObj.transform.SetParent(rootEyeRObj.transform, false);
                body.eyeRListObj.Add(body.eyeRObj);

                body.hairBaseObj = Instantiate(hairBaseList[i]);
                body.hairBaseObj.transform.SetParent(rootHeadObj.transform, false);
                body.hairBaseListObj.Add(body.hairBaseObj);

                body.hairFrontObj = Instantiate(hairFrontList[i]);
                body.hairFrontObj.transform.SetParent(rootHeadObj.transform, false);
                body.hairFrontListObj.Add(body.hairFrontObj);

                body.accessoryObj = Instantiate(accessoryList[i]);
                body.accessoryObj.transform.SetParent(rootHeadObj.transform, false);
                body.accessoryListObj.Add(body.accessoryObj);
            }
        }
        else
        {
            body.bodyObj = Instantiate(bodyList[bodyNum]);
            body.bodyObj.transform.SetParent(this.transform, false);
            rootHeadObj = body.bodyObj.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(3).GetChild(0).gameObject;
            rootEyeLObj = body.bodyObj.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(3).GetChild(0).GetChild(0).gameObject;
            rootEyeRObj = body.bodyObj.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(3).GetChild(0).GetChild(1).gameObject;

            for (int i = 0; i < 3; i++)
            {
                body.faceObj = Instantiate(faceList[i]);
                body.faceObj.transform.SetParent(rootHeadObj.transform, false);
                body.faceListObj.Add(body.faceObj);

                body.eyeLObj = Instantiate(eyeSetLList[i]);
                body.eyeLObj.transform.SetParent(rootEyeLObj.transform, false);
                body.eyeLListObj.Add(body.eyeLObj);

                body.eyeRObj = Instantiate(eyeSetRList[i]);
                body.eyeRObj.transform.SetParent(rootEyeRObj.transform, false);
                body.eyeRListObj.Add(body.eyeRObj);

                body.hairBaseObj = Instantiate(hairBaseList[i]);
                body.hairBaseObj.transform.SetParent(rootHeadObj.transform, false);
                body.hairBaseListObj.Add(body.hairBaseObj);

                body.hairFrontObj = Instantiate(hairFrontList[i]);
                body.hairFrontObj.transform.SetParent(rootHeadObj.transform, false);
                body.hairFrontListObj.Add(body.hairFrontObj);

                body.accessoryObj = Instantiate(accessoryList[i]);
                body.accessoryObj.transform.SetParent(rootHeadObj.transform, false);
                body.accessoryListObj.Add(body.accessoryObj);
            }
        }

        return body;
    }

    private void DisableText()
    {
        Transform[] allChildren = transform.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if (child.GetComponent<TextMesh>())
            {
                child.gameObject.SetActive(false);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                setBodyList[i].faceListObj[j].SetActive(false);
                setBodyList[i].eyeLListObj[j].SetActive(false);
                setBodyList[i].eyeRListObj[j].SetActive(false);
                setBodyList[i].hairBaseListObj[j].SetActive(false);
                setBodyList[i].hairFrontListObj[j].SetActive(false);
                setBodyList[i].accessoryListObj[j].SetActive(false);
            }
            if (i != 0)
                setBodyList[i].bodyObj.SetActive(false);
        }
    }

    private void EyeSetting(List<GameObject> eyeList, List<GameObject> eyeSetList)
    {
        GameObject eyeBase = Instantiate(eyeList[0]);
        GameObject eyeObj1 = Instantiate(eyeList[1]);
        GameObject eyeObj2 = Instantiate(eyeList[2]);

        eyeObj1.transform.SetParent(eyeBase.transform, false);
        eyeObj2.transform.SetParent(eyeBase.transform, false);

        eyeSetList.Add(eyeBase);
        eyeSetList.Add(eyeList[3]);
        eyeSetList.Add(eyeList[4]);

        Destroy(eyeBase);
    }

    private void BodySetting()
    {
        EyeSetting(eyeLList, eyeSetLList);
        EyeSetting(eyeRList, eyeSetRList);

        setBodyList.Add(MakeBody(0));
        setBodyList.Add(MakeBody(1));
        setBodyList.Add(MakeBody(2));

        DisableText();

        foreach (Body body in setBodyList)
        {
            body.faceObj = null;
            body.eyeLObj = null;
            body.eyeRObj = null;
            body.hairBaseObj = null;
            body.hairFrontObj = null;
            body.accessoryObj = null;

            body.faceObj = body.faceListObj[body.faceObjNum];
            body.eyeLObj = body.eyeLListObj[body.eyeObjNum];
            body.eyeRObj = body.eyeRListObj[body.eyeObjNum];
            body.hairBaseObj = body.hairBaseListObj[body.hairObjNum];
            body.hairFrontObj = body.hairFrontListObj[body.hairObjNum];
            body.accessoryObj = body.accessoryListObj[body.accessoryObjNum];
        }

        SetActiveBody(setBodyList[currentBodyNum], true);

        setBodyList[currentBodyNum].bodyObj.transform.GetComponent<Animator>().runtimeAnimatorController = anim;
    }

    public void SetChangeFace()
    {
        int prevNum = setBodyList[currentBodyNum].faceObjNum;
        int nextNum = ++setBodyList[currentBodyNum].faceObjNum > 2 ? 0 : setBodyList[currentBodyNum].faceObjNum;

        setBodyList[currentBodyNum].faceObj = setBodyList[currentBodyNum].faceListObj[nextNum];

        setBodyList[currentBodyNum].faceListObj[prevNum].SetActive(false);
        setBodyList[currentBodyNum].faceListObj[nextNum].SetActive(true);

        setBodyList[currentBodyNum].faceObjNum = nextNum;
    }

    public void SetChangeHair()
    {
        int prevNum = setBodyList[currentBodyNum].hairObjNum;
        int nextNum = ++setBodyList[currentBodyNum].hairObjNum > 2 ? 0 : setBodyList[currentBodyNum].hairObjNum;

        setBodyList[currentBodyNum].hairBaseObj = setBodyList[currentBodyNum].hairBaseListObj[nextNum];
        setBodyList[currentBodyNum].hairFrontObj = setBodyList[currentBodyNum].hairFrontListObj[nextNum];

        setBodyList[currentBodyNum].hairBaseListObj[prevNum].SetActive(false);
        setBodyList[currentBodyNum].hairFrontListObj[prevNum].SetActive(false);

        setBodyList[currentBodyNum].hairBaseListObj[nextNum].SetActive(true);
        setBodyList[currentBodyNum].hairFrontListObj[nextNum].SetActive(true);

        setBodyList[currentBodyNum].hairObjNum = nextNum;
    }

    public void SetChangeEye()
    {
        int prevNum = setBodyList[currentBodyNum].eyeObjNum;
        int nextNum = ++setBodyList[currentBodyNum].eyeObjNum > 2 ? 0 : setBodyList[currentBodyNum].eyeObjNum;

        setBodyList[currentBodyNum].eyeLObj = setBodyList[currentBodyNum].eyeLListObj[nextNum];
        setBodyList[currentBodyNum].eyeRObj = setBodyList[currentBodyNum].eyeRListObj[nextNum];

        setBodyList[currentBodyNum].eyeLListObj[prevNum].SetActive(false);
        setBodyList[currentBodyNum].eyeRListObj[prevNum].SetActive(false);

        setBodyList[currentBodyNum].eyeLListObj[nextNum].SetActive(true);
        setBodyList[currentBodyNum].eyeRListObj[nextNum].SetActive(true);

        setBodyList[currentBodyNum].eyeObjNum = nextNum;
    }

    public void SetChangeAccessory()
    {
        int prevNum = setBodyList[currentBodyNum].accessoryObjNum;
        int nextNum = ++setBodyList[currentBodyNum].accessoryObjNum > 2 ? 0 : setBodyList[currentBodyNum].accessoryObjNum;

        setBodyList[currentBodyNum].accessoryObj = setBodyList[currentBodyNum].accessoryListObj[nextNum];

        setBodyList[currentBodyNum].accessoryListObj[prevNum].SetActive(false);
        setBodyList[currentBodyNum].accessoryListObj[nextNum].SetActive(true);

        setBodyList[currentBodyNum].accessoryObjNum = nextNum;
    }

    public void SetChangeBody()
    {
        int prevNum = currentBodyNum;
        int nextNum = ++currentBodyNum > 2 ? 0 : currentBodyNum;

        setBodyList[nextNum].faceObjNum = setBodyList[prevNum].faceObjNum;
        setBodyList[nextNum].eyeObjNum = setBodyList[prevNum].eyeObjNum;
        setBodyList[nextNum].hairObjNum = setBodyList[prevNum].hairObjNum;
        setBodyList[nextNum].accessoryObjNum = setBodyList[prevNum].accessoryObjNum;

        setBodyList[nextNum].faceObj = setBodyList[nextNum].faceListObj[setBodyList[nextNum].faceObjNum];
        setBodyList[nextNum].eyeLObj = setBodyList[nextNum].eyeLListObj[setBodyList[nextNum].eyeObjNum];
        setBodyList[nextNum].eyeRObj = setBodyList[nextNum].eyeRListObj[setBodyList[nextNum].eyeObjNum];
        setBodyList[nextNum].hairBaseObj = setBodyList[nextNum].hairBaseListObj[setBodyList[nextNum].hairObjNum];
        setBodyList[nextNum].hairFrontObj = setBodyList[nextNum].hairFrontListObj[setBodyList[nextNum].hairObjNum];
        setBodyList[nextNum].accessoryObj = setBodyList[nextNum].accessoryListObj[setBodyList[nextNum].accessoryObjNum];

        SetActiveBody(setBodyList[prevNum], false);
        SetActiveBody(setBodyList[nextNum], true);

        currentBodyNum = nextNum;

        setBodyList[currentBodyNum].bodyObj.transform.GetComponent<Animator>().runtimeAnimatorController = anim;
    }

    public void SetActiveBody(Body body, bool isBool)
    {
        body.bodyObj.SetActive(isBool);
        body.faceObj.SetActive(isBool);
        body.hairBaseObj.SetActive(isBool);
        body.hairFrontObj.SetActive(isBool);
        body.eyeLObj.SetActive(isBool);
        body.eyeRObj.SetActive(isBool);
        body.accessoryObj.SetActive(isBool);
    }
}