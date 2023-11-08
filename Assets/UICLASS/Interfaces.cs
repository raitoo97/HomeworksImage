using UnityEngine;
public interface Interfaces
{
    public void HiddenPannel();
    public void ShowPannel();
    public TYPE_PANEL type {  get; set; }
}
public enum TYPE_PANEL
{
    MENU,
    GAMEPLAY
}
