using System;

namespace Server.Items
{
    [FlipableAttribute(0x9A1C, 0x9A1D)]
    public class JadeSkull : Item
    {
        public override int LabelNumber { get { return 1123476; } } // Jade Skull

        [Constructable]
        public JadeSkull()
            : base(0x9A1C)
        {          
        }

        public JadeSkull(Serial serial)
            : base(serial)
        {
        }
        
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
