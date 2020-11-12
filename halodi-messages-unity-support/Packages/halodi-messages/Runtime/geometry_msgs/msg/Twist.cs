using System.Text;
namespace geometry_msgs.msg
{


/**
       * This expresses velocity in free space broken into its linear and angular parts.
       */
[System.Serializable]
public class Twist
{
   public geometry_msgs.msg.Vector3 linear;
   public geometry_msgs.msg.Vector3 angular;


   public void Set(Twist other)
   {
      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear, linear);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular, angular);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Twist {");
      builder.Append("linear=");
      builder.Append(this.linear);      builder.Append(", ");
      builder.Append("angular=");
      builder.Append(this.angular);
      builder.Append("}");
      return builder.ToString();
   }
}


}