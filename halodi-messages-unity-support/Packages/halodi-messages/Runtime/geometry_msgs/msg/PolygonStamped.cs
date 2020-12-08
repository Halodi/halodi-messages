using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents a Polygon with reference coordinate frame and timestamp
       */
[System.Serializable]
public class PolygonStamped : Halodi.CDR.DataType<PolygonStamped>
{

	public Halodi.CDR.TopicDataType<PolygonStamped> Type => new PolygonStampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Polygon polygon;


   public void Set(PolygonStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PolygonPubSubType.Copy(other.polygon, polygon);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PolygonStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("polygon=");
      builder.Append(this.polygon);
      builder.Append("}");
      return builder.ToString();
   }
}


}