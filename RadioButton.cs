using System;
using System.Linq;
using System.Windows.Forms;

public class MainForm : Form
{
    private readonly Label _result;

    public MainForm()
    {
        Text = "RadioButton demo";
        Width = 360;
        Height = 200;

        var group = new GroupBox
        {
            Text = "Color favorito",
            Left = 10,
            Top = 10,
            Width = 320,
            Height = 90
        };

        var rb1 = new RadioButton { Text = "Rojo", Left = 15, Top = 25, AutoSize = true };
        var rb2 = new RadioButton { Text = "Verde", Left = 110, Top = 25, AutoSize = true };
        var rb3 = new RadioButton { Text = "Azul", Left = 210, Top = 25, AutoSize = true };

        rb1.CheckedChanged += Radio_CheckedChanged;
        rb2.CheckedChanged += Radio_CheckedChanged;
        rb3.CheckedChanged += Radio_CheckedChanged;

        group.Controls.AddRange(new Control[] { rb1, rb2, rb3 });

        _result = new Label { Left = 10, Top = 115, Width = 320, Text = "Elige una opción" };

        Controls.Add(group);
        Controls.Add(_result);
    }

    private void Radio_CheckedChanged(object sender, EventArgs e)
    {
        var rb = (RadioButton)sender;
        if (rb.Checked)
            _result.Text = $"Has elegido: {rb.Text}";
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
