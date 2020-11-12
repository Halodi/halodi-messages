using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents an orientation with reference coordinate frame and timestamp.
       */
[System.Serializable]
public class QuaternionStamped
{
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Quaternion quaternion;


   public void Set(QuaternionStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.quaternion, quaternion);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("QuaternionStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("quaternion=");
      builder.Append(this.quaternion);
      builder.Append("}");
      return builder.ToString();
   }
}


}