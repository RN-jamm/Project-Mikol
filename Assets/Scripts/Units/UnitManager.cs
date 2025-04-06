using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance;
    public Transform spawnPoint;
    public GameObject friendlyUnitPrefab;
    private List<Unit> friendlyUnits = new();
    private List<Unit> enemyUnits = new();
    void Awake()
    {
        Instance = this;
    }
    public void Register(Unit unit)
    {
        if (unit.Team == Team.Friendly && !friendlyUnits.Contains(unit))
            friendlyUnits.Add(unit);
        else if (unit.Team == Team.Enemy && !enemyUnits.Contains(unit))
            enemyUnits.Add(unit);
    }
    public void Unregister(Unit unit)
    {
        if (unit.Team == Team.Friendly)
            friendlyUnits.Remove(unit);
        else if (unit.Team == Team.Enemy)
            enemyUnits.Remove(unit);
    }
    public void SpawnFriendlyUnit()
    {
        if (friendlyUnitPrefab != null) //&& spawnPoint != null 
        {
            GameObject unitObj = Instantiate(friendlyUnitPrefab, new Vector3(-294f, 10f, 16f), Quaternion.identity);
            Unit unit = unitObj.GetComponent<Unit>();
            if (unit != null)
            { 
                
                unit.Initialize(Team.Friendly);
            }
        }
        else
        {
            Debug.LogError("Prefab or spawn point is not assigned!");
        }
    }
    public List<Unit> GetFriendlyUnits() => friendlyUnits.Where(u => u.IsAlive).ToList();
    public List<Unit> GetEnemyUnits() => enemyUnits.Where(u => u.IsAlive).ToList();
}
