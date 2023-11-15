namespace ServiceInstallerEXE;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        openFileDialog1 = new OpenFileDialog();
        tabPage2 = new TabPage();
        panel1 = new Panel();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        Installer = new TabPage();
        txtSearch = new TextBox();
        txtPath = new TextBox();
        txtResult = new Label();
        button1 = new Button();
        btnUn = new Button();
        btnIN = new Button();
        btnCari = new Button();
        tabControl1 = new TabControl();
        tabPage2.SuspendLayout();
        Installer.SuspendLayout();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(panel1);
        tabPage2.Controls.Add(label3);
        tabPage2.Controls.Add(label2);
        tabPage2.Controls.Add(label1);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(700, 424);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "List Status";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = Color.WhiteSmoke;
        panel1.Location = new Point(493, 17);
        panel1.Name = "panel1";
        panel1.Size = new Size(196, 394);
        panel1.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(367, 24);
        label3.Name = "label3";
        label3.Size = new Size(74, 28);
        label3.TabIndex = 2;
        label3.Text = "Action";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(224, 24);
        label2.Name = "label2";
        label2.Size = new Size(45, 28);
        label2.TabIndex = 1;
        label2.Text = "PID";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(29, 24);
        label1.Name = "label1";
        label1.Size = new Size(81, 28);
        label1.TabIndex = 0;
        label1.Text = "Service";
        // 
        // Installer
        // 
        Installer.Controls.Add(txtSearch);
        Installer.Controls.Add(txtPath);
        Installer.Controls.Add(txtResult);
        Installer.Controls.Add(button1);
        Installer.Controls.Add(btnUn);
        Installer.Controls.Add(btnIN);
        Installer.Controls.Add(btnCari);
        Installer.Location = new Point(4, 29);
        Installer.Name = "Installer";
        Installer.Padding = new Padding(3);
        Installer.Size = new Size(700, 424);
        Installer.TabIndex = 0;
        Installer.Text = "Install/Uninstall";
        Installer.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(28, 123);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(315, 27);
        txtSearch.TabIndex = 3;
        // 
        // txtPath
        // 
        txtPath.Location = new Point(28, 60);
        txtPath.Name = "txtPath";
        txtPath.ReadOnly = true;
        txtPath.Size = new Size(456, 27);
        txtPath.TabIndex = 1;
        // 
        // txtResult
        // 
        txtResult.AutoSize = true;
        txtResult.Location = new Point(28, 181);
        txtResult.Name = "txtResult";
        txtResult.Size = new Size(45, 20);
        txtResult.TabIndex = 6;
        txtResult.Text = "Testtt";
        txtResult.Visible = false;
        // 
        // button1
        // 
        button1.Location = new Point(504, 58);
        button1.Name = "button1";
        button1.Size = new Size(101, 29);
        button1.TabIndex = 0;
        button1.Text = "Pilih File";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // btnUn
        // 
        btnUn.Enabled = false;
        btnUn.Location = new Point(238, 282);
        btnUn.Name = "btnUn";
        btnUn.Size = new Size(143, 50);
        btnUn.TabIndex = 5;
        btnUn.Text = "Uninstall";
        btnUn.UseVisualStyleBackColor = true;
        btnUn.Click += btnUn_Click;
        // 
        // btnIN
        // 
        btnIN.Enabled = false;
        btnIN.Location = new Point(64, 282);
        btnIN.Name = "btnIN";
        btnIN.Size = new Size(143, 50);
        btnIN.TabIndex = 4;
        btnIN.Text = "Install";
        btnIN.UseVisualStyleBackColor = true;
        btnIN.Click += btnIN_Click;
        // 
        // btnCari
        // 
        btnCari.Location = new Point(362, 121);
        btnCari.Name = "btnCari";
        btnCari.Size = new Size(94, 29);
        btnCari.TabIndex = 2;
        btnCari.Text = "Cari";
        btnCari.UseVisualStyleBackColor = true;
        btnCari.Click += btnCari_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(Installer);
        tabControl1.Location = new Point(12, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(708, 457);
        tabControl1.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(735, 477);
        Controls.Add(tabControl1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Win Service Controller";
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        Installer.ResumeLayout(false);
        Installer.PerformLayout();
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private OpenFileDialog openFileDialog1;
    private TabPage tabPage2;
    private TabPage Installer;
    private TextBox txtSearch;
    private TextBox txtPath;
    private Label txtResult;
    private Button button1;
    private Button btnUn;
    private Button btnIN;
    private Button btnCari;
    private TabControl tabControl1;
    private Label label1;
    private Label label3;
    private Label label2;
    private Panel panel1;
}