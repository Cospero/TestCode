using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start() 
    {
        for(int i = 0; i<_spawnPoints.Length; i++ )     
        {
            Instantiate(_template,_spawnPoints[i].position, Quaternion.identity);
        }      
    }

   

    

    
}
