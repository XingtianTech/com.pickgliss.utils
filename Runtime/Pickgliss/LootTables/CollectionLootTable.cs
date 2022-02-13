using Pickgliss.SOA.Collections;
using UnityEngine;

namespace Pickgliss.LootTables
{
    [CreateAssetMenu(fileName = "CollectionLootTable",menuName = "Collection/Collection Loot Table")]
    public class CollectionLootTable : LootTable<Collection<GameObject>>
    {
    }
}