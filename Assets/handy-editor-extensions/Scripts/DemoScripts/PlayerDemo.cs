using UnityEngine;

namespace HandyEditorExtensions
{
    public class PlayerDemo : MonoBehaviour
    {
        [Max(100)]public int health = 100;
        [Max(nameof(maxHealth))]public int health2 = 100;
        public int maxHealth = 200;
        public float damage = 50;
        public float damageMultiplier = 0.5f;
    }
}