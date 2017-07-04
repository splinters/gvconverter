using System;
using GVConverter.Properties;
using System.Windows.Forms;
using Npgsql;
//using Renci.SshNet;

namespace GVConverter.Classes
{
	public class SshDbManager : IDisposable
	{
		public NpgsqlConnection Connection { get; }
//		private readonly ForwardedPortLocal _portLocal;
		//private readonly SshClient _client;

		public SshDbManager()
		{
            /*
            if (Settings.Default.PortSSH.ToString() == "22")
            {
                _client = new SshClient(Settings.Default.IPSSH, Settings.Default.LoginSSH, Settings.Default.PasswordSSH);
                _client.Connect();
            }
            */
			Connection = new NpgsqlConnection(
				//$"Server={Settings.Default.IPSSH}; " +
                $"Server={Settings.Default.IPDataBasePostrgeSQL}; " +
                //				$"User Id={Settings.Default.LoginDataBasePostgreSQL}; " +
                //				$"Password={Settings.Default.PasswordDataBasePostgreSQL}; " +

                $"User Id={StaticVariables.LoginDataBasePostgreSQL}; " +
                $"Password={StaticVariables.PasswordDataBasePostgreSQL}; " +

                $"Database={Settings.Default.NameDataBasePostgreSQL};");

            try
            {
                Connection.Open();
            }
            
            catch (NpgsqlException ex)
            {
                if (ex.Code == "28P01")
                {
                    MessageBox.Show("Invalid password or name..", @"Error connection - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString(), @"Error connect - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), @"Error connect - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
		public void Dispose()
		{
			Connection?.Close();
			Connection?.Dispose();
            /*
			_client?.Disconnect();
			_client?.Dispose();
            */
		}

	}
}