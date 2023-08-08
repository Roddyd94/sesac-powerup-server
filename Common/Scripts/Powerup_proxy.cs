﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
using System.Net;

namespace PowerupS2G
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool GameStart(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.GameStart;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_GameStart, Common.GameStart);
        }
}

public bool GameStart(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.GameStart;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_GameStart, Common.GameStart);
        }
}
public bool GameEnd(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.GameEnd;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_GameEnd, Common.GameEnd);
        }
}

public bool GameEnd(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.GameEnd;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_GameEnd, Common.GameEnd);
        }
}
public bool PlayersReady(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, SortedDictionary<int,bool> playersReady)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayersReady;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, playersReady);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayersReady, Common.PlayersReady);
        }
}

public bool PlayersReady(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, SortedDictionary<int,bool> playersReady)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayersReady;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, playersReady);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayersReady, Common.PlayersReady);
        }
}
public bool TimeNow(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, long ticksRemain)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.TimeNow;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, ticksRemain);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_TimeNow, Common.TimeNow);
        }
}

public bool TimeNow(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, long ticksRemain)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.TimeNow;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, ticksRemain);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_TimeNow, Common.TimeNow);
        }
}
public bool PlayerMove(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int playerNo, int key, std.vector<int32_t> enemies)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayerMove;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, playerNo);
		Nettention.Proud.Marshaler.Write(__msg, key);
		Nettention.Proud.Marshaler.Write(__msg, enemies);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayerMove, Common.PlayerMove);
        }
}

public bool PlayerMove(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int playerNo, int key, std.vector<int32_t> enemies)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayerMove;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, playerNo);
Nettention.Proud.Marshaler.Write(__msg, key);
Nettention.Proud.Marshaler.Write(__msg, enemies);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayerMove, Common.PlayerMove);
        }
}
public bool PlayersRank(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, std.map<int32_t,int> playersRank)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayersRank;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, playersRank);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayersRank, Common.PlayersRank);
        }
}

public bool PlayersRank(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, std.map<int32_t,int> playersRank)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayersRank;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, playersRank);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayersRank, Common.PlayersRank);
        }
}
	
		#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_GameStart="GameStart";
public const string RmiName_GameEnd="GameEnd";
public const string RmiName_PlayersReady="PlayersReady";
public const string RmiName_TimeNow="TimeNow";
public const string RmiName_PlayerMove="PlayerMove";
public const string RmiName_PlayersRank="PlayersRank";
       
public const string RmiName_First = RmiName_GameStart;
		#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_GameStart="";
public const string RmiName_GameEnd="";
public const string RmiName_PlayersReady="";
public const string RmiName_TimeNow="";
public const string RmiName_PlayerMove="";
public const string RmiName_PlayersRank="";
       
public const string RmiName_First = "";
		#endif

		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}
namespace PowerupS2C
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool PlayerEnter(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, bool isEntered)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayerEnter;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, isEntered);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayerEnter, Common.PlayerEnter);
        }
}

public bool PlayerEnter(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, bool isEntered)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayerEnter;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, isEntered);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayerEnter, Common.PlayerEnter);
        }
}
public bool PlayerExit(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, bool isExited)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayerExit;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, isExited);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayerExit, Common.PlayerExit);
        }
}

public bool PlayerExit(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, bool isExited)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayerExit;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, isExited);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayerExit, Common.PlayerExit);
        }
}
	
		#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_PlayerEnter="PlayerEnter";
public const string RmiName_PlayerExit="PlayerExit";
       
public const string RmiName_First = RmiName_PlayerEnter;
		#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_PlayerEnter="";
public const string RmiName_PlayerExit="";
       
public const string RmiName_First = "";
		#endif

		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}
namespace PowerupC2S
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool EnterRoom(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.EnterRoom;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_EnterRoom, Common.EnterRoom);
        }
}

public bool EnterRoom(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.EnterRoom;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_EnterRoom, Common.EnterRoom);
        }
}
public bool ExitRoom(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.ExitRoom;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_ExitRoom, Common.ExitRoom);
        }
}

public bool ExitRoom(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.ExitRoom;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_ExitRoom, Common.ExitRoom);
        }
}
public bool GetReady(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, bool isReady)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.GetReady;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, isReady);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_GetReady, Common.GetReady);
        }
}

public bool GetReady(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, bool isReady)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.GetReady;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, isReady);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_GetReady, Common.GetReady);
        }
}
public bool Move(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int key, std.vector<int32_t> enemies)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Move;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, key);
		Nettention.Proud.Marshaler.Write(__msg, enemies);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Move, Common.Move);
        }
}

public bool Move(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int key, std.vector<int32_t> enemies)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Move;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, key);
Nettention.Proud.Marshaler.Write(__msg, enemies);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Move, Common.Move);
        }
}
public bool HasPoint(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int point)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
		{
		Nettention.Proud.Message __msg=freeList.GetObject();
		__msg.Clear();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.HasPoint;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, point);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_HasPoint, Common.HasPoint);
        }
}

public bool HasPoint(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int point)
{
	using (Nettention.Proud.FreeListPopper<Nettention.Proud.Message> freeList = new Nettention.Proud.FreeListPopper<Nettention.Proud.Message>())
{
Nettention.Proud.Message __msg=freeList.GetObject();
__msg.Clear();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.HasPoint;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, point);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_HasPoint, Common.HasPoint);
        }
}
	
		#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_EnterRoom="EnterRoom";
public const string RmiName_ExitRoom="ExitRoom";
public const string RmiName_GetReady="GetReady";
public const string RmiName_Move="Move";
public const string RmiName_HasPoint="HasPoint";
       
public const string RmiName_First = RmiName_EnterRoom;
		#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_EnterRoom="";
public const string RmiName_ExitRoom="";
public const string RmiName_GetReady="";
public const string RmiName_Move="";
public const string RmiName_HasPoint="";
       
public const string RmiName_First = "";
		#endif

		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}
