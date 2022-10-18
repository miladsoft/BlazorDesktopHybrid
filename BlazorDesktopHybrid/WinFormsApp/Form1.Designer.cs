namespace WinFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
		this.button1 = new System.Windows.Forms.Button();
		this.blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
		
		this.SuspendLayout();
		
		this.blazorWebView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		this.blazorWebView1.Location = new System.Drawing.Point(13, 181);
		this.blazorWebView1.Name = "blazorWebView1";
		this.blazorWebView1.Size = new System.Drawing.Size(775, 257);
		this.blazorWebView1.TabIndex = 20;
		this.Controls.Add(this.blazorWebView1);
		
		
        this.button1.Location = new System.Drawing.Point(364, 68);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(342, 46);
        this.button1.TabIndex = 20;
        this.button1.Text = "&Click to see counter value";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);		
		this.Controls.Add(this.button1);
		
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
		
		this.ResumeLayout(false);		
    }

     private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
	 private System.Windows.Forms.Button button1;
    #endregion
}
