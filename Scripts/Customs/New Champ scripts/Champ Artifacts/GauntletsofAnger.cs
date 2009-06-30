using System;
using Server.Items;

namespace Server.Items
{
    public class GauntletsofAnger : PlateGloves
	{
        public override int LabelNumber { get { return 1094902; } } // Gauntlets of Anger [Replica]

		public override int BasePhysicalResistance{ get{ return 4; } }
		public override int BaseFireResistance{ get{ return 4; } }
		public override int BaseColdResistance{ get{ return 5; } }
		public override int BasePoisonResistance{ get{ return 6; } }
		public override int BaseEnergyResistance{ get{ return 5; } }

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }


		[Constructable]
		public GauntletsofAnger()
        {
            Hue = 0x483;

            Attributes.BonusHits = 8;
            Attributes.RegenHits = 2;
            Attributes.DefendChance = 10;
		}

        public GauntletsofAnger(Serial serial)
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

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}