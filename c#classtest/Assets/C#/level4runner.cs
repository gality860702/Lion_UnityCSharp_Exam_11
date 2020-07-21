using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class level4runner : leveltree
{
    [Header("移動速度"), Range(0, 20)]
    public float speed;
    [Header("角色")]
    public leveltree[] tree;


    //目標
    protected Transform target;
    //距離
    public float[] distance;



    protected virtual void Start()
    {
        //人類陣列 = 透過類型尋找物件<泛型>()
        tree = FindObjectsOfType<leveltree>();
        //距離陣列的數量 = 人類陣列的數量
        distance = new float[tree.Length];
        //設定目的地(原點) - 避免一開始導航錯亂
        agent.SetDestination(Vector3.zero);
    }

    private void Update()
    {
        Track();
    }

    ///<summary>
    /// 追蹤方法
    /// </summary>
    protected virtual void Track()
    {

        for (int i = 0; i < tree.Length; i++)
        {


            if (tree[i] == null || tree[i].transform.name == "people")
            {
                break;
            }
            float min = distance.Min();                     //最小值 = 距離.最小值
            int index = distance.ToList().IndexOf(min);    //索引值 = 距離.轉清單.取得索引值(最小值)
            target = tree[index].transform;            //目標 = 人類[索引值].變形
        }
    }
}
