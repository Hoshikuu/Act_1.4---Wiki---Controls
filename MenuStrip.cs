using System;
using System.Windows.Forms;

public class MainForm : Form
{
    public MainForm()
    {
        Text = "MenuStrip demo";

        var menuStrip = new MenuStrip();

        var archivoMenu = new ToolStripMenuItem("&Archivo");
        var salirItem = new ToolStripMenuItem("&Salir");

        salirItem.ShortcutKeys = Keys.Control | Keys.Q;
        salirItem.Click += (_, _) => Close();

        archivoMenu.DropDownItems.Add(salirItem);
        menuStrip.Items.Add(archivoMenu);

        MainMenuStrip = menuStrip;     // Propiedad del Form
        Controls.Add(menuStrip);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
