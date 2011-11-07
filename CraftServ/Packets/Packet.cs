//  
//  Packet.cs
//  
//  Author:
//       Caleb Gibbs <cmacgibbs@gmail.com>
// 
//  Copyright (c) 2011 Caleb Gibbs
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace CraftServ
{
	public enum PacketID
	{
		Ping = 0x00,
		LoginRequest = 0x01,
		Handshake = 0x02,
		ChatMessage = 0x03,
		TimeUpdate = 0x04,
		EntityEquipment = 0x05,
		SpawnPosition = 0x06,
		UseEntity = 0x07,
		UpdateHealth = 0x08,
		Respawn = 0x09,
		Player = 0x0A,
		PlayerPosition = 0x0B,
		PlayerLook = 0x0C,
		PlayerPosLook = 0x0D,
		PlayerDigging = 0x0E,
		PlayerBlockPlace = 0x0F,
		HoldingChange = 0x10,
		UseBed = 0x11,
		Animation = 0x12,
		EntityAction = 0x13,
		NamedEntitySpawn = 0x14,
		PickupSpawn = 0x15,
		CollectItem = 0x16,
		AddObject = 0x17,
		MobSpawn = 0x18,
		EntityPainting = 0x19,
		ExperienceOrb = 0x1A,
		StanceUpdate = 0x1B,
		EntityVelocity = 0x1C,
		DestroyEntity = 0x1D,
		Entity = 0x1E,
		EntityRelativeMove = 0x1F,
		EntityLook = 0x20,
		EntityLookAndRelativeMode = 0x21,
		EntityTeleport = 0x22,
		EntityStatus = 0x26,
		AttachEntity = 0x27,
		EntityMetadata = 0x28,
		EntityEffect = 0x29,
		RemoveEntityEffect = 0x2A,
		Experience = 0x2B,
		PreChunk = 0x32,
		MapChunk = 0x33,
		MultiBlockChange = 0x34,
		BlockChange = 0x35,
		BlockAction = 0x36,
		Explosion = 0x3C,
		SoundEffect = 0x3D,
		NewOrInvalidState = 0x46,
		Thunderbolt = 0x47, // I'm gonna have some fun with this >:3
		OpenWindow = 0x64,
		CloseWindow = 0x65,
		WindowClick = 0x66,
		SetSlot = 0x67,
		WindowItems = 0x68,
		UpdateProgressBar = 0x69,
		Transaction = 0x6A, // ??
		CreativeInventoryAction = 0x6B,
		UpdateSign = 0x82, // This gives me some ideas
		ItemData = 0x83,
		IncrementStatistic = 0xC8,
		PlayerListItem = 0xC9,
		ServerListPing = 0xFE,
		Kick = 0xFF
	}
	
	public class Packet
	{
		public Packet ()
		{
		}
	}
}

