﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.


#include "Powerup_proxy.h"

namespace PowerupS2G {


        
	bool Proxy::GameStart ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext )	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GameStart;
__msg.Write(__msgid); 
	
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_GameStart, (::Proud::RmiID)Rmi_GameStart);
	}

	bool Proxy::GameStart ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GameStart;
__msg.Write(__msgid); 
	
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_GameStart, (::Proud::RmiID)Rmi_GameStart);
	}
        
	bool Proxy::GameEnd ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext )	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GameEnd;
__msg.Write(__msgid); 
	
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_GameEnd, (::Proud::RmiID)Rmi_GameEnd);
	}

	bool Proxy::GameEnd ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GameEnd;
__msg.Write(__msgid); 
	
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_GameEnd, (::Proud::RmiID)Rmi_GameEnd);
	}
        
	bool Proxy::PlayersReady ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const std::map<int32_t,bool> & playersReady)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayersReady;
__msg.Write(__msgid); 
	
__msg << playersReady;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_PlayersReady, (::Proud::RmiID)Rmi_PlayersReady);
	}

	bool Proxy::PlayersReady ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const std::map<int32_t,bool> & playersReady)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayersReady;
__msg.Write(__msgid); 
	
__msg << playersReady;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_PlayersReady, (::Proud::RmiID)Rmi_PlayersReady);
	}
        
	bool Proxy::TimeNow ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const int64_t & ticksRemain)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_TimeNow;
__msg.Write(__msgid); 
	
__msg << ticksRemain;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_TimeNow, (::Proud::RmiID)Rmi_TimeNow);
	}

	bool Proxy::TimeNow ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const int64_t & ticksRemain)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_TimeNow;
__msg.Write(__msgid); 
	
__msg << ticksRemain;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_TimeNow, (::Proud::RmiID)Rmi_TimeNow);
	}
        
	bool Proxy::PlayerMove ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const int32_t & playerNo, const int32_t & key, const std::vector<int32_t> & enemies)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerMove;
__msg.Write(__msgid); 
	
__msg << playerNo;
__msg << key;
__msg << enemies;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_PlayerMove, (::Proud::RmiID)Rmi_PlayerMove);
	}

	bool Proxy::PlayerMove ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const int32_t & playerNo, const int32_t & key, const std::vector<int32_t> & enemies)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerMove;
__msg.Write(__msgid); 
	
__msg << playerNo;
__msg << key;
__msg << enemies;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_PlayerMove, (::Proud::RmiID)Rmi_PlayerMove);
	}
        
	bool Proxy::PlayersRank ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const std::map<int32_t,int32_t> & playersRank)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayersRank;
__msg.Write(__msgid); 
	
__msg << playersRank;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_PlayersRank, (::Proud::RmiID)Rmi_PlayersRank);
	}

	bool Proxy::PlayersRank ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const std::map<int32_t,int32_t> & playersRank)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayersRank;
__msg.Write(__msgid); 
	
__msg << playersRank;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_PlayersRank, (::Proud::RmiID)Rmi_PlayersRank);
	}
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_GameStart =_PNT("GameStart");
#else
const PNTCHAR* Proxy::RmiName_GameStart =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_GameEnd =_PNT("GameEnd");
#else
const PNTCHAR* Proxy::RmiName_GameEnd =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_PlayersReady =_PNT("PlayersReady");
#else
const PNTCHAR* Proxy::RmiName_PlayersReady =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_TimeNow =_PNT("TimeNow");
#else
const PNTCHAR* Proxy::RmiName_TimeNow =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_PlayerMove =_PNT("PlayerMove");
#else
const PNTCHAR* Proxy::RmiName_PlayerMove =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_PlayersRank =_PNT("PlayersRank");
#else
const PNTCHAR* Proxy::RmiName_PlayersRank =_PNT("");
#endif
const PNTCHAR* Proxy::RmiName_First = RmiName_GameStart;

}


namespace PowerupS2C {


        
	bool Proxy::PlayerEnter ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const bool & isEntered)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerEnter;
__msg.Write(__msgid); 
	
__msg << isEntered;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_PlayerEnter, (::Proud::RmiID)Rmi_PlayerEnter);
	}

	bool Proxy::PlayerEnter ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const bool & isEntered)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerEnter;
__msg.Write(__msgid); 
	
__msg << isEntered;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_PlayerEnter, (::Proud::RmiID)Rmi_PlayerEnter);
	}
        
	bool Proxy::PlayerExit ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const bool & isExited)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerExit;
__msg.Write(__msgid); 
	
__msg << isExited;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_PlayerExit, (::Proud::RmiID)Rmi_PlayerExit);
	}

	bool Proxy::PlayerExit ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const bool & isExited)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_PlayerExit;
__msg.Write(__msgid); 
	
__msg << isExited;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_PlayerExit, (::Proud::RmiID)Rmi_PlayerExit);
	}
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_PlayerEnter =_PNT("PlayerEnter");
#else
const PNTCHAR* Proxy::RmiName_PlayerEnter =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_PlayerExit =_PNT("PlayerExit");
#else
const PNTCHAR* Proxy::RmiName_PlayerExit =_PNT("");
#endif
const PNTCHAR* Proxy::RmiName_First = RmiName_PlayerEnter;

}


namespace PowerupC2S {


        
	bool Proxy::EnterRoom ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext )	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_EnterRoom;
__msg.Write(__msgid); 
	
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_EnterRoom, (::Proud::RmiID)Rmi_EnterRoom);
	}

	bool Proxy::EnterRoom ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_EnterRoom;
__msg.Write(__msgid); 
	
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_EnterRoom, (::Proud::RmiID)Rmi_EnterRoom);
	}
        
	bool Proxy::ExitRoom ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext )	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_ExitRoom;
__msg.Write(__msgid); 
	
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_ExitRoom, (::Proud::RmiID)Rmi_ExitRoom);
	}

	bool Proxy::ExitRoom ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_ExitRoom;
__msg.Write(__msgid); 
	
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_ExitRoom, (::Proud::RmiID)Rmi_ExitRoom);
	}
        
	bool Proxy::GetReady ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const bool & isReady)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GetReady;
__msg.Write(__msgid); 
	
__msg << isReady;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_GetReady, (::Proud::RmiID)Rmi_GetReady);
	}

	bool Proxy::GetReady ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const bool & isReady)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_GetReady;
__msg.Write(__msgid); 
	
__msg << isReady;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_GetReady, (::Proud::RmiID)Rmi_GetReady);
	}
        
	bool Proxy::Move ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const int32_t & key, const std::vector<int32_t> & enemies)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_Move;
__msg.Write(__msgid); 
	
__msg << key;
__msg << enemies;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_Move, (::Proud::RmiID)Rmi_Move);
	}

	bool Proxy::Move ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const int32_t & key, const std::vector<int32_t> & enemies)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_Move;
__msg.Write(__msgid); 
	
__msg << key;
__msg << enemies;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_Move, (::Proud::RmiID)Rmi_Move);
	}
        
	bool Proxy::HasPoint ( ::Proud::HostID remote, ::Proud::RmiContext& rmiContext , const int32_t & point)	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_HasPoint;
__msg.Write(__msgid); 
	
__msg << point;
		
		return RmiSend(&remote,1,rmiContext,__msg,
			RmiName_HasPoint, (::Proud::RmiID)Rmi_HasPoint);
	}

	bool Proxy::HasPoint ( ::Proud::HostID *remotes, int remoteCount, ::Proud::RmiContext &rmiContext, const int32_t & point)  	{
		::Proud::CMessage __msg;
__msg.UseInternalBuffer();
__msg.SetSimplePacketMode(m_core->IsSimplePacketMode());

::Proud::RmiID __msgid=(::Proud::RmiID)Rmi_HasPoint;
__msg.Write(__msgid); 
	
__msg << point;
		
		return RmiSend(remotes,remoteCount,rmiContext,__msg,
			RmiName_HasPoint, (::Proud::RmiID)Rmi_HasPoint);
	}
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_EnterRoom =_PNT("EnterRoom");
#else
const PNTCHAR* Proxy::RmiName_EnterRoom =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_ExitRoom =_PNT("ExitRoom");
#else
const PNTCHAR* Proxy::RmiName_ExitRoom =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_GetReady =_PNT("GetReady");
#else
const PNTCHAR* Proxy::RmiName_GetReady =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_Move =_PNT("Move");
#else
const PNTCHAR* Proxy::RmiName_Move =_PNT("");
#endif
#ifdef USE_RMI_NAME_STRING
const PNTCHAR* Proxy::RmiName_HasPoint =_PNT("HasPoint");
#else
const PNTCHAR* Proxy::RmiName_HasPoint =_PNT("");
#endif
const PNTCHAR* Proxy::RmiName_First = RmiName_EnterRoom;

}


