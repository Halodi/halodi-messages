using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class PassivityData : Halodi.CDR.DataType<PassivityData>
{

	public Halodi.CDR.TopicDataType<PassivityData> Type => new PassivityDataPubSubType();
	
   public double energy_packet;
   public double energy_tank_level;
   public double virtual_mass;


   public void Set(PassivityData other)
   {
      energy_packet = other.energy_packet;

      energy_tank_level = other.energy_tank_level;

      virtual_mass = other.virtual_mass;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PassivityData {");
      builder.Append("energy_packet=");
      builder.Append(this.energy_packet);      builder.Append(", ");
      builder.Append("energy_tank_level=");
      builder.Append(this.energy_tank_level);      builder.Append(", ");
      builder.Append("virtual_mass=");
      builder.Append(this.virtual_mass);
      builder.Append("}");
      return builder.ToString();
   }
}


}