using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instanace;
    private static bool s_Init = false;

    private GameManager _game = new GameManager();
    public static GameManager Game { get { return Instance?._game; } }
    

    public static Managers Instance
    {
        get
        {
            if (s_Init == false)
            {
                s_Init = true;

                GameObject go = GameObject.Find("_Managers");

                if (go == null)
                {
                    go = new GameObject();
                    go.name = "_Managers";
                    go.AddComponent<Managers>();
                }

                DontDestroyOnLoad(go);
                s_instanace = go.GetComponent<Managers>();
            }
            return s_instanace;
        }
    }

    public void CallTest()
    {
        Debug.Log("호출 성공1");
    }
}
