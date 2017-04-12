using System;
using GVConverter.Properties;
using Npgsql;
using Renci.SshNet;

namespace GVConverter.Classes
{
	public class SshDbManager : IDisposable
	{
		public NpgsqlConnection Connection { get; }
//		private readonly ForwardedPortLocal _portLocal;
		private readonly SshClient _client;

		public SshDbManager()
		{
			_client = new SshClient(Settings.Default.IPSSH, Settings.Default.LoginSSH, Settings.Default.PasswordSSH);
			_client.Connect();

			Connection = new NpgsqlConnection(
				$"Server={Settings.Default.IPSSH}; " +
				$"User Id={Settings.Default.LoginDataBasePostgreSQL}; " +
				$"Password={Settings.Default.PasswordDataBasePostgreSQL}; " +
				$"Database={Settings.Default.NameDataBasePostgreSQL};");

			Connection.Open();
		}

		public void Dispose()
		{
			Connection?.Close();
			Connection?.Dispose();

			_client?.Disconnect();
			_client?.Dispose();
		}

//		public SshDbManager()
//		{
//			_client = new SshClient(Settings.Default.IPSSH, Settings.Default.LoginSSH, Settings.Default.PasswordSSH);
//			_client.Connect();
//
//			_portLocal = new ForwardedPortLocal("127.0.0.1", Settings.Default.PortSSH, Settings.Default.IPDataBasePostrgeSQL,
//				Settings.Default.PortSSH);
//
//			_client.AddForwardedPort(_portLocal);
//
//			if (_portLocal.IsStarted)
//			{
//				_portLocal.Dispose();
//			}
//
//			_portLocal.Start();
//
//			Connection = new NpgsqlConnection(
//				$"Server={Settings.Default.IPSSH}; " +
//				$"User Id={Settings.Default.LoginDataBasePostgreSQL}; " +
//				$"Password={Settings.Default.PasswordDataBasePostgreSQL}; " +
//				$"Database={Settings.Default.NameDataBasePostgreSQL};");
//
//			Connection.Open();
//		}
//
//		public void Dispose()
//		{
//			Connection.Close();
//			Connection.Dispose();
//		}
	}
}