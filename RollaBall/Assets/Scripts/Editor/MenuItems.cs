using UnityEditor;

namespace Assets.Scripts.Editor
{
    public class MenuItems
    {
        [MenuItem("LenkaMenu/Создать и расставить объекты по кругу")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "LenkaMenu");
        }

    }
}
