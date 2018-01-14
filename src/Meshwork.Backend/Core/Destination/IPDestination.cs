﻿//
// IPDestination.cs:
//
// Authors:
//   Eric Butler <eric@codebutler.com>
//
// (C) 2008 Meshwork Authors
//

using System.Net;

namespace Meshwork.Backend.Core.Destination
{
    public abstract class IPDestination : DestinationBase
	{
	    protected IPDestination (Core core, IPAddress ip, uint port, bool isOpenExternally) : base(core)
		{
			IPAddress = ip;
			Port = port;
			IsOpenExternally = isOpenExternally;
		}

	    public IPAddress IPAddress { get; }

	    public uint Port { get; }

	    public override bool IsExternal => !Common.Utils.IsInternalIP(IPAddress);
	}
}
