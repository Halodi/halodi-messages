using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents a Vector3 with reference coordinate frame and timestamp
       */
[System.Serializable]
public class Vector3Stamped : Halodi.CDR.DataType<Vector3Stamped>
{

	public Halodi.CDR.TopicDataType<Vector3Stamped> Type => new Vector3StampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Vector3 vector;


   public void Set(Vector3Stamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.vector, vector);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Vector3Stamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("vector=");
      builder.Append(this.vector);
      builder.Append("}");
      return builder.ToString();
   }
}


}