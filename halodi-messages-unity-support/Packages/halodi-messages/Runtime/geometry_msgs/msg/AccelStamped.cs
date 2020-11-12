using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class AccelStamped
{
   /**
            * An accel with reference coordinate frame and timestamp
            */
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Accel accel;


   public void Set(AccelStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.AccelPubSubType.Copy(other.accel, accel);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("AccelStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("accel=");
      builder.Append(this.accel);
      builder.Append("}");
      return builder.ToString();
   }
}


}