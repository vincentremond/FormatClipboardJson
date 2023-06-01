using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FormatClipboardJson;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        try
        {
            var content = Clipboard.GetText();
            var contentObject = JsonConvert.DeserializeObject(content);
            var newContent = JsonConvert.SerializeObject(contentObject, Formatting.Indented);
            Clipboard.SetText(newContent);
            MessageBox.Show($"done (original lenth:{content.Length}, new length: {newContent.Length}");
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}