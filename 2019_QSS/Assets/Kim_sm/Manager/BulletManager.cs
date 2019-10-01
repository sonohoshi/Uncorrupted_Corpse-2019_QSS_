using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BulletManager
{
    public enum BulletType : int { Base = 0 }
    public class BulletInfo
    {
        public Transform Bullet { get; set; }
        public BulletType ImageType { get; set; }
        public float LiveTime { get; set; }
    }

    public static string BulletTypeToPath(BulletType type)
    {
        switch (type)
        {
            case BulletType.Base: return @"BulletPrefabs/BaseBullet";
        }

        throw new System.NullReferenceException();
    }

    /*
    public string poolItemName = string.Empty;
    public GameObject prefab = null;
    public int poolCount = 0;
    [SerializeField]
    private List<GameObject> poolList = new List<GameObject>();

    public void Initialize(Transform parent = null)
    {
        for (int ix = 0; ix < poolCount; ++ix)
        {
            poolList.Add(CreateItem(parent));
        }
    }
    public void PushToPool(GameObject item, Transform parent = null)
    {
        item.transform.SetParent(parent);
        item.SetActive(false);
        poolList.Add(item);
    }
    public GameObject PopFromPool(Transform parent = null)
    {
        if (poolList.Count == 0)
            poolList.Add(CreateItem(parent));
        GameObject item = poolList[0];
        poolList.RemoveAt(0);
        return item;
    }
    private GameObject CreateItem(Transform parent = null)
    {
        GameObject item = Object.Instantiate(prefab) as GameObject;
        item.name = poolItemName;
        item.transform.SetParent(parent);
        item.SetActive(false);
        return item;
    }*/
}
