using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class Accel
{
   /**
            * This expresses acceleration in free space broken into its linear and angular parts.
            */
   public geometry_msgs.msg.Vector3 linear;
   public geometry_msgs.msg.Vector3 angular;


   public void Set(Accel other)
   {
      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear, linear);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular, angular);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Accel {");
      builder.Append("linear=");
      builder.Append(this.linear);      builder.Append(", ");
      builder.Append("angular=");
      builder.Append(this.angular);
      builder.Append("}");
      return builder.ToString();
   }
}


}