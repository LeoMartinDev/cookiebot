namespace Cookie.Protocol.Network.Types.Game.House
{
    using Cookie.IO;
    using System.Collections.Generic;


    public class HouseInformationsForSell : NetworkType
    {
        
        public const short ProtocolId = 221;
        
        public override short TypeID => ProtocolId;

        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get => m_instanceId;
            set => m_instanceId = value;
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
        
        private uint m_modelId;
        
        public virtual uint ModelId
        {
            get
            {
                return m_modelId;
            }
            set
            {
                m_modelId = value;
            }
        }
        
        private string m_ownerName;
        
        public virtual string OwnerName
        {
            get
            {
                return m_ownerName;
            }
            set
            {
                m_ownerName = value;
            }
        }
        
        private bool m_ownerConnected;
        
        public virtual bool OwnerConnected
        {
            get
            {
                return m_ownerConnected;
            }
            set
            {
                m_ownerConnected = value;
            }
        }
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private byte m_nbRoom;
        
        public virtual byte NbRoom
        {
            get
            {
                return m_nbRoom;
            }
            set
            {
                m_nbRoom = value;
            }
        }
        
        private byte m_nbChest;
        
        public virtual byte NbChest
        {
            get
            {
                return m_nbChest;
            }
            set
            {
                m_nbChest = value;
            }
        }

        private List<int> m_skillListIds;

        public virtual List<int> SkillListIds
        {
            get
            {
                return m_skillListIds;
            }
            set
            {
                m_skillListIds = value;
            }
        }

        private bool m_isLocked;
        
        public virtual bool IsLocked
        {
            get
            {
                return m_isLocked;
            }
            set
            {
                m_isLocked = value;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        public HouseInformationsForSell(List<int> skillListIds, int instanceId, bool secondHand, uint modelId, string ownerName, bool ownerConnected, short worldX, short worldY, ushort subAreaId, byte nbRoom, byte nbChest, bool isLocked, ulong price)
        {
            m_skillListIds = skillListIds;
            m_instanceId = instanceId;
            m_secondHand = secondHand;
            m_modelId = modelId;
            m_ownerName = ownerName;
            m_ownerConnected = ownerConnected;
            m_worldX = worldX;
            m_worldY = worldY;
            m_subAreaId = subAreaId;
            m_nbRoom = nbRoom;
            m_nbChest = nbChest;
            m_isLocked = isLocked;
            m_price = price;
        }
        
        public HouseInformationsForSell()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_instanceId);
            writer.WriteBoolean(m_secondHand);
            writer.WriteVarUhInt(m_modelId);
            writer.WriteUTF(m_ownerName);
            writer.WriteBoolean(m_ownerConnected);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteByte(m_nbRoom);
            writer.WriteByte(m_nbChest);
            writer.WriteShort(((short)(m_skillListIds.Count)));
            int skillListIdsIndex;
            for (skillListIdsIndex = 0; (skillListIdsIndex < m_skillListIds.Count); skillListIdsIndex = (skillListIdsIndex + 1))
            {
                writer.WriteInt(m_skillListIds[skillListIdsIndex]);
            }
            writer.WriteBoolean(m_isLocked);
            writer.WriteVarUhLong(m_price);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_instanceId = reader.ReadInt();
            m_secondHand = reader.ReadBoolean();
            m_modelId = reader.ReadVarUhInt();
            m_ownerName = reader.ReadUTF();
            m_ownerConnected = reader.ReadBoolean();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_subAreaId = reader.ReadVarUhShort();
            m_nbRoom = reader.ReadByte();
            m_nbChest = reader.ReadByte();
            int skillListIdsCount = reader.ReadUShort();
            int skillListIdsIndex;
            m_skillListIds = new System.Collections.Generic.List<int>();
            for (skillListIdsIndex = 0; (skillListIdsIndex < skillListIdsCount); skillListIdsIndex = (skillListIdsIndex + 1))
            {
                m_skillListIds.Add(reader.ReadInt());
            }
            m_isLocked = reader.ReadBoolean();
            m_price = reader.ReadVarUhLong();
        }
    }
}
