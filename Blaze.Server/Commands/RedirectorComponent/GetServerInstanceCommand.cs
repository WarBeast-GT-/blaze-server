﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Server
{
    class GetServerInstanceCommand
    {
        public static void HandleRequest(Request request)
        {
            Log.Info(string.Format("Client {0} requesting ServerInstanceInfo", request.Client.ID));

            var data = new List<Tdf>
            {
                new TdfUnion("ADDR", NetworkAddressMember.XboxClientAddress, new List<Tdf>
                {
                    new TdfStruct("VALU", new List<Tdf>
                    {
                        //new TdfString("HOST", "373244-gosprapp357.ea.com"),
                        new TdfString("HOST", "127.0.0.1"),
                        new TdfInteger("IP", 0),
                        new TdfInteger("PORT", 10041)
                    })
                }),
                new TdfInteger("SECU", 1),
                new TdfInteger("XDNS", 0)
            };

            request.Reply(0, data);
        }
    }
}
