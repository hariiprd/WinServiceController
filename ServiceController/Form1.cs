using Newtonsoft.Json;
using ServiceController.Models;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.ServiceProcess;

namespace ServiceInstallerEXE;

public partial class Form1 : Form
{
    private string commandExec = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe ";
    private string pathService;

    public Form1()
    {
        InitializeComponent();
        LoadServices();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        openFileDialog1 = new OpenFileDialog();
        openFileDialog1.Filter = "exe files (*.exe)|*.exe";
        openFileDialog1.ShowDialog();
        if (openFileDialog1.FileName != "")
        {
            if (Path.GetExtension(openFileDialog1.FileName) != ".exe")
            {
                MessageBox.Show("File harus berekstensi .exe");
                return;
            }

            txtSearch.Text = "";
            txtResult.Text = "";
            txtResult.Visible = false;

            txtPath.Text = openFileDialog1.FileName;
            pathService = "\"" + openFileDialog1.FileName + "\"";

            ServiceController[] services = ServiceController.GetServices("");

            bool ketemu = false;
            foreach (ServiceController service in services)
            {
                if (service.ImagePath == pathService)
                {
                    txtResult.Text = "Service Name : " + service.ServiceName + "\nDisplay Name : " + service.DisplayName + "\nPath : " + service.ImagePath.Replace("\"", "");
                    pathService = service.ImagePath;
                    txtResult.Visible = true;
                    ketemu = true;
                    btnUn.Enabled = true;
                }
            }
            if (!ketemu)
            {
                btnUn.Enabled = false;
                btnIN.Enabled = true;
            }
        }
    }

    private void btnCari_Click(object sender, EventArgs e)
    {
        ServiceController[] services = ServiceController.GetServices("");

        bool ketemu = false;
        foreach (ServiceController service in services)
        {
            if (service.ServiceName == txtSearch.Text)
            {
                txtResult.Text = "Service Name : " + service.ServiceName + "\nDisplay Name : " + service.DisplayName + "\nPath : " + service.ImagePath.Replace("\"", "");
                pathService = service.ImagePath;
                txtResult.Visible = true;
                ketemu = true;
                btnUn.Enabled = true;
                btnIN.Enabled = false;
            }
        }
        if (!ketemu)
        {
            txtSearch.Text = "";
            MessageBox.Show("Service tidak ditemukan");
        }
    }

    private void btnUn_Click(object sender, EventArgs e)
    {
        try
        {
            DialogResult result = MessageBox.Show(this, "Konfirmasi Uninstall", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    Verb = "runas",
                    FileName = "cmd.exe",
                    Arguments = "/c " + commandExec + " -u " + pathService,
                    UseShellExecute = true
                };
                Process.Start(psi);
                txtSearch.Text = "";
                txtResult.Text = "";
                txtResult.Visible = false;
                txtPath.Text = "";
                btnUn.Enabled = false;
                btnIN.Enabled = false;
                MessageBox.Show("Uninstall Berhasil");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnIN_Click(object sender, EventArgs e)
    {
        try
        {
            DialogResult result = MessageBox.Show(this, "Konfirmasi Install", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    Verb = "runas",
                    FileName = "cmd.exe",
                    Arguments = "/c " + commandExec + " -i " + pathService,
                    UseShellExecute = true
                };
                Process.Start(psi);
                txtSearch.Text = "";
                txtResult.Text = "";
                txtResult.Visible = false;
                txtPath.Text = "";
                btnUn.Enabled = false;
                btnIN.Enabled = false;
                MessageBox.Show("Install Berhasil");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    #region "Tab 2"
    private List<ServiceModel> listService = new List<ServiceModel>();
    readonly string pathJSON = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Services.json");

    private void LoadServices()
    {
        foreach (ServiceModel service in listService)
        {
            service.LabelService.Dispose();
            service.LabelPID.Dispose();
            service.ButtonAction.Dispose();
            service.ButtonDelete.Dispose();
        }
        listService = new List<ServiceModel>();
        if (!File.Exists(pathJSON))
        {
            return;
        }
        using StreamReader reader = new(pathJSON);
        string json = reader.ReadToEnd();
        List<ServicesFile>? services = JsonConvert.DeserializeObject<List<ServicesFile>>(json);
        if (services == null)
        {
            MessageBox.Show("List service harus diisi!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        List<string> servicesName = new List<string>();
        var allServices = ServiceController.GetServices("");
        foreach (var service in allServices)
            servicesName.Add(service.ServiceName);

        int i = 0;
        foreach (ServicesFile servicesFile in services)
        {
            if (servicesName.Contains(servicesFile.Name))
            {
                int posY = 75 + (50 * i);
                ServiceModel model = new ServiceModel()
                {
                    ServiceName = servicesFile.Name,
                    LabelService = new Label
                    {
                        Name = "lbl" + servicesFile.Name,
                        Text = servicesFile.DisplayName,
                        Size = new Size(151, 23),
                        Location = new Point(54, posY),
                        Font = new Font("Segoe UI", 10, FontStyle.Regular)
                    },
                    LabelPID = new Label
                    {
                        Name = "lblPID" + servicesFile.Name,
                        Text = "",
                        Size = new Size(70, 23),
                        Location = new Point(242, posY),
                        Font = new Font("Segoe UI", 10, FontStyle.Regular)
                    },
                    ButtonAction = new Button
                    {
                        Name = "btn" + servicesFile.Name,
                        Text = "Start",
                        Size = new Size(94, 29),
                        Location = new Point(383, posY),
                    },
                    ButtonDelete = new Button
                    {
                        Name = "btnDelete" + servicesFile.Name,
                        Text = "",
                        Size = new Size(40, 40),
                        Location = new Point(6, posY - 10),
                        Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "delete.ico"))
                    }
                };
                model.ButtonAction.Click += BtnClick;
                model.ButtonDelete.Click += BtnDeleteClick;
                tabPage2.Controls.AddRange(new Control[] { model.LabelService, model.LabelPID, model.ButtonAction, model.ButtonDelete });
                listService.Add(model);
                i++;
            }
        }
        UpdateServiceStatus();
    }

    private void UpdateServiceStatus()
    {
        foreach (ServiceModel serviceModel in listService)
        {
            serviceModel.LabelPID.Text = "";
            serviceModel.ButtonAction.Text = "Start";
        }
        Process[] processes = Process.GetProcesses();
        foreach (var process in processes)
        {
            foreach (ServiceModel model in listService)
            {
                if (model.ServiceName == process.ProcessName)
                {
                    model.LabelPID.Text = process.Id.ToString();
                    model.ButtonAction.Text = "Stop";
                    model.LabelService.BackColor = Color.GreenYellow;
                }
            }
        }
    }

    public void BtnDeleteClick(object? sender, EventArgs e)
    {
        try
        {
            if (sender != null)
            {
                Button btnDelete = (Button)sender;
                foreach (var serviceModel in listService)
                {
                    if (serviceModel.ButtonDelete.Name == btnDelete.Name)
                    {
                        DialogResult result = MessageBox.Show("Confirm delete ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            List<ServicesFile> servicesFiles = JsonConvert.DeserializeObject<List<ServicesFile>>(File.ReadAllText(pathJSON));
                            for (int i = 0; i < servicesFiles.Count; i++)
                            {
                                if (servicesFiles[i].Name == serviceModel.ServiceName)
                                {
                                    servicesFiles.RemoveAt(i);
                                    File.WriteAllText(pathJSON, JsonConvert.SerializeObject(servicesFiles));
                                    LoadServices();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }catch(Exception ex)
        {
            string msg = ex.Message;
            if (ex.InnerException != null)
            {
                msg += ". " + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    msg += ". " + ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        msg += ". " + ex.InnerException.InnerException.InnerException.Message;
                    }
                }
            }
            MessageBox.Show(msg, "Failed");
        }
    }
    public void BtnClick(object? sender, EventArgs e)
    {
        try
        {
            if (sender != null)
            {
                Button btnAction = (Button)sender;
                foreach (var serviceModel in listService)
                {
                    if (serviceModel.ButtonAction.Name == btnAction.Name)
                    {
                        var services = ServiceController.GetServices("");
                        foreach (var service in services)
                        {
                            if (service.ServiceName == serviceModel.ServiceName)
                            {
                                if (btnAction.Text == "Start")
                                {
                                    if (service.Status == ServiceControllerStatus.Stopped)
                                    {
                                        service.Start();
                                        service.WaitForStatus(ServiceControllerStatus.Running);

                                        Process[] processes = Process.GetProcesses();
                                        foreach (var process in processes)
                                        {
                                            if (process.ProcessName == serviceModel.ServiceName)
                                            {
                                                serviceModel.LabelPID.Text = process.Id.ToString();
                                            }
                                        }
                                        serviceModel.ButtonAction.Text = "Stop";
                                        serviceModel.LabelService.BackColor = Color.GreenYellow;
                                    }
                                }
                                else
                                {
                                    if (service.Status == ServiceControllerStatus.Running)
                                    {
                                        service.Stop();
                                        service.WaitForStatus(ServiceControllerStatus.Stopped);

                                        serviceModel.LabelPID.Text = "";
                                        serviceModel.ButtonAction.Text = "Start";
                                        serviceModel.LabelService.BackColor = Color.White;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }catch (Exception ex)
        {
            string msg = ex.Message;
            if (ex.InnerException!= null)
            {
                msg += ". " + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    msg += ". " + ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        msg += ". " + ex.InnerException.InnerException.InnerException.Message;
                    }
                }
            }
            MessageBox.Show(msg, "Failed");
        }
    }

    private void btnAddService_Click(object sender, EventArgs e)
    {
        if (txtNameService.Text.Length == 0)
        {
            MessageBox.Show("Enter Service Name !!", "Failed");
            return;
        }
        List<ServicesFile> services = new List<ServicesFile>();
        if (File.Exists(pathJSON))
        {
            services = JsonConvert.DeserializeObject<List<ServicesFile>>(File.ReadAllText(pathJSON));
        }
        services.Add(new ServicesFile
        {
            Name = txtNameService.Text,
            DisplayName = txtDisplayService.Text == "" ? txtNameService.Text : txtDisplayService.Text
        });
        File.WriteAllText(pathJSON, JsonConvert.SerializeObject(services));
        LoadServices();
        txtNameService.Text = "";
        txtDisplayService.Text = "";
    }

    #endregion
}