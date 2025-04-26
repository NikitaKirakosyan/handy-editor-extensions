using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class MaxDemo : MonoBehaviour
    {
        [Max(100)] public int health100 = 100;
        [Max(nameof(maxHealth))] public int healthByMaxHealth = 100;
        public int maxHealth = 200;
    }
}
