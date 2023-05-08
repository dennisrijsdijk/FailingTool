using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace FailingTool;

public class BizHawkSocketBehavior : WebSocketBehavior
{
    private ToolMainForm _mainForm;
    
    protected override void OnOpen()
    {
        _mainForm.Log("Websocket Opened.");
        base.OnOpen();
    }

    protected override void OnMessage(MessageEventArgs e)
    {
        _mainForm.Log($"Websocket message received: {e.Data}");
        base.OnMessage(e);
    }

    public BizHawkSocketBehavior(ToolMainForm form) : base()
    {
        _mainForm = form;
    }
}