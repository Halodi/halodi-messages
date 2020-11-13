using System.Text;
namespace geometry_msgs.msg
{


/**
       * A wrench with reference coordinate frame and timestamp
       */
[System.Serializable]
public class WrenchStamped : Halodi.CDR.DataType<WrenchStamped>
{

	public Halodi.CDR.TopicDataType<WrenchStamped> Type => new WrenchStampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Wrench wrench;


   public void Set(WrenchStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.WrenchPubSubType.Copy(other.wrench, wrench);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("WrenchStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("wrench=");
      builder.Append(this.wrench);
      builder.Append("}");
      return builder.ToString();
   }
}


}