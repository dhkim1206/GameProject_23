using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pools;

<<<<<<< HEAD
    void Awake() {
        pools = new List<GameObject>[prefabs.Length];

        for(int index = 0; index < pools.Length; index++){
=======
    void Awake()
    {
        pools = new List<GameObject>[prefabs.Length];

        for (int index = 0; index < pools.Length; index++)
        {
>>>>>>> myeongjun
            pools[index] = new List<GameObject>();
        }
    }

<<<<<<< HEAD
    public GameObject Get(int index){
        GameObject select = null;
        //..선택한 풀의 놀고 있는 게임오브젝트 접근
        foreach (GameObject item in pools[index]){
            if(!item.activeSelf){
                //.. 발견하면 select 변수에 할당
=======
    public GameObject Get(int index)
    {
        GameObject select = null;
        //..������ Ǯ�� ��� �ִ� ���ӿ�����Ʈ ����
        foreach (GameObject item in pools[index])
        {
            if (!item.activeSelf)
            {
                //.. �߰��ϸ� select ������ �Ҵ�
>>>>>>> myeongjun
                select = item;
                select.SetActive(true);
                break;
            }
        }
<<<<<<< HEAD

        //.. 못 찾았으면?
        if(!select){
            //.. 새롭게 생성하고 select 변수에 할당
=======
        
        //.. �� ã������?
        if (!select)
        {
            //.. ���Ӱ� �����ϰ� select ������ �Ҵ�
>>>>>>> myeongjun
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }

        return select;

    }

<<<<<<< HEAD
}
=======
}
>>>>>>> myeongjun
