﻿#region License
// Copyright (c) 2005-2012, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

namespace ZoneEngine.Packets
{
    using System.Collections.Generic;

    using AO.Core;

    using ZoneEngine.Misc;

    public static class AppearanceUpdate
    {
        public static void AnnounceAppearanceUpdate(Character character)
        {
            List<AOMeshs> meshs;
            PacketWriter packetWriter = new PacketWriter();
            packetWriter.PushByte(0xDF);
            packetWriter.PushByte(0xDF);
            packetWriter.PushShort(10);
            packetWriter.PushShort(1);
            packetWriter.PushShort(0); // Packet size. writer will take care of this
            packetWriter.PushInt(3086);
            packetWriter.PushInt(character.Id);
            packetWriter.PushInt(0x41624F0D);
            packetWriter.PushIdentity(50000, character.Id);
            packetWriter.PushByte(0);
            packetWriter.Push3F1Count(5); // Textures are always transferred
            int c;

            bool socialonly;
            bool showsocial;
            /*
            bool showhelmet;
            bool LeftPadVisible;
            bool RightPadVisible;
            bool DoubleLeftPad;
            bool DoubleRightPad;

            int TexturesCount;
            int HairMeshValue;
            int WeaponMeshRightValue;
            int WeaponMeshLeftValue;

            uint HeadMeshBaseValue;
            int HeadMeshValue;

            int BackMeshValue;
            int ShoulderMeshRightValue;
             */
            //int ShoulderMeshRightValue;

            int VisualFlags;
            int PlayField;
            /*
            int OverrideTextureHead;
            int OverrideTextureWeaponRight;
            int OverrideTextureWeaponLeft;
            int OverrideTextureShoulderpadRight;
            int OverrideTextureShoulderpadLeft;
            int OverrideTextureBack;
            int OverrideTextureAttractor;
            */
            List<AOTextures> textures = new List<AOTextures>();

            Dictionary<int, int> socialTab = new Dictionary<int, int>();

            lock (character)
            {
                VisualFlags = character.Stats.VisualFlags.Value;

                socialonly = ((character.Stats.VisualFlags.Value & 0x40) > 0);
                showsocial = ((character.Stats.VisualFlags.Value & 0x20) > 0);
                /*
                showhelmet = ((character.Stats.VisualFlags.Value & 0x4) > 0);
                LeftPadVisible = ((character.Stats.VisualFlags.Value & 0x1) > 0);
                RightPadVisible = ((character.Stats.VisualFlags.Value & 0x2) > 0);
                DoubleLeftPad = ((character.Stats.VisualFlags.Value & 0x8) > 0);
                DoubleRightPad = ((character.Stats.VisualFlags.Value & 0x10) > 0);

                HairMeshValue = character.Stats.HairMesh.Value;
                TexturesCount = character.Textures.Count;
                HairMeshValue = character.Stats.HairMesh.Value;
                WeaponMeshRightValue = character.Stats.WeaponMeshRight.Value;
                WeaponMeshLeftValue = character.Stats.WeaponMeshLeft.Value;

                HeadMeshBaseValue = character.Stats.HeadMesh.StatBaseValue;
                HeadMeshValue = character.Stats.HeadMesh.Value;

                BackMeshValue = character.Stats.BackMesh.Value;
                ShoulderMeshRightValue = character.Stats.ShoulderMeshRight.Value;
                 */
                //ShoulderMeshLeftValue = character.Stats.ShoulderMeshLeft.Value;
                /*
                OverrideTextureHead = character.Stats.OverrideTextureHead.Value;
                OverrideTextureWeaponRight = character.Stats.OverrideTextureWeaponRight.Value;
                OverrideTextureWeaponLeft = character.Stats.OverrideTextureWeaponLeft.Value;
                OverrideTextureShoulderpadRight = character.Stats.OverrideTextureShoulderpadRight.Value;
                OverrideTextureShoulderpadLeft = character.Stats.OverrideTextureShoulderpadLeft.Value;
                OverrideTextureBack = character.Stats.OverrideTextureBack.Value;
                OverrideTextureAttractor = character.Stats.OverrideTextureAttractor.Value;
                */
                PlayField = character.PlayField;

                foreach (int num in character.SocialTab.Keys)
                {
                    socialTab.Add(num, character.SocialTab[num]);
                }

                foreach (AOTextures texture in character.Textures)
                {
                    textures.Add(new AOTextures(texture.place, texture.Texture));
                }

                meshs = MeshLayers.GetMeshs(character, showsocial, socialonly);
            }

            AOTextures aotemp = new AOTextures(0, 0);
            for (c = 0; c < 5; c++)
            {
                aotemp.Texture = 0;
                aotemp.place = c;
                int c2;
                for (c2 = 0; c2 < textures.Count; c2++)
                {
                    if (textures[c2].place == c)
                    {
                        aotemp.Texture = textures[c2].Texture;
                        break;
                    }
                }
                if (showsocial)
                {
                    if (socialonly)
                    {
                        aotemp.Texture = socialTab[c];
                    }
                    else
                    {
                        if (socialTab[c] != 0)
                        {
                            aotemp.Texture = socialTab[c];
                        }
                    }
                }

                packetWriter.PushInt(aotemp.place);
                packetWriter.PushInt(aotemp.Texture);
                packetWriter.PushInt(0);
            }

            c = meshs.Count;
            packetWriter.Push3F1Count(c);
            foreach (AOMeshs mesh in meshs)
            {
                packetWriter.PushByte((byte)mesh.Position);
                packetWriter.PushUInt(mesh.Mesh);
                packetWriter.PushInt(mesh.OverrideTexture); // Override Texture!!!!!!
                packetWriter.PushByte((byte)mesh.Layer);
            }

            packetWriter.PushShort((short)(VisualFlags)); // 673 = VisualFlags
            packetWriter.PushByte(0);

            byte[] reply = packetWriter.Finish();
            Announce.Playfield(PlayField, reply);
        }
    }
}