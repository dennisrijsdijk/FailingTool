using System.ComponentModel;

namespace FailingTool;

partial class ToolMainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.logBox = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // logBox
        // 
        this.logBox.Location = new System.Drawing.Point(12, 12);
        this.logBox.Name = "logBox";
        this.logBox.ReadOnly = true;
        this.logBox.Size = new System.Drawing.Size(776, 426);
        this.logBox.TabIndex = 0;
        this.logBox.Text = "";
        // 
        // CrowdControlMainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.logBox);
        this.Name = "ToolMainForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox logBox;

    #endregion
}