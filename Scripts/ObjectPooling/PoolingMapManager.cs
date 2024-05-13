using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingMapManager : MonoSingleton<PoolingMapManager>
{
    [SerializeField] private PoolingScriptableObject _poolingSettings;

    private GameObject[] _prefabMapList;
    private List<GameObject> _pooledObjects = new List<GameObject>();
    private List<int> _pools = new List<int>();

    private float _yDeactivate;
    public float YDeactivate => _yDeactivate;

    private GameObject _activePrefab = null;

    private void Start()
    {
        _yDeactivate = _poolingSettings.YDeactivate;
        _prefabMapList = _poolingSettings.PrefabMapArray;

        CreatePooledObject();
        ActivatedPooledObject(_pooledObjects, _poolingSettings.OffsetY);
    }

    private void Update()
    {
        if (_activePrefab != null)
        {
            if (_activePrefab.transform.position.y >= _poolingSettings.OffsetY)
            {
                ActivatedPooledObject(_pooledObjects, _poolingSettings.OffsetY);
            }
        }
    }

    private void CreatePooledObject()
    {
        if (_prefabMapList != null)
        {
            for (int i = 0; i < _prefabMapList.Length; i++)
            {
                GameObject obj = Instantiate(_prefabMapList[i], gameObject.transform);
                obj.SetActive(false);
                _pooledObjects.Add(obj);
            }

            ReloadPools(_pooledObjects);
        }
    }

    private void ReloadPools(List<GameObject> p_pooledObjects)
    {
        if (_pools.Count == 0)
        {
            for (int i = 0; i < p_pooledObjects.Count; i++)
            {
                if (!p_pooledObjects[i].activeSelf)
                {
                    _pools.Add(i);
                }
            }
        }
    }

    private void ActivatedPooledObject(List<GameObject> p_pooledObjects, float offsetY)
    {
        if (p_pooledObjects.Count == 0) { return; }

        int p_randomIndex = Random.Range(0, _pools.Count);
        int p_poolIndex = _pools[p_randomIndex];

        p_pooledObjects[p_poolIndex].transform.position = _activePrefab != null ?
            _activePrefab.transform.position - new Vector3(0f, -offsetY, 0f) :
            new Vector3(transform.position.x, offsetY * 2, transform.position.z);

        p_pooledObjects[p_poolIndex].SetActive(true);
        _pools.Remove(p_poolIndex);

        ReloadPools(p_pooledObjects);

        _activePrefab = p_pooledObjects[p_poolIndex];
    }
}
