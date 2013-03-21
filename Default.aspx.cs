using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ais.Net.Radius;
using Ais.Net.Radius.Attributes;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        send.Click += send_Click;
    }

    void send_Click(object sender, EventArgs e)
    {
        string host = Dns.GetHostName();
        IPHostEntry ip = Dns.GetHostEntry(host);
        string nasIp = ip.AddressList[0].ToString();
        IPAddress[] addrlist = Dns.GetHostAddresses(server.Text);

        var client = new Client(addrlist[0], 1812, secret.Text)
        {
            SendTimeout = 5000,
            ReceiveTimeout = 5000,
            Ttl = 50
        };

        var request = new AccessRequest(nasIp, ServiceType.Framed, login.Text, password.Text, client);

        var response = client.Send(request, true, 3);

        info.Text = response.Packet.PacketType.ToString();
    }
}