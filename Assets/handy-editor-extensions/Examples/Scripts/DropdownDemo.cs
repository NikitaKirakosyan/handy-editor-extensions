using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class DropdownDemo : MonoBehaviour
    {
        [Dropdown(typeof(DropdownTestIds))] public string dropdownTestId;
        [Dropdown(typeof(InventoryDemoIds))] public string inventoryDemoIds;
        
        
        private static class DropdownTestIds
        {
            public const string TestId1 = nameof(TestId1);
            public static string TestId2 = nameof(TestId2);
            public static readonly string TestId3 = nameof(TestId3);
        }
    }

    public static class InventoryDemoIds
    {
        public const string PickaxeId = "pickaxe";
        public static string CarrotSeedsId = "carrot_seeds";
        public static string WoodId = "wood";
    }
}
