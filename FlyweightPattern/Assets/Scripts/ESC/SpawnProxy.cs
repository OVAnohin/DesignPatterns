using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnProxy : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private int _rows;
    [SerializeField] private int _columns;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        var spawned = new Spawner
        {
            Prefab = conversionSystem.GetPrimaryEntity(_cubePrefab),
            Rows = _rows,
            Columns = _columns
        };

        dstManager.AddComponentData(entity, spawned);
    }

    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(_cubePrefab);
    }
}
