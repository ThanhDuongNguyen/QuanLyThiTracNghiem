using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
//Microsoft.SqlServer.ConnectionInfo
//Microsoft.SqlServer.Smo
//Microsoft.SqlServer.SmoEnum
//Microsoft.SqlServer.SqlEnum

namespace QuanLyThiTracNghiem.GUI.Admin
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
            btnDong.Enabled = false;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            string destinationPath = "";
            using (var sfd = new SaveFileDialog()
            {
                CreatePrompt = false,
                OverwritePrompt = true,
                AddExtension = true,
                Filter = "Bak file|*.bak",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = sfd.InitialDirectory + sfd.FileName;
                }
            }



            ServerConnection serverConnection;
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem.Properties.Settings.QLThiConnectionString"].ConnectionString;
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
            if (String.IsNullOrEmpty(connectionStringBuilder.UserID))
                serverConnection = new ServerConnection(connectionStringBuilder.DataSource);
            else
                serverConnection = new ServerConnection(connectionStringBuilder.DataSource, connectionStringBuilder.UserID, connectionStringBuilder.Password);

            Server myServer = new Server(serverConnection);
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = connectionStringBuilder.InitialCatalog;
            //destinationPath = System.IO.Path.Combine(destinationPath, connectionStringBuilder.InitialCatalog + ".bak");
            backup.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            backup.Initialize = true;
            backup.Checksum = true;
            backup.ContinueAfterError = true;
            backup.Incremental = false;
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            backup.PercentComplete += new PercentCompleteEventHandler(backup_PercentComplete);
            backup.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(backup_Complete);
            // Perform backup.
            backup.SqlBackup(myServer);
        }

        private void backup_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Sao lưu thành công !!");
            btnDong.Enabled = true;
        }

        private void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Value = e.Percent;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string BackupFilePath = "";
            string path = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            { ValidateNames = true, Filter = "Bak file|*.bak" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        path = openFileDialog.InitialDirectory;
                        BackupFilePath = openFileDialog.InitialDirectory + openFileDialog.FileName;
                    }
                }
            }

            ServerConnection serverConnection;
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem.Properties.Settings.QLThiConnectionString"].ConnectionString;
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
            if (String.IsNullOrEmpty(connectionStringBuilder.UserID))
                serverConnection = new ServerConnection(connectionStringBuilder.DataSource);
            else
                serverConnection = new ServerConnection(connectionStringBuilder.DataSource, connectionStringBuilder.UserID, connectionStringBuilder.Password);

            string destinationDatabaseName = connectionStringBuilder.InitialCatalog;

            Server myServer = new Server(serverConnection);
            Restore myRestore = new Restore();
            myRestore.Database = connectionStringBuilder.InitialCatalog;
            Database currentDb = myServer.Databases[destinationDatabaseName];
            if (currentDb != null)
                myServer.KillAllProcesses(destinationDatabaseName);
            myRestore.Devices.AddDevice(BackupFilePath, DeviceType.File);
            //string DataFileLocation = path + "\\" + destinationDatabaseName + ".mdf";
            //string LogFileLocation = path + "\\" + destinationDatabaseName + "_log.ldf";
            //myRestore.RelocateFiles.Add(new RelocateFile(DatabaseFileName, DataFileLocation));
            //myRestore.RelocateFiles.Add(new RelocateFile(DatabaseLogFileName, LogFileLocation));
            myRestore.ReplaceDatabase = true;
            myRestore.PercentCompleteNotification = 10;
            myRestore.PercentComplete +=
                new PercentCompleteEventHandler(myRestore_PercentComplete);
            myRestore.Complete += new ServerMessageEventHandler(myRestore_Complete);
            myRestore.SqlRestore(myServer);
            currentDb = myServer.Databases[destinationDatabaseName];
            currentDb.SetOnline();
        }

        private void myRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Khôi phục thành công !!");
            btnDong.Enabled = true;
        }

        private void myRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Value = e.Percent;
        }
    }
}
