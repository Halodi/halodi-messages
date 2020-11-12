using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents a Point with reference coordinate frame and timestamp
       */
[System.Serializable]
public class PointStamped
{
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Point point;


   public void Set(PointStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PointPubSubType.Copy(other.point, point);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PointStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("point=");
      builder.Append(this.point);
      builder.Append("}");
      return builder.ToString();
   }
}


}