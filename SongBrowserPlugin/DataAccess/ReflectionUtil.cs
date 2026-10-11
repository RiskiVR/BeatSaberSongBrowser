using System.Reflection;

namespace SongBrowserPlugin.DataAccess
{
    public static class ReflectionUtil
    {
        public static void SetPrivateField(this object obj, string name, object value)
        {
            obj.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(obj, value);
        }

        public static T GetPrivateField<T>(this object obj, string name)
        {
            return (T) obj.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(obj);
        }
    }
}