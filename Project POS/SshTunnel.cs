using Renci.SshNet;
using System;

namespace Project_POS
{
    public static class SshTunnel
    {
        private const string sshHostname = "selene.hud.ac.uk"; // SSH server hostname
        private const string sshUsername = "u2280965"; // SSH username
        private const string sshPassword = "DS02jul01ds"; // SSH password
        private const int localPort = 3307; // Local port for forwarding
        private const string remoteMySqlServer = "127.0.0.1"; // Remote MySQL server (usually localhost as seen from the server)
        private const int remoteMySqlPort = 3306; // Remote MySQL port

        public static ForwardedPortLocal StartSshTunnel()
        {
            var client = new SshClient(sshHostname, sshUsername, sshPassword);
            client.Connect();
            if (client.IsConnected)
            {
                Console.WriteLine("SSH connection established.");
                var portForwarded = new ForwardedPortLocal("127.0.0.1", (uint)localPort, remoteMySqlServer, (uint)remoteMySqlPort);
                client.AddForwardedPort(portForwarded);
                portForwarded.Start();
                return portForwarded;
            }
            else
            {
                Console.WriteLine("SSH connection failed.");
                return null;
            }
        }
    }
}
