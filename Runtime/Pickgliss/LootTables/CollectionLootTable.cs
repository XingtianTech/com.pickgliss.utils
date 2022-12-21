using Pickgliss.SOA.Collections;
using UnityEngine;

namespace Pickgliss.LootTables
{
    [CreateAssetMenu(menuName = "Utils/Collection/CollectionLootTable")]
    public class CollectionLootTable : LootTable<Collection<GameObject>>
    {
    }
}