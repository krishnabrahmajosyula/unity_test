using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingScene = false;
    [SerializeField] int segmentNum;

    void Update()
    {
        if (creatingScene == false)
        {
            creatingScene = true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment[segmentNum],new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingScene = false;
    }
}
