using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Level
    {
        MainMenu,
        Game
    }

    public static void OpenLevel(Level level)
    {
        SceneManager.LoadScene((int)level);
    }
}
