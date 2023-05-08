using System;
using System.Collections.Generic;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace FailingTool;

public class BizHawkSocket
{
    private WebSocketServer _server;
    public BizHawkSocket(ToolMainForm form)
    {
        _server = new WebSocketServer(21855);
        _server.AddWebSocketService("/", () =>
        {
            BizHawkSocketBehavior behavior = new BizHawkSocketBehavior(form);
            return behavior;
        });
        _server.Start();
        form.Log("Socket Server Started.");
    }

    public void Stop() => _server.Stop();
}