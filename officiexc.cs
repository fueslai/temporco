[System.Serializable]
public struct GuiTextureSettings {
    public int width;
    public int height;
    public Color color;
}

// Usage
GuiTextureSettings settings;
settings.width = 1280;
settings.height = 720;
settings.color = Color.blue;

string json = JsonUtility.ToJson(settings);
m_Target.userData = json;
