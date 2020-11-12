using System.Text;
namespace geometry_msgs.msg
{


/**
       * A twist with reference coordinate frame and timestamp
       */
[System.Serializable]
public class TwistStamped
{
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Twist twist;


   public void Set(TwistStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.TwistPubSubType.Copy(other.twist, twist);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TwistStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("twist=");
      builder.Append(this.twist);
      builder.Append("}");
      return builder.ToString();
   }
}


}