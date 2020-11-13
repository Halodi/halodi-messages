using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents force in free space, separated into its linear and angular parts.
       */
[System.Serializable]
public class Wrench : Halodi.CDR.DataType<Wrench>
{

	public Halodi.CDR.TopicDataType<Wrench> Type => new WrenchPubSubType();
	
   public geometry_msgs.msg.Vector3 force;
   public geometry_msgs.msg.Vector3 torque;


   public void Set(Wrench other)
   {
      geometry_msgs.msg.Vector3PubSubType.Copy(other.force, force);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.torque, torque);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Wrench {");
      builder.Append("force=");
      builder.Append(this.force);      builder.Append(", ");
      builder.Append("torque=");
      builder.Append(this.torque);
      builder.Append("}");
      return builder.ToString();
   }
}


}