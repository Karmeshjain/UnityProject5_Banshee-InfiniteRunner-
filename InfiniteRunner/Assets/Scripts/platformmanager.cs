using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmanager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[]  _platformPrefabs;
    [SerializeField]
    private int _zedoffset;
    void Start()
    {
        for(int i=0;i<_platformPrefabs.Length;i++)
        {
            Instantiate(_platformPrefabs[i],new Vector3(0,0, i * (-86)),Quaternion.Euler(0,0,0));
            _zedoffset =_zedoffset -86;

        }
        
    }

    public void Recycleplatform(GameObject platform)
    {
        platform.transform.position = new Vector3(0, 0,_zedoffset);
        _zedoffset =_zedoffset -86;
    }
}
