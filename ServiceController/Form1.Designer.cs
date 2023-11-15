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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtDisplayService = new System.Windows.Forms.TextBox();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Installer = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUn = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Installer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lab);
            this.panel1.Controls.Add(this.txtDisplayService);
            this.panel1.Controls.Add(this.txtNameService);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Location = new System.Drawing.Point(497, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 394);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Display Name";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(9, 15);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(100, 20);
            this.lab.TabIndex = 3;
            this.lab.Text = "Service Name";
            // 
            // txtDisplayService
            // 
            this.txtDisplayService.Location = new System.Drawing.Point(12, 101);
            this.txtDisplayService.Name = "txtDisplayService";
            this.txtDisplayService.Size = new System.Drawing.Size(232, 27);
            this.txtDisplayService.TabIndex = 2;
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(12, 40);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(232, 27);
            this.txtNameService.TabIndex = 1;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(9, 134);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(100, 45);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(397, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(254, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // Installer
            // 
            this.Installer.Controls.Add(this.txtSearch);
            this.Installer.Controls.Add(this.txtPath);
            this.Installer.Controls.Add(this.txtResult);
            this.Installer.Controls.Add(this.button1);
            this.Installer.Controls.Add(this.btnUn);
            this.Installer.Controls.Add(this.btnIN);
            this.Installer.Controls.Add(this.btnCari);
            this.Installer.Location = new System.Drawing.Point(4, 29);
            this.Installer.Name = "Installer";
            this.Installer.Padding = new System.Windows.Forms.Padding(3);
            this.Installer.Size = new System.Drawing.Size(775, 424);
            this.Installer.TabIndex = 0;
            this.Installer.Text = "Install/Uninstall";
            this.Installer.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(28, 60);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(456, 27);
            this.txtPath.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(28, 181);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(45, 20);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "Testtt";
            this.txtResult.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pilih File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUn
            // 
            this.btnUn.Enabled = false;
            this.btnUn.Location = new System.Drawing.Point(238, 282);
            this.btnUn.Name = "btnUn";
            this.btnUn.Size = new System.Drawing.Size(143, 50);
            this.btnUn.TabIndex = 5;
            this.btnUn.Text = "Uninstall";
            this.btnUn.UseVisualStyleBackColor = true;
            // 
            // btnIN
            // 
            this.btnIN.Enabled = false;
            this.btnIN.Location = new System.Drawing.Point(64, 282);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(143, 50);
            this.btnIN.TabIndex = 4;
            this.btnIN.Text = "Install";
            this.btnIN.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(362, 121);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(94, 29);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Installer);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 457);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Service Controller";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Installer.ResumeLayout(false);
            this.Installer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    private Label label4;
    private Label lab;
    private TextBox txtDisplayService;
    private TextBox txtNameService;
    private Button btnAddService;
}