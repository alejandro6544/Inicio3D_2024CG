using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class InstantiateRandomly : MonoBehaviour
{

    public List<GameObject> objects;
    public GameObject positionObj;
    private bool t = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IniciarObjetos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject InstanciarObjs()
    {
        int n = Random.Range(0, objects.Count);
        GameObject obj = Instantiate(objects[n],
            positionObj.transform.position, positionObj.transform.rotation);

        return obj;
    }

    IEnumerator IniciarObjetos()
    {
        while (t) 
        {
            yield return new WaitForSeconds(3);
            InstanciarObjs();
        }
       
        yield return null;

    }
}