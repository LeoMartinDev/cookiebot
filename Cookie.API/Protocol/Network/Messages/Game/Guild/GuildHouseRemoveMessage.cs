//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class GuildHouseRemoveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6180;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get
            {
                return m_instanceId;
            }
            set
            {
                m_instanceId = value;
            }
        }
        
        private bool m_secondHand;
        
        public virtual bool SecondHand
        {
            get
            {
                return m_secondHand;
            }
            set
            {
                m_secondHand = value;
            }
        }
        
        public GuildHouseRemoveMessage(uint houseId, int instanceId, bool secondHand)
        {
            m_houseId = houseId;
            m_instanceId = instanceId;
            m_secondHand = secondHand;
        }
        
        public GuildHouseRemoveMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_houseId);
            writer.WriteInt(m_instanceId);
            writer.WriteBoolean(m_secondHand);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_houseId = reader.ReadVarUhInt();
            m_instanceId = reader.ReadInt();
            m_secondHand = reader.ReadBoolean();
        }
    }
}