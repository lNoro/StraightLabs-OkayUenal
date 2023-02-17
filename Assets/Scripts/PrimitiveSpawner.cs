using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> primitives;
    [SerializeField] private int numToSpawn;
    [SerializeField] private int radius;
    [SerializeField] private Transform primitiveParent;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numToSpawn; i++)
        {
            // Spawn Random Primitive of List at Random position within UnitSphere with Random Rotation
            var primitive = Instantiate(primitives[Random.Range(0, primitives.Count - 1)],
                transform.position + Random.insideUnitSphere * radius, Random.rotation);

            // Add Mesh View Component to enable calculation logic
            primitive.AddComponent<MeshView>();
            
            // Set parent of primitive to stay organized
            primitive.transform.parent = primitiveParent;
        }
        
        // Update the list of parent
        primitiveParent.GetComponent<NumMeshCalculator>().UpdatePrimitiveList();
    }
}
