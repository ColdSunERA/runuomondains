using System;
using Server.Items;

namespace Server.Items
{
    public class ShroudofDeceit : BoneChest, ITokunoDyable
    {
        public override int LabelNumber { get { return 1094914; } } // Shroud of Deceit [Replica]

		public override int BasePhysicalResistance{ get{ return 11; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 18; } }
		public override int BasePoisonResistance{ get{ return 15; } }
		public override int BaseEnergyResistance{ get{ return 13; } }

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

		public override bool CanFortify{ get{ return false; } }

		[Constructable]
		public ShroudofDeceit()
        {
            Hue = 0x3C1;
            Attributes.RegenHits = 3;
            ArmorAttributes.MageArmor = 1;

            SkillBonuses.SetValues(0, SkillName.MagicResist, 10);
		}

        public ShroudofDeceit(Serial serial)
            : base(serial)
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}