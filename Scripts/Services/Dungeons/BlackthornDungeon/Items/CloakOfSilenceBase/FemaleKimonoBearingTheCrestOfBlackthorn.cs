namespace Server.Items
{
    public class FemaleKimonoBearingTheCrestOfBlackthorn3 : FemaleKimono
    {
        public override bool IsArtifact => true;

        [Constructable]
        public FemaleKimonoBearingTheCrestOfBlackthorn3()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            SkillBonuses.SetValues(0, SkillName.Stealth, 10.0);
            Hue = 2130;
        }

        public FemaleKimonoBearingTheCrestOfBlackthorn3(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            reader.ReadInt();
        }
    }
}
