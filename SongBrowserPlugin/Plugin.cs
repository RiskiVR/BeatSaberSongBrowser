using UnityEngine.SceneManagement;
using IllusionPlugin;


namespace SongBrowserPlugin
{
    public class Plugin : IPlugin
    {
        public const string VERSION_NUMBER = "v2.3.6";
        public const string PLUGIN_NAME = "Song Browser";
        public const string PLUGIN_AUTHOR = "Halsafar & RiskiVR";

        public string Name => PLUGIN_NAME;

        public string Version => VERSION_NUMBER;

        public void OnApplicationStart()
        {

        }

        public void OnApplicationQuit()
        {

        }

        private void SceneManagerOnActiveSceneChanged(Scene arg0, Scene scene)
        {
        
        }

        private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
        }

        public void OnLevelWasLoaded(int level)
        {
            if (SceneManager.GetSceneByBuildIndex(level).name == "Menu")
            {
                SongBrowserApplication.OnLoad();
                Downloader.OnLoad();
            }
        }

        public void OnLevelWasInitialized(int level)
        {

        }

        public void OnUpdate()
        {

        }

        public void OnFixedUpdate()
        {

        }
    }
}