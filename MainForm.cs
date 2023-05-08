using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;

namespace FailingTool;

[ExternalTool("Failing Tool", LoadAssemblyFiles = new [] { "bin/websocket-sharp.dll" } )]
public sealed partial class ToolMainForm : ToolFormBase, IExternalToolForm
{
    public ApiContainer? _maybeAPIContainer { get; set; }

    private ApiContainer APIs
        => _maybeAPIContainer!;

    private BizHawkSocket BizHawkSocket;
    
    protected override string WindowTitleStatic => "Failing Tool";

    public ToolMainForm()
    {
        InitializeComponent();
        Log("Initializing Socket.");
        BizHawkSocket = new BizHawkSocket(this);
    }
    
    public override void Restart()
    {
        
    }
    
    protected override void UpdateBefore()
    {
        
    }

    protected override void UpdateAfter()
    {
        
    }

    protected override void GeneralUpdate()
    {
        
    }

    protected override void FastUpdateBefore()
    {
        
    }

    protected override void FastUpdateAfter()
    {
        
    }

    public void Log(string log)
    {
        logBox.AppendText(log + '\n');
    }
}