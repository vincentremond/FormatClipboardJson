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
            MessageBox.Show(
                text: $"Json formatted (original length:{content.Length}, new length: {newContent.Length}",
                caption: "Format Clipboard Json (success)",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );
        }
        catch (Exception e)
        {
            MessageBox.Show(
                text: e.ToString(),
                caption: "Format Clipboard Json (error)",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }
    }
}